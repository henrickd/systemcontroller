//Variables for input
double pwm_val = 255;
unsigned long serial_data;
int led_mode, red, green, blue, interval;
int red_temp, green_temp, blue_temp;
int wait = 1000;
unsigned long timeout = 0;
unsigned long last_timeout = 0;
unsigned long sendtime = 0;
unsigned long last_sendtime = 0;

//Variables for output
volatile byte half_revolutions_0;
volatile byte half_revolutions_1;
unsigned int rpm_0;
unsigned int rpm_1;
unsigned int rpm;
char rpm_s[10];
unsigned long timeold_0;
unsigned long timeold_1;
unsigned long led_time = 0;
unsigned long last_led_time = 0;
int fade = 0;
int fade_in = 1;
int flash_in = 1;
int error_mode = 0;

void setup()
{
  //---------------------------------------------- Set PWM frequency for D5 & D6 -------------------------------

  //TCCR0B = TCCR0B & B11111000 | B00000001;    // set timer 0 divisor to     1 for PWM frequency of 62500.00 Hz
  //TCCR0B = TCCR0B & B11111000 | B00000010;    // set timer 0 divisor to     8 for PWM frequency of  7812.50 Hz
  TCCR0B = TCCR0B & B11111000 | B00000011;    // set timer 0 divisor to    64 for PWM frequency of   976.56 Hz (The DEFAULT)
  //TCCR0B = TCCR0B & B11111000 | B00000100;    // set timer 0 divisor to   256 for PWM frequency of   244.14 Hz
  //TCCR0B = TCCR0B & B11111000 | B00000101;    // set timer 0 divisor to  1024 for PWM frequency of    61.04 Hz


  //---------------------------------------------- Set PWM frequency for D9 & D10 ------------------------------

  TCCR1B = TCCR1B & B11111000 | B00000001;    // set timer 1 divisor to     1 for PWM frequency of 31372.55 Hz
  //TCCR1B = TCCR1B & B11111000 | B00000010;    // set timer 1 divisor to     8 for PWM frequency of  3921.16 Hz
  //TCCR1B = TCCR1B & B11111000 | B00000011;    // set timer 1 divisor to    64 for PWM frequency of   490.20 Hz (The DEFAULT)
  //TCCR1B = TCCR1B & B11111000 | B00000100;    // set timer 1 divisor to   256 for PWM frequency of   122.55 Hz
  //TCCR1B = TCCR1B & B11111000 | B00000101;    // set timer 1 divisor to  1024 for PWM frequency of    30.64 Hz

  //---------------------------------------------- Set PWM frequency for D3 & D11 ------------------------------

  //TCCR2B = TCCR2B & B11111000 | B00000001;    // set timer 2 divisor to     1 for PWM frequency of 31372.55 Hz
  //TCCR2B = TCCR2B & B11111000 | B00000010;    // set timer 2 divisor to     8 for PWM frequency of  3921.16 Hz
  TCCR2B = TCCR2B & B11111000 | B00000011;    // set timer 2 divisor to    32 for PWM frequency of   980.39 Hz
  //TCCR2B = TCCR2B & B11111000 | B00000100;    // set timer 2 divisor to    64 for PWM frequency of   490.20 Hz (The DEFAULT)
  //TCCR2B = TCCR2B & B11111000 | B00000101;    // set timer 2 divisor to   128 for PWM frequency of   245.10 Hz
  //TCCR2B = TCCR2B & B11111000 | B00000110;    // set timer 2 divisor to   256 for PWM frequency of   122.55 Hz
  //TCCR2B = TCCR2B & B11111000 | B00000111;    // set timer 2 divisor to  1024 for PWM frequency of    30.64 Hz

  //Setup for input
  Serial.begin(9600);
  Serial.setTimeout(10);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  digitalWrite(9, HIGH);
  digitalWrite(10, HIGH);
  

  //Setup for output
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(11, OUTPUT);
  attachInterrupt(0, rpm_increment_0, RISING);
  attachInterrupt(1, rpm_increment_1, RISING);
  half_revolutions_0 = 0;
  half_revolutions_1 = 0;
  rpm_0 = 0;
  rpm_1 = 0;
  timeold_0 = 0;
  timeold_1 = 0;
  randomSeed(analogRead(0));

  delay(2000);
}

