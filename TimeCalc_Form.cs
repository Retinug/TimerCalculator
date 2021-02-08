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
        uint pres;
        UInt64 res;

        public TimCalc_Form()
        {
            InitializeComponent();
        }

        private void TimCalc_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button_TimerTick_Click(object sender, EventArgs e)
        {
            GetData();
            uint ticks = uint.Parse(textBox_TimerTick.Text);
            uint freq = (uint)Calc.GetFreq(clockFreq, ticks);
            textBox_Freq.Text = Calc.GetFreq(clockFreq, ticks, pres).ToString();

            textBox_OverCount.Text = Calc.GetOverflowTicks(ticks, res).ToString();
            textBox_Remain.Text = Calc.GetRemainTicks(ticks, res).ToString();
            textBox_RealTime.Text = Calc.GetFreqPres(freq, pres).ToString();
        }

        private void button_OverRemain_Click(object sender, EventArgs e)
        {
            GetData();
            uint over = uint.Parse(textBox_OverCount.Text);
            uint remain = uint.Parse(textBox_Remain.Text);
            UInt64 ticks = Calc.GetTimeTicks(over, remain, res);
            uint freq = (uint)Calc.GetFreq(clockFreq, ticks);
            textBox_TimerTick.Text = ticks.ToString();

            //uint sec = 
            textBox_Freq.Text = freq.ToString();
            textBox_RealTime.Text = Calc.GetFreq(freq).ToString();
            //textBox_RealTime.Text = Calc.GetFreqPres(freq, pres).ToString();

        }

        private void button_RealTime_Click(object sender, EventArgs e)
        {
            GetData();
            uint sec = uint.Parse(textBox_RealTime.Text);
            UInt64 res = 0;
            textBox_TimerTick.Text = Calc.GetTimeTicks(clockFreq, pres, sec).ToString();
            textBox_Freq.Text = Calc.GetFreq(sec, pres).ToString();

            res = CountRes();
            textBox_OverCount.Text = Calc.GetOverflow(clockFreq, res).ToString();
            textBox_Remain.Text = Calc.GetRemainTicks(clockFreq, res).ToString();
        }

        private void button_Freq_Click(object sender, EventArgs e)
        {
            
        }

        private void GetData()
        {
            clockFreq = uint.Parse(textBox_ClockFreq.Text);
            pres = uint.Parse(textBox_Pres.Text);
            res = CountRes();
        }

        private UInt64 CountRes()
        {
            UInt64 res = 0;
            switch (comboBox_CountRes.SelectedIndex)
            {
                case 0:
                    res = (UInt64)Math.Pow(2, 8);
                    break;
                case 1:
                    res = (UInt64)Math.Pow(2, 16);
                    break;
                case 2:
                    res = (UInt64)Math.Pow(2, 32);
                    break;
            }
            return res;
        }
    }
}
