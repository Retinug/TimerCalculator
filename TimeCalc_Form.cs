using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimerCalculator
{
    public partial class TimCalc_Form : Form
    {
        uint clockFreq;
        uint prescaler;
        ulong resolution;

        public TimCalc_Form()
        {
            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void button_TimerTick_Click(object sender, EventArgs e)
        {
            GetData();
            CheckData(textBox_TimerTick, 1);
            ulong ticks = ulong.Parse(textBox_TimerTick.Text);
            double sec = Calc.GetRealTime(clockFreq, ticks, prescaler);
            textBox_RealTime.Text = Convert.ToDecimal(sec).ToString() ;

            textBox_OverCount.Text = Convert.ToDecimal(Calc.GetOverflow(clockFreq, resolution, prescaler, sec)).ToString();
            textBox_Remain.Text = Convert.ToDecimal(Calc.GetRemainTicks(clockFreq, resolution, prescaler, sec)).ToString();

            textBox_Freq.Text = Convert.ToDecimal(Calc.GetFreq(sec)).ToString();
        }

        private void button_OverRemain_Click(object sender, EventArgs e)
        {
            GetData();
            CheckData(textBox_OverCount, 1);
            CheckData(textBox_Remain, 0);
            uint over = uint.Parse(textBox_OverCount.Text);
            uint remain = uint.Parse(textBox_Remain.Text);

            ulong ticks = Calc.GetTimeTicks(over, remain, resolution);
            double sec = Calc.GetRealTime(clockFreq, ticks, prescaler);
            textBox_TimerTick.Text = ticks.ToString();
            textBox_RealTime.Text  = Convert.ToDecimal(sec).ToString();
            textBox_Freq.Text = Convert.ToDecimal(Calc.GetFreq(sec)).ToString();
        }

        private void button_RealTime_Click(object sender, EventArgs e)
        {
            GetData();
            CheckData(textBox_RealTime, 1);
            double sec = double.Parse(textBox_RealTime.Text);
            
            textBox_TimerTick.Text = Convert.ToDecimal(Calc.GetTimeTicks(clockFreq, prescaler, sec)).ToString();

            textBox_OverCount.Text = Convert.ToDecimal(Calc.GetOverflow(clockFreq, resolution, prescaler, sec)).ToString();
            textBox_Remain.Text = Convert.ToDecimal(Calc.GetRemainTicks(clockFreq, resolution, prescaler, sec)).ToString();

            textBox_Freq.Text = Convert.ToDecimal(Calc.GetFreq(sec)).ToString();
        }

        private void button_Freq_Click(object sender, EventArgs e)
        {
            GetData();
            CheckData(textBox_Freq, 1);
            double freq = double.Parse(textBox_Freq.Text);
            uint ticks = Calc.GetTimeTicksFreq(clockFreq, prescaler, freq);
            textBox_TimerTick.Text = Convert.ToDecimal(ticks).ToString();

            double sec = Calc.GetRealTime(clockFreq, ticks, prescaler);

            textBox_OverCount.Text = Convert.ToDecimal(Calc.GetOverflow(clockFreq, resolution, prescaler, sec)).ToString();
            textBox_Remain.Text = Convert.ToDecimal(Calc.GetRemainTicks(clockFreq, resolution, prescaler, sec)).ToString();

            textBox_RealTime.Text = Convert.ToDecimal(sec).ToString();
        }

        private void GetData()
        {
            CheckData(textBox_ClockFreq, 8000000);
            CheckData(textBox_Pres, 1);

            clockFreq = uint.Parse(textBox_ClockFreq.Text);
            prescaler = uint.Parse(textBox_Pres.Text);
            resolution = CountRes();
        }

        private void CheckData(TextBox textBox, uint value)
        {
            if (textBox.Text == string.Empty || textBox.Text == 0.ToString())
            {
                textBox.Text = value.ToString();
            }
        }

        private ulong CountRes()
        {
            ulong res = 0;
            switch (comboBox_CountRes.SelectedIndex)
            {
                case 0:
                    res = (ulong)Math.Pow(2, 8);
                    break;
                case 1:
                    res = (ulong)Math.Pow(2, 16);
                    break;
                case 2:
                    res = (ulong)Math.Pow(2, 32);
                    break;
            }
            return res;
        }
    }
}
