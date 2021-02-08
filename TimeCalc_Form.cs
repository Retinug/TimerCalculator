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
        public TimCalc_Form()
        {
            InitializeComponent();
        }

        private void TimCalc_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button_TimerTick_Click(object sender, EventArgs e)
        {

        }

        private void button_OverRemain_Click(object sender, EventArgs e)
        {

        }

        private void button_RealTime_Click(object sender, EventArgs e)
        {
            uint freq = uint.Parse(textBox_ClockFreq.Text);
            uint pres = uint.Parse(textBox_Pres.Text);
            uint sec = uint.Parse(textBox_RealTime.Text);
            UInt64 res = 0;
            textBox_TimerTick.Text = Calc.GetTimeTicks(freq, pres, sec).ToString();
            textBox_Freq.Text = Calc.GetFreq(sec).ToString();

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
            textBox_OverCount.Text = Calc.GetOverflow(freq, res).ToString();
            textBox_Remain.Text = Calc.GetRemainTicks(freq, res).ToString();
        }

        private void button_Freq_Click(object sender, EventArgs e)
        {
            
        }
    }
}