//Functions for incrementing RPM
void rpm_increment_0()
{
  half_revolutions_0++;
  if (pwm_val == -1)
  {
    analogWrite(9,255);
    analogWrite(10,255);
  }
  else
  {
    analogWrite(9, pwm_val);
    analogWrite(10, pwm_val);
  }
}

void rpm_increment_1()
{
  half_revolutions_1++;
    if (pwm_val == -1)
  {
    analogWrite(9,255);
    analogWrite(10,255);
  }
  else
  {
    analogWrite(9, pwm_val);
    analogWrite(10, pwm_val);
  }
}

void loop()
{
  //RPM
  if (half_revolutions_0 >= 20) {
    rpm_0 = 30 * 1000 / (millis() - timeold_0) * half_revolutions_0;
    timeold_0 = millis();
    half_revolutions_0 = 0;
  }
  else if (half_revolutions_1 >= 20) {
    rpm_1 = 30 * 1000 / (millis() - timeold_1) * half_revolutions_1;
    timeold_1 = millis();
    half_revolutions_1 = 0;
  }
  rpm = 0.5 * (rpm_0 + rpm_1);

  //Sending output
  sendtime = millis();
  if (sendtime - last_sendtime > wait*2)
  {
    itoa(rpm, rpm_s, 10);
    Serial.println(rpm_s);
    last_sendtime = millis();
  }

  //Getting input
  timeout = millis();
  if (Serial.available() > 0)
  {
    error_mode = 0;
    last_timeout = millis();
    if (Serial.read() == '\n')
    {
      pwm_val = Serial.parseInt();
      led_mode = Serial.parseInt();
      red_temp = Serial.parseInt();
      green_temp = Serial.parseInt();
      blue_temp = Serial.parseInt();
      interval = Serial.parseInt();
    }
    if (pwm_val < 5)
      pwm_val = 0;
    else
      pwm_val = 75 + pwm_val*1.8;
    analogWrite(9, pwm_val);
    analogWrite(10, pwm_val);
  }
  if (timeout - last_timeout > 5 * wait)
  {
    error_mode++; 
  }
  if (error_mode >= 3)
  {
    pwm_val = -1;
  }
  if (pwm_val == -1)
  {
    analogWrite(9,255);
    analogWrite(10,255);
  }

  //LEDs
  if (led_mode == 0)
  {
    red = red_temp;
    green = green_temp;
    blue = blue_temp;
    analogWrite(5,blue);
    analogWrite(6,red);
    analogWrite(11,green);
  }
  else if (led_mode == 1 || led_mode == 2 || led_mode == 4)
  {
    if (led_mode == 2)
    {
      interval = random(200000,2000000);
    }
    if (flash_in == -1){
      red = red_temp;
      green = green_temp;
      blue = blue_temp;
    }
    led_time = millis();
    if (led_time-last_led_time > interval){
      last_led_time = millis();
      analogWrite(5,(int)((0.5+0.5*flash_in)*blue));
      analogWrite(6,(int)((0.5+0.5*flash_in)*red));
      analogWrite(11,(int)((0.5+0.5*flash_in)*green));
      flash_in *= -1;
    } 
  }
  else if (led_mode == 3)
  {
    if (fade_in == -1 && fade == 0){
      red = red_temp;
      green = green_temp;
      blue = blue_temp;
    }
    led_time = millis();
    if (led_time-last_led_time > interval/15)
    {
      last_led_time = millis();
      if ((fade == 255 && fade_in == 1) || (fade == 0 && fade_in == -1))
      {
        fade_in *= -1;
      }
      fade += fade_in*17;
    }
    analogWrite(5,(int)(fade*blue/255));
    analogWrite(6,(int)(fade*red/255));
    analogWrite(11,(int)(fade*green/255));
  }
}
