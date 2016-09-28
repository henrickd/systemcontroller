using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_controller
{
    public partial class SystemController : Form
    {
        //Variables related to temperatures
        double average = 0;
        double weighted_average = 0;
        double current_temp;
        int weighted;
        double cpu_weight = 2.0;
        double gpu_weight = 1.3;
        int gpu_selected = 1;

        //Variables related to fan curve
        int x_offset = 22;
        int x_size = 420;
        int y_size = 250;
        int x_pos, y_pos;
        int curve_locked;
        string curve;
        bool valid = false;
        int fan_speed;
        string rpm = "";
        List<int> x_coordinates = new List<int>();
        List<int> y_coordinates = new List<int>();
        List<int> x_coordinates_final = new List<int>();
        List<int> y_coordinates_final = new List<int>();

        //Variables related to LED control
        int mode, r, g, b, interval, auto_rgb, rgb_mode;
        int led_locked;
        int led_preview;
        string led_param;
        bool on = true;
        int fade = 0, fade_in = 1;
        bool random_flash = false;
        Random rand = new Random();

        //Variables related to serial
        SerialPort port = new SerialPort("COM3", 9600);
        static int average_period = 5;
        int fan_speed_averaged = 0;
        int[] fan_speed_temp = new int[average_period];
        bool first = true;

        //Other variables
        string checkbox;
        bool input = false;
        
        //Startup functions
        public SystemController()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            update_appearance();
            update_checkboxes();
            update_curve();
            update_led();
            try
            {
                port.Open();
            }
            catch (Exception e)
            {
                timer4.Enabled = false;
            }
            input = true;
        }

        public void update_appearance() //To make GUI look like intended (color, centering...)
        {
            ModifyComponent(Temps, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(CPU, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(CPUTemp, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(GPU1, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(GPU1Temp, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(GPU2, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(GPU2Temp, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(Average, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(AvgTemp, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(Cores, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(CoreTemps, Color.FromArgb(255, 0, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(Fans, Color.FromArgb(0, 255, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(Speed, Color.FromArgb(0, 255, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(SpeedVal, Color.FromArgb(0, 255, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(RPM, Color.FromArgb(0, 255, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(RPMVal, Color.FromArgb(0, 255, 0), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(Leds, Color.FromArgb(0, 0, 255), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(Timing, Color.FromArgb(0, 0, 255), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(Interval, Color.FromArgb(0, 0, 255), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(RGB, Color.FromArgb(0, 0, 255), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(R, Color.FromArgb(0, 0, 255), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(G, Color.FromArgb(0, 0, 255), HorizontalAlignment.Center, Color.Black);
            ModifyComponent(B, Color.FromArgb(0, 0, 255), HorizontalAlignment.Center, Color.Black);
        }
        
        public void update_checkboxes() //Load checkbox data from file
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader("checkboxes.txt");
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                StreamWriter writer = new StreamWriter("checkboxes.txt");
                writer.WriteLine("-1");
                writer.WriteLine("1");
                writer.WriteLine("1");
                writer.WriteLine("-1");
                writer.Close();
            }
            finally
            {
                reader = new StreamReader("checkboxes.txt");
                checkbox = reader.ReadLine();
                weighted = Convert.ToInt32(checkbox);
                if (weighted == -1)
                {
                    WeightedSelect.Checked = false;
                }
                else if (weighted == 1)
                {
                    WeightedSelect.Checked = true;
                }
                checkbox = reader.ReadLine();
                curve_locked = Convert.ToInt32(checkbox);
                if (curve_locked == -1)
                {
                    LockFanSelect.Checked = false;
                }
                else if (curve_locked == 1)
                {
                    LockFanSelect.Checked = true;
                }
                checkbox = reader.ReadLine();
                led_locked = Convert.ToInt32(checkbox);
                if (led_locked == -1)
                {
                    LockLEDSelect.Checked = false;
                    na.Enabled = true;
                    fl.Enabled = true;
                    rf.Enabled = true;
                    fd.Enabled = true;
                    tmp.Enabled = true;
                    Override.Enabled = true;
                    RGBTemp.Enabled = true;
                    RGBRandom.Enabled = true;
                }
                else if (led_locked == 1)
                {
                    LockLEDSelect.Checked = true;
                    na.Enabled = false;
                    fl.Enabled = false;
                    rf.Enabled = false;
                    fd.Enabled = false;
                    tmp.Enabled = false;
                    Override.Enabled = false;
                    RGBTemp.Enabled = false;
                    RGBRandom.Enabled = false;
                    
                }
                checkbox = reader.ReadLine();
                led_preview = Convert.ToInt32(checkbox);
                if (led_preview == -1)
                {
                    LEDPreviewSelect.Checked = false;
                }
                else if (led_preview == 1)
                {
                    LEDPreviewSelect.Checked = true;
                }
            }
            reader.Close();
        }

        public void update_curve() //Load fan curve data from file
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader("curve.txt");
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                Reset_Click(e, new EventArgs());
            }
            finally
            {
                reader = new StreamReader("curve.txt");
                if (reader == null)
                {
                    reader = new StreamReader("curve.txt");
                }
                for (; ; )
                {
                    curve = reader.ReadLine();
                    if (curve == "")
                    {
                        break;
                    }
                    x_coordinates_final.Add(Convert.ToInt32(curve));
                }
                for (; ; )
                {
                    curve = reader.ReadLine();
                    if (curve == "")
                    {
                        break;
                    }
                    y_coordinates_final.Add(Convert.ToInt32(curve));
                }
                reader.Close();
            }
        }

        public void update_led() //Load LED data from file
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader("led.txt");
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                StreamWriter writer = new StreamWriter("led.txt");
                writer.WriteLine("0");
                writer.WriteLine("-1");
                writer.WriteLine("0");
                writer.WriteLine("255");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("1000");
                writer.Close();
            }
            finally
            {
                reader = new StreamReader("led.txt");
                led_param = reader.ReadLine();
                mode = Convert.ToInt32(led_param);
                switch (mode)
                {
                    case 0:
                        na.Checked = true;
                        break;
                    case 1:
                        fl.Checked = true;
                        break;
                    case 2:
                        rf.Checked = true;
                        break;
                    case 3:
                        fd.Checked = true;
                        break;
                    case 4:
                        tmp.Checked = true;
                        break;
                }
                led_param = reader.ReadLine();
                auto_rgb = Convert.ToInt32(led_param);
                if (auto_rgb == 1)
                {
                    Override.Checked = true;
                }
                else if (auto_rgb == -1)
                {
                    Override.Checked = false;
                }
                led_param = reader.ReadLine();
                rgb_mode = Convert.ToInt32(led_param);
                update_override();
                led_param = reader.ReadLine();
                r = Convert.ToInt32(led_param);
                R.AppendText(led_param);
                led_param = reader.ReadLine();
                g = Convert.ToInt32(led_param);
                G.AppendText(led_param);
                led_param = reader.ReadLine();
                b = Convert.ToInt32(led_param);
                B.AppendText(led_param);
                led_param = reader.ReadLine();
                interval = Convert.ToInt32(led_param);
                Interval.AppendText(led_param);
                led_previewer();
                reader.Close();
            }
        }



        //Functions related to temperatures
        public ManagementObjectCollection get_info() //Gets WMI info
        {
            ManagementScope scope = new ManagementScope("ROOT\\OpenHardwareMonitor");
            ObjectQuery query = new ObjectQuery("SELECT * FROM Sensor WHERE Name LIKE \"CPU Package\" AND SensorType = \"Temperature\" OR Name LIKE \"GPU Core\" AND SensorType = \"Temperature\" OR Name LIKE \"%CPU Core #%\" AND SensorType = \"Temperature\"");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectCollection all_sensors = searcher.Get();
            return all_sensors;
        }

        private void timer1_Tick(object sender, EventArgs e) //Runs every second, updates system info
        {
            average = 0;
            weighted_average = 0;
            CPUTemp.Clear();
            GPU1Temp.Clear();
            GPU2Temp.Clear();
            AvgTemp.Clear();
            CoreTemps.Clear();
            SpeedVal.Clear();
            RPMVal.Clear();

            ManagementObjectCollection all_sensors = get_info();
            foreach (ManagementObject sensor in all_sensors)
            {
                String result = sensor["Value"].ToString();

                if (sensor["Name"].ToString().Equals("CPU Package"))
                {
                    CPUTemp.AppendText(result.Split('.')[0]);
                    average += Convert.ToDouble(result) / 3;
                    weighted_average += Convert.ToDouble(result) * (cpu_weight / (cpu_weight + 2 * gpu_weight));
                }
                else if (sensor["Name"].ToString().Equals("GPU Core"))
                {
                    if (gpu_selected == 1)
                    {
                        GPU1Temp.AppendText(result);
                    }
                    else if (gpu_selected == -1)
                    {
                        GPU2Temp.AppendText(result);
                    }
                    average += Convert.ToDouble(result) / 3;
                    weighted_average += Convert.ToDouble(result) * (gpu_weight / (cpu_weight + 2 * gpu_weight));
                    gpu_selected *= -1;

                }
                else
                {
                    CoreTemps.AppendText(result + "\t");
                }
            }
            current_temp = weighted == 1 ? weighted_average : average;
            set_fan_speed();
            AvgTemp.AppendText(Convert.ToString(Convert.ToInt32(current_temp)));
            SpeedVal.AppendText(Convert.ToString(fan_speed));
            RPMVal.AppendText(rpm);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Weighted average checkbox ticked/unticked
        {
            if (input)
            {
                weighted *= -1;
                save_settings("checkboxes.txt");
            }
        }

       
        //Functions related to fan curve
        public void draw(PaintEventArgs e, string item, int red, int green, int blue, int x_1, int y_1, int x_2, int y_2, int r)
        {
            Pen pen = new Pen(Color.FromArgb(red, green, blue));
            SolidBrush brush = new SolidBrush(Color.FromArgb(red, green, blue));
            switch (item)
            {
                case "rectangle":
                    e.Graphics.FillRectangle(brush, x_1, y_1, x_2, y_2);
                    break;
                case "circle":
                    e.Graphics.FillEllipse(brush, x_1-r, y_1-r, 2*r, 2*r);
                    break;
                case "line":
                    e.Graphics.DrawLine(pen, x_1, y_1, x_2, y_2);
                    break;
            }
            pen.Dispose();
            brush.Dispose();
        }

        private void SystemController_MouseClick(object sender, MouseEventArgs e) //Adding points for fan curve
        {
            if (curve_locked == -1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (e.X >= x_offset && e.X <= (x_size + x_offset) && e.Y >= 0 && e.Y <= (y_size) && !x_coordinates.Contains(e.X))
                    {
                        valid = false;
                        x_pos = e.X;
                        y_pos = e.Y;
                        x_coordinates.Add(x_pos);
                        x_coordinates.Sort();
                        y_coordinates.Insert(x_coordinates.IndexOf(x_pos), y_pos);
                        if (x_coordinates.Count == 1)
                        {
                            valid = true;
                        }
                        else
                        {
                            if (x_coordinates.IndexOf(x_pos) != 0 && x_coordinates.IndexOf(x_pos) != x_coordinates.Count - 1)
                            {
                                if (y_coordinates[x_coordinates.IndexOf(x_pos) - 1] >= y_pos && y_coordinates[x_coordinates.IndexOf(x_pos) + 1] <= y_pos)
                                {
                                    valid = true;
                                }
                            }
                            if (x_coordinates.IndexOf(x_pos) == 0)
                            {
                                if (y_coordinates[x_coordinates.IndexOf(x_pos) + 1] <= y_pos)
                                {
                                    valid = true;
                                }
                            }
                            if (x_coordinates.IndexOf(x_pos) == x_coordinates.Count - 1)
                            {
                                if (y_coordinates[x_coordinates.IndexOf(x_pos) - 1] >= y_pos)
                                {
                                    valid = true;
                                }
                            }
                        }
                        if (!valid)
                        {
                            y_coordinates.RemoveAt(x_coordinates.IndexOf(x_pos));
                            x_coordinates.Remove(x_pos);
                        }
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    for (int i = x_coordinates.Count-1; i >= 0; i--)
                    {
                        if ((x_coordinates[i] == e.X || x_coordinates[i] == e.X + 1 || x_coordinates[i] == e.X - 1) && (y_coordinates[i] == e.Y || y_coordinates[i] == e.Y + 1 || y_coordinates[i] == e.Y - 1))
                        {
                            x_coordinates.Remove(x_coordinates[i]);
                            y_coordinates.Remove(y_coordinates[i]);
                        }
                    }
                }
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e) //Timer that handles drawing
        {
            Graph.Paint += new System.Windows.Forms.PaintEventHandler(this.Graph_Paint);
            led_previewer();
            this.Refresh();
        }

        private void Graph_Paint(object sender, PaintEventArgs e) //Drawing points and lines of fan curve
        {
            Graphics g = e.Graphics;
            foreach (int x in x_coordinates)
            {
                draw(e, "circle", 255, 0, 0, x, y_coordinates[x_coordinates.IndexOf(x)], 0, 0, 2);
            }
            if (x_coordinates.Count >= 2)
            {
                foreach (int x in x_coordinates)
                {
                    if (x_coordinates.IndexOf(x) != x_coordinates.Count - 1)
                    {
                        draw(e, "line", 255, 0, 0, x, y_coordinates[x_coordinates.IndexOf(x)], x_coordinates[x_coordinates.IndexOf(x) + 1], y_coordinates[x_coordinates.IndexOf(x) + 1], 0);
                    }

                }
            }

            foreach (int x in x_coordinates_final)
            {
                draw(e, "circle", 0, 255, 0, x, y_coordinates_final[x_coordinates_final.IndexOf(x)], 0, 0, 2);
            }
            if (x_coordinates_final.Count >= 2)
            {
                foreach (int x in x_coordinates_final)
                {
                    if (x_coordinates_final.IndexOf(x) != x_coordinates_final.Count-1)
                    {
                        draw(e, "line", 0, 255, 0, x, y_coordinates_final[x_coordinates_final.IndexOf(x)], x_coordinates_final[x_coordinates_final.IndexOf(x) + 1], y_coordinates_final[x_coordinates_final.IndexOf(x) + 1], 0);
                    }

                }
            }
            if (x_coordinates_final.Count != 0) {
                if (x_coordinates_final[0] != 22)
                {
                    draw(e, "line", 0, 255, 0, x_coordinates_final[0], y_coordinates_final[0], 22, y_coordinates_final[0], 0);
                }
                if (x_coordinates_final[x_coordinates_final.Count-1] != 442)
                {
                    draw(e, "line", 0, 255, 0, x_coordinates_final[x_coordinates_final.Count - 1], y_coordinates_final[x_coordinates_final.Count - 1], 442, y_coordinates_final[x_coordinates_final.Count - 1], 0);
                }
            }
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) //Lock/unlock fan curve editing
        {
            if (input)
            {
                Cancel_Click(sender, e);
                curve_locked *= -1;
                save_settings("checkboxes.txt");
            }  
        }

        private void Apply_Click(object sender, EventArgs e) //Apply fan curve settings
        {
            StreamWriter writer = new StreamWriter("curve.txt", false);
            x_coordinates_final.Clear();
            y_coordinates_final.Clear();
            foreach (int x in x_coordinates)
            {
                x_coordinates_final.Add(x);
                writer.WriteLine(Convert.ToString(x));
            }
            writer.WriteLine();
            foreach (int y in y_coordinates)
            {
                y_coordinates_final.Add(y);
                writer.WriteLine(Convert.ToString(y));
            }
            writer.WriteLine();
            x_coordinates.Clear();
            y_coordinates.Clear();
            writer.Close();
        }

        private void Cancel_Click(object sender, EventArgs e) //Cancel fan curve settings
        {
            x_coordinates.Clear();
            y_coordinates.Clear();
        }

        private void Reset_Click(object sender, EventArgs e) //Reset fan curve settings
        {
            StreamWriter writer = new StreamWriter("curve.txt", false);
            x_coordinates_final.Clear();
            y_coordinates_final.Clear();
            writer.WriteLine(Convert.ToString(x_offset));
            writer.WriteLine(Convert.ToString(x_offset+x_size));
            writer.WriteLine();
            writer.WriteLine(Convert.ToString(y_size));
            writer.WriteLine("0");
            writer.WriteLine();
            writer.Close();
            update_curve();
        }

        public void set_fan_speed() //Compute fan speed based on curve
        {
            if (x_coordinates_final.Count == 1)
            {
                fan_speed = (int)((y_size-y_coordinates_final[0])/(y_size/100.0));
            }
            else if (x_coordinates_final.Count != 0)
            {
                int min_val = 0;
                for (int i = x_coordinates_final.Count - 1; i >= 0; i--)
                {
                    if (x_coordinates_final[i] < current_temp*(x_size/100.0)+x_offset)
                    {
                        min_val = i;
                        break;
                    }
                    if (i == 0)
                    {
                        min_val = i - 1;
                    }
                }
                if (min_val == -1)
                {
                    fan_speed = (int)((y_size-y_coordinates_final[0])/(y_size/100.0));
                }
                else if (min_val == x_coordinates_final.Count-1)
                {
                    fan_speed = (int)((y_size-y_coordinates_final[x_coordinates_final.Count-1])/(y_size/100.0));
                }
                else
                {
                    double y = (y_size-y_coordinates_final[min_val])/(y_size/100.0);
                    double dy = (y_size-y_coordinates_final[min_val+1])/(y_size/100.0)-(y_size-y_coordinates_final[min_val])/(y_size/100.0);
                    double dx = (x_offset+x_coordinates_final[min_val+1])/(x_size/100.0)-(x_offset+x_coordinates_final[min_val])/(x_size/100.0);
                    double deltax = current_temp - ((x_coordinates_final[min_val]-x_offset) / (x_size / 100.0));
                    fan_speed = (int)(y + dy / dx * deltax);
                }
            } 
        }


        //Functions related to LED control
        private void Interval_KeyDown(object sender, KeyEventArgs e) //Changing LED interval
        {
            if (e.KeyCode == Keys.Enter && led_locked == -1)
            {
                e.SuppressKeyPress = true;
                try
                {
                    interval = Convert.ToInt32(Interval.Text);
                    if (mode == 1)
                    {
                        if (interval > 2000)
                        {
                            interval = 2000;
                            Interval.Clear();
                            Interval.AppendText("2000");
                        }
                        else if (interval < 25)
                        {
                            interval = 25;
                            Interval.Clear();
                            Interval.AppendText("25");
                        }
                    }
                    else if (mode == 3)
                    {
                        if (interval > 15000)
                        {
                            interval = 15000;
                            Interval.Clear();
                            Interval.AppendText("15000");
                        }
                        else if (interval < 75)
                        {
                            interval = 75;
                            Interval.Clear();
                            Interval.AppendText("75");
                        }
                    }
                    save_settings("led.txt");
                }
                catch (Exception f)
                {
                    Interval.Clear();
                }
            }
        }

        private void Interval_MouseDown(object sender, MouseEventArgs e) //Clearing LED interval
        {
            if (e.Button == MouseButtons.Left && led_locked == -1)
            {
                Interval.Clear();
            }
        }

        private void B_KeyDown(object sender, KeyEventArgs e) //Changing blue LED
        {
            if (e.KeyCode == Keys.Enter && led_locked == -1 && auto_rgb == -1)
            {
                e.SuppressKeyPress = true;
                try
                {  
                    b = Convert.ToInt32(B.Text);
                    if (b < 0)
                    {
                        b = 0;
                        B.Clear();
                        B.AppendText("0");
                    }
                    else if (b > 255)
                    {
                        b = 255;
                        B.Clear();
                        B.AppendText("255");
                    }
                    save_settings("led.txt");
                }
                catch (Exception f)
                {
                    B.Clear();
                }
            }
        }

        private void G_KeyDown(object sender, KeyEventArgs e) //Changing green LED
        {
            if (e.KeyCode == Keys.Enter && led_locked == -1 && auto_rgb == -1)
            {
                e.SuppressKeyPress = true;
                try
                {
                    g = Convert.ToInt32(G.Text);
                    if (g < 0)
                    {
                        g = 0;
                        G.Clear();
                        G.AppendText("0");
                    }
                    else if (g > 255)
                    {
                        g = 255;
                        G.Clear();
                        G.AppendText("255");
                    }
                    save_settings("led.txt");
                }
                catch (Exception f)
                {
                    G.Clear();
                }
            }
        }

        private void R_KeyDown(object sender, KeyEventArgs e) //Changing red LED
        {
            if (e.KeyCode == Keys.Enter && led_locked == -1 && auto_rgb == -1)
            {
                e.SuppressKeyPress = true;
                try
                {
                    r = Convert.ToInt32(R.Text);
                    if (r < 0)
                    {
                        r = 0;
                        R.Clear();
                        R.AppendText("0");
                    }
                    else if (r > 255)
                    {
                        r = 255;
                        R.Clear();
                        R.AppendText("255");
                    }
                    save_settings("led.txt");
                }
                catch (Exception f)
                {
                    R.Clear();
                }
            }
        }

        private void R_MouseDown(object sender, MouseEventArgs e) //Clearing red LED
        {
            if (e.Button == MouseButtons.Left && led_locked == -1 && auto_rgb == -1)
            {
                R.Clear();
            }
        }

        private void G_MouseDown(object sender, MouseEventArgs e) //Clearing green LED
        {
            if (e.Button == MouseButtons.Left && led_locked == -1 && auto_rgb == -1)
            {
                G.Clear();
            }
        }

        private void B_MouseDown(object sender, MouseEventArgs e) //Clearing blue LED
        {
            if (e.Button == MouseButtons.Left && led_locked == -1 && auto_rgb == -1)
            {
                B.Clear();
            }
        }

        private void timer3_Tick(object sender, EventArgs e) //Updating LED timer preview
        {
            if (mode == 1)
            {
                if (!on)
                {
                    PreviewInterval.BackColor = Color.FromArgb(255, 0, 0);
                    on = true;
                    timer5.Interval = 1;
                }
                else if (on)
                {
                    PreviewInterval.BackColor = Color.FromArgb(0, 0, 0);
                    on = false;
                }
            }
            else if (mode == 2 || mode == 4)
            {
                if (!on)
                {
                    PreviewInterval.BackColor = Color.FromArgb(255, 0, 0);
                    on = true;
                    timer5.Interval = 1;
                }
                else if (on)
                {
                    PreviewInterval.BackColor = Color.FromArgb(0, 0, 0);
                    on = false;
                }
                random_flash = true;
            }
            else if (mode == 3)
            {
                if ((fade == 255 && fade_in == 1) || (fade == 0 && fade_in == -1))
                {
                    if (fade == 0 && fade_in == -1)
                    {
                        timer5.Interval = 1;
                    }
                    fade_in *= -1;
                }
                fade += fade_in * 17;
                PreviewInterval.BackColor = Color.FromArgb(fade, 0, 0);
                
            }
            this.Refresh();
        }

        private void timer5_Tick(object sender, EventArgs e) //Updating LED RGB preview
        {
            timer5.Interval = 10000;
            if (auto_rgb == 1)
            {
                if (rgb_mode == 1)
                {
                    r = (int)(8.5 * (current_temp - 15));
                    g = (int)(255 - 8.5 * (current_temp - 45));
                    b = 0;
                    if (r > 255)
                    {
                        r = 255;
                    }
                    else if (r < 0)
                    {
                        r = 0;
                    }
                    if (g > 255)
                    {
                        g = 255;
                    }
                    else if (g < 0)
                    {
                        g = 0;
                    }
                }
                else if (rgb_mode == 2)
                {
                    r = rand.Next(0, 256);
                    g = rand.Next(0, 256);
                    b = rand.Next(0, 256);
                }
                R.Clear();
                G.Clear();
                B.Clear();
                R.AppendText(Convert.ToString(r));
                G.AppendText(Convert.ToString(g));
                B.AppendText(Convert.ToString(b));
                PreviewRGB.BackColor = Color.FromArgb(r, g, b);
            }
        }

        private void LEDPreviewSelect_CheckedChanged(object sender, EventArgs e) //Enable/disable LED preview
        {
            if (input)
            {
                led_preview *= -1;
                save_settings("checkboxes.txt");
            } 
        }

        private void LockLEDSelect_CheckedChanged(object sender, EventArgs e) //Lock/unlock LED setting editing
        {
            if (input)
            {
                led_locked *= -1;
                update_override();
                save_settings("checkboxes.txt");
                if (led_locked == 1)
                {
                    na.Enabled = false;
                    fl.Enabled = false;
                    rf.Enabled = false;
                    fd.Enabled = false;
                    tmp.Enabled = false;
                    Override.Enabled = false;
                    RGBTemp.Enabled = false;
                    RGBRandom.Enabled = false;
                }
                else if (led_locked == -1)
                {
                    na.Enabled = true;
                    fl.Enabled = true;
                    rf.Enabled = true;
                    fd.Enabled = true;
                    tmp.Enabled = true;
                    Override.Enabled = true;
                    RGBTemp.Enabled = true;
                    RGBRandom.Enabled = true;
                }
            }
        }

        private void Override_CheckedChanged(object sender, EventArgs e) //Lock/unlock RGB override
        {
            if (input)
            {
                auto_rgb *= -1;
                if (auto_rgb == -1)
                {
                    rgb_mode = 0;
                }
                update_override();
                save_settings("led.txt");
            }
        }

        private void RGBTemp_CheckedChanged(object sender, EventArgs e) //Set RGB override to be controlled by temperature
        {
            if (input)
            {
                rgb_mode = 1;
                save_settings("led.txt");
            }
        }

        private void RGBRandom_CheckedChanged(object sender, EventArgs e) //Set RGB override to be controlled by random
        {
            if (input)
            {
                rgb_mode = 2;
                save_settings("led.txt");
            }
        }

        public void update_override() //Update status of RGB override buttons
        {
            input = false;
            if (rgb_mode == 0)
            {
                RGBTemp.Checked = false;
                RGBRandom.Checked = false;
            }
            else if (rgb_mode == 1)
            {
                RGBTemp.Checked = true;
                RGBRandom.Checked = false;
            }
            else if (rgb_mode == 2)
            {
                RGBTemp.Checked = false;
                RGBRandom.Checked = true;
            }
            if (auto_rgb == -1)
            {
                RGBTemp.Enabled = false;
                RGBRandom.Enabled = false;
            }
            else if (auto_rgb == 1)
            {
                RGBTemp.Enabled = true;
                RGBRandom.Enabled = true;
            }
            input = true;
        }

        public void led_previewer() //Controls everything that has to do with LED preview
        {
            if (led_preview == -1)
            {
                PreviewRGB.BackColor = Color.FromArgb(0, 0, 0);
                PreviewInterval.BackColor = Color.FromArgb(0, 0, 0);
                timer3.Enabled = false;
                timer5.Enabled = false;
            }
            else if (led_preview == 1)
            {
                timer5.Enabled = true;
                PreviewRGB.BackColor = Color.FromArgb(r, g, b);
                if (mode == 0)
                {
                    timer5.Interval = 1000;
                    PreviewInterval.BackColor = Color.FromArgb(255, 0, 0);
                }
                else if (mode == 1)
                {
                    timer3.Enabled = true;
                    timer3.Interval = interval;
                }
                else if (mode == 2)
                {
                    timer3.Enabled = true;
                    if (random_flash)
                    {
                        timer3.Interval = rand.Next(50, 500);
                        random_flash = false;
                    }
                }
                else if (mode == 3)
                {
                    timer3.Enabled = true;
                    timer3.Interval = interval / 15;
                }
                else if (mode == 4)
                {
                    timer3.Enabled = true;
                    if (random_flash)
                    {
                        interval = (125 - (int)current_temp) * 5;
                        timer3.Interval = interval;
                        random_flash = false;
                    }
                }
            }
        }

        #region bullet_list //Functions for changing mode based on bullet list
        private void na_CheckedChanged(object sender, EventArgs e)
        {
            if (input)
            {
                mode = 0;
                save_settings("led.txt");
            }
        }
        private void fl_CheckedChanged(object sender, EventArgs e)
        {
            if (input)
            {
                mode = 1;
                save_settings("led.txt");
            }
        }
        private void rf_CheckedChanged(object sender, EventArgs e)
        {
            if (input)
            {
                mode = 2;
                save_settings("led.txt");
            }
        }
        private void fd_CheckedChanged(object sender, EventArgs e)
        {
            if (input)
            {
                mode = 3;
                save_settings("led.txt");
            }
        }
        private void tmp_CheckedChanged(object sender, EventArgs e)
        {
            if (input)
            {
                mode = 4;
                save_settings("led.txt");
            }
        }
        #endregion


        //Other functions

        private void timer4_Tick(object sender, EventArgs e) //Function for serial communication
        {
            if (first)
            {
                for (int i = 0; i < average_period; i++)
                {
                    fan_speed_temp[i] = fan_speed;
                }
                first = false;
            }
            else
            {
                for (int i = 0; i < average_period - 1; i++)
                {
                    fan_speed_temp[i] = fan_speed_temp[i + 1];
                }
                fan_speed_temp[average_period - 1] = fan_speed;
            }
            fan_speed_averaged = 0;
            for (int i = 0; i < average_period; i++)
            {
                fan_speed_averaged += fan_speed_temp[i];
            }
            fan_speed_averaged /= average_period;
            port.Write("\n" + fan_speed_averaged + " " + mode + " " + r + " " + g + " " + b + " " + interval);
            if (port.BytesToRead > 0)
            {
                rpm = port.ReadLine();
                port.DiscardInBuffer();
            }
            if (fan_speed_averaged < 5)
            {
                rpm = "0";
            }
        }

        public void save_settings(string file) //To save changes to file whenever required
        {
            if (file == "checkboxes.txt")
            {
                StreamWriter writer = new StreamWriter("checkboxes.txt", false);
                writer.WriteLine(Convert.ToString(weighted));
                writer.WriteLine(Convert.ToString(curve_locked));
                writer.WriteLine(Convert.ToString(led_locked));
                writer.WriteLine(Convert.ToString(led_preview));
                writer.Close();
            }
            else if (file == "led.txt")
            {
                StreamWriter writer = new StreamWriter("led.txt", false);
                writer.WriteLine(Convert.ToString(mode));
                writer.WriteLine(Convert.ToString(auto_rgb));
                writer.WriteLine(Convert.ToString(rgb_mode));
                writer.WriteLine(Convert.ToString(r));
                writer.WriteLine(Convert.ToString(g));
                writer.WriteLine(Convert.ToString(b));
                writer.WriteLine(Convert.ToString(interval));
                writer.Close();
            }
        }


        #region prevent_select //Functions for preventing the selection of text in some textboxes
        private void Temps_MouseDown(object sender, MouseEventArgs e)
        {
            Temps.Enabled = false;
            Temps.Enabled = true;
        }

        private void CPU_MouseDown(object sender, MouseEventArgs e)
        {
            CPU.Enabled = false;
            CPU.Enabled = true;
        }

        private void GPU1_MouseDown(object sender, MouseEventArgs e)
        {
            GPU1.Enabled = false;
            GPU1.Enabled = true;
        }

        private void GPU2_MouseDown(object sender, MouseEventArgs e)
        {
            GPU2.Enabled = false;
            GPU2.Enabled = true;
        }

        private void Average_MouseDown(object sender, MouseEventArgs e)
        {
            Average.Enabled = false;
            Average.Enabled = true;
        }

        private void Cores_MouseDown(object sender, MouseEventArgs e)
        {
            Cores.Enabled = false;
            Cores.Enabled = true;
        }

        private void Fans_MouseDown(object sender, MouseEventArgs e)
        {
            Fans.Enabled = false;
            Fans.Enabled = true;
        }

        private void Speed_MouseDown(object sender, MouseEventArgs e)
        {
            Speed.Enabled = false;
            Speed.Enabled = true;
        }

        private void RPM_MouseDown(object sender, MouseEventArgs e)
        {
            RPM.Enabled = false;
            RPM.Enabled = true;
        }

        private void Leds_MouseDown(object sender, MouseEventArgs e)
        {
            Leds.Enabled = false;
            Leds.Enabled = true;
        }

        private void Timing_MouseDown(object sender, MouseEventArgs e)
        {
            Timing.Enabled = false;
            Timing.Enabled = true;
        }

        private void RGB_MouseDown(object sender, MouseEventArgs e)
        {
            RGB.Enabled = false;
            RGB.Enabled = true;
        }

        private void Weighted_MouseDown(object sender, MouseEventArgs e)
        {
            Weighted.Enabled = false;
            Weighted.Enabled = true;
        }

        private void LockFan_MouseDown(object sender, MouseEventArgs e)
        {
            LockFan.Enabled = false;
            LockFan.Enabled = true;
        }

        private void Preview_MouseDown(object sender, MouseEventArgs e)
        {
            Preview.Enabled = false;
            Preview.Enabled = true;
        }

        private void LockLed_MouseDown(object sender, MouseEventArgs e)
        {
            LockLed.Enabled = false;
            LockLed.Enabled = true;
        }

        private void PreviewInterval_MouseDown(object sender, MouseEventArgs e)
        {
            PreviewInterval.Enabled = false;
            PreviewInterval.Enabled = true;
        }

        private void PreviewRGB_MouseDown(object sender, MouseEventArgs e)
        {
            PreviewRGB.Enabled = false;
            PreviewRGB.Enabled = true;
        }
        #endregion

        #region minimize_exit //Functions to handle minimizing to tray and exiting
        private void SystemController_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        protected override CreateParams CreateParams //Stop flickering
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
