
namespace TimerCalculator
{
    partial class TimCalc_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ClockFreq = new System.Windows.Forms.Label();
            this.textBox_ClockFreq = new System.Windows.Forms.TextBox();
            this.label_CountRes = new System.Windows.Forms.Label();
            this.label_Pres = new System.Windows.Forms.Label();
            this.label_TimerTick = new System.Windows.Forms.Label();
            this.label_OverCount = new System.Windows.Forms.Label();
            this.label_RealTime = new System.Windows.Forms.Label();
            this.textBox_Pres = new System.Windows.Forms.TextBox();
            this.textBox_TimerTick = new System.Windows.Forms.TextBox();
            this.textBox_OverCount = new System.Windows.Forms.TextBox();
            this.textBox_RealTime = new System.Windows.Forms.TextBox();
            this.label_Freq = new System.Windows.Forms.Label();
            this.textBox_Freq = new System.Windows.Forms.TextBox();
            this.comboBox_CountRes = new System.Windows.Forms.ComboBox();
            this.button_TimerTick = new System.Windows.Forms.Button();
            this.button_OverRemain = new System.Windows.Forms.Button();
            this.button_RealTime = new System.Windows.Forms.Button();
            this.button_Freq = new System.Windows.Forms.Button();
            this.textBox_Remain = new System.Windows.Forms.TextBox();
            this.label_Remain = new System.Windows.Forms.Label();
            this.groupBox_MainPar = new System.Windows.Forms.GroupBox();
            this.groupBox_MainPar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ClockFreq
            // 
            this.label_ClockFreq.AutoSize = true;
            this.label_ClockFreq.Location = new System.Drawing.Point(6, 16);
            this.label_ClockFreq.Name = "label_ClockFreq";
            this.label_ClockFreq.Size = new System.Drawing.Size(109, 13);
            this.label_ClockFreq.TabIndex = 1;
            this.label_ClockFreq.Text = "Clock frequency (Hz):";
            // 
            // textBox_ClockFreq
            // 
            this.textBox_ClockFreq.Location = new System.Drawing.Point(118, 13);
            this.textBox_ClockFreq.Name = "textBox_ClockFreq";
            this.textBox_ClockFreq.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClockFreq.TabIndex = 2;
            this.textBox_ClockFreq.Text = "8000000";
            // 
            // label_CountRes
            // 
            this.label_CountRes.AutoSize = true;
            this.label_CountRes.Location = new System.Drawing.Point(6, 44);
            this.label_CountRes.Name = "label_CountRes";
            this.label_CountRes.Size = new System.Drawing.Size(95, 13);
            this.label_CountRes.TabIndex = 3;
            this.label_CountRes.Text = "Counter resolution:";
            // 
            // label_Pres
            // 
            this.label_Pres.AutoSize = true;
            this.label_Pres.Location = new System.Drawing.Point(6, 74);
            this.label_Pres.Name = "label_Pres";
            this.label_Pres.Size = new System.Drawing.Size(54, 13);
            this.label_Pres.TabIndex = 4;
            this.label_Pres.Text = "Prescaler:";
            // 
            // label_TimerTick
            // 
            this.label_TimerTick.AutoSize = true;
            this.label_TimerTick.Location = new System.Drawing.Point(18, 121);
            this.label_TimerTick.Name = "label_TimerTick";
            this.label_TimerTick.Size = new System.Drawing.Size(61, 13);
            this.label_TimerTick.TabIndex = 5;
            this.label_TimerTick.Text = "Timer ticks:";
            // 
            // label_OverCount
            // 
            this.label_OverCount.AutoSize = true;
            this.label_OverCount.Location = new System.Drawing.Point(18, 147);
            this.label_OverCount.Name = "label_OverCount";
            this.label_OverCount.Size = new System.Drawing.Size(90, 13);
            this.label_OverCount.TabIndex = 6;
            this.label_OverCount.Text = "Overwflow count:";
            // 
            // label_RealTime
            // 
            this.label_RealTime.AutoSize = true;
            this.label_RealTime.Location = new System.Drawing.Point(18, 199);
            this.label_RealTime.Name = "label_RealTime";
            this.label_RealTime.Size = new System.Drawing.Size(80, 13);
            this.label_RealTime.TabIndex = 7;
            this.label_RealTime.Text = "Real time (sec):";
            // 
            // textBox_Pres
            // 
            this.textBox_Pres.Location = new System.Drawing.Point(118, 71);
            this.textBox_Pres.Name = "textBox_Pres";
            this.textBox_Pres.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pres.TabIndex = 9;
            this.textBox_Pres.Text = "1";
            // 
            // textBox_TimerTick
            // 
            this.textBox_TimerTick.Location = new System.Drawing.Point(130, 118);
            this.textBox_TimerTick.Name = "textBox_TimerTick";
            this.textBox_TimerTick.Size = new System.Drawing.Size(100, 20);
            this.textBox_TimerTick.TabIndex = 10;
            // 
            // textBox_OverCount
            // 
            this.textBox_OverCount.Location = new System.Drawing.Point(130, 144);
            this.textBox_OverCount.Name = "textBox_OverCount";
            this.textBox_OverCount.Size = new System.Drawing.Size(100, 20);
            this.textBox_OverCount.TabIndex = 11;
            // 
            // textBox_RealTime
            // 
            this.textBox_RealTime.Location = new System.Drawing.Point(130, 196);
            this.textBox_RealTime.Name = "textBox_RealTime";
            this.textBox_RealTime.Size = new System.Drawing.Size(100, 20);
            this.textBox_RealTime.TabIndex = 12;
            // 
            // label_Freq
            // 
            this.label_Freq.AutoSize = true;
            this.label_Freq.Location = new System.Drawing.Point(18, 225);
            this.label_Freq.Name = "label_Freq";
            this.label_Freq.Size = new System.Drawing.Size(82, 13);
            this.label_Freq.TabIndex = 14;
            this.label_Freq.Text = "Frequency (Hz):";
            // 
            // textBox_Freq
            // 
            this.textBox_Freq.Location = new System.Drawing.Point(130, 222);
            this.textBox_Freq.Name = "textBox_Freq";
            this.textBox_Freq.Size = new System.Drawing.Size(100, 20);
            this.textBox_Freq.TabIndex = 15;
            // 
            // comboBox_CountRes
            // 
            this.comboBox_CountRes.DisplayMember = "0";
            this.comboBox_CountRes.FormattingEnabled = true;
            this.comboBox_CountRes.Items.AddRange(new object[] {
            "8 bit",
            "16 bit",
            "32 bit"});
            this.comboBox_CountRes.Location = new System.Drawing.Point(118, 41);
            this.comboBox_CountRes.Name = "comboBox_CountRes";
            this.comboBox_CountRes.Size = new System.Drawing.Size(100, 21);
            this.comboBox_CountRes.TabIndex = 16;
            this.comboBox_CountRes.Text = "8 bit";
            // 
            // button_TimerTick
            // 
            this.button_TimerTick.Location = new System.Drawing.Point(21, 252);
            this.button_TimerTick.Name = "button_TimerTick";
            this.button_TimerTick.Size = new System.Drawing.Size(209, 23);
            this.button_TimerTick.TabIndex = 19;
            this.button_TimerTick.Text = "Use timer ticks";
            this.button_TimerTick.UseVisualStyleBackColor = true;
            this.button_TimerTick.Click += new System.EventHandler(this.button_TimerTick_Click);
            // 
            // button_OverRemain
            // 
            this.button_OverRemain.Location = new System.Drawing.Point(21, 281);
            this.button_OverRemain.Name = "button_OverRemain";
            this.button_OverRemain.Size = new System.Drawing.Size(209, 23);
            this.button_OverRemain.TabIndex = 20;
            this.button_OverRemain.Text = "Use overflow and remain";
            this.button_OverRemain.UseVisualStyleBackColor = true;
            this.button_OverRemain.Click += new System.EventHandler(this.button_OverRemain_Click);
            // 
            // button_RealTime
            // 
            this.button_RealTime.Location = new System.Drawing.Point(21, 310);
            this.button_RealTime.Name = "button_RealTime";
            this.button_RealTime.Size = new System.Drawing.Size(209, 23);
            this.button_RealTime.TabIndex = 21;
            this.button_RealTime.Text = "Use real time";
            this.button_RealTime.UseVisualStyleBackColor = true;
            this.button_RealTime.Click += new System.EventHandler(this.button_RealTime_Click);
            // 
            // button_Freq
            // 
            this.button_Freq.Location = new System.Drawing.Point(21, 339);
            this.button_Freq.Name = "button_Freq";
            this.button_Freq.Size = new System.Drawing.Size(209, 23);
            this.button_Freq.TabIndex = 22;
            this.button_Freq.Text = "Use frequency";
            this.button_Freq.UseVisualStyleBackColor = true;
            this.button_Freq.Click += new System.EventHandler(this.button_Freq_Click);
            // 
            // textBox_Remain
            // 
            this.textBox_Remain.Location = new System.Drawing.Point(130, 170);
            this.textBox_Remain.Name = "textBox_Remain";
            this.textBox_Remain.Size = new System.Drawing.Size(100, 20);
            this.textBox_Remain.TabIndex = 23;
            // 
            // label_Remain
            // 
            this.label_Remain.AutoSize = true;
            this.label_Remain.Location = new System.Drawing.Point(18, 173);
            this.label_Remain.Name = "label_Remain";
            this.label_Remain.Size = new System.Drawing.Size(86, 13);
            this.label_Remain.TabIndex = 24;
            this.label_Remain.Text = "Remainder ticks:";
            // 
            // groupBox_MainPar
            // 
            this.groupBox_MainPar.Controls.Add(this.label_ClockFreq);
            this.groupBox_MainPar.Controls.Add(this.textBox_ClockFreq);
            this.groupBox_MainPar.Controls.Add(this.label_CountRes);
            this.groupBox_MainPar.Controls.Add(this.comboBox_CountRes);
            this.groupBox_MainPar.Controls.Add(this.textBox_Pres);
            this.groupBox_MainPar.Controls.Add(this.label_Pres);
            this.groupBox_MainPar.Location = new System.Drawing.Point(12, 12);
            this.groupBox_MainPar.Name = "groupBox_MainPar";
            this.groupBox_MainPar.Size = new System.Drawing.Size(228, 100);
            this.groupBox_MainPar.TabIndex = 25;
            this.groupBox_MainPar.TabStop = false;
            this.groupBox_MainPar.Text = "Main parameters";
            // 
            // TimCalc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 371);
            this.Controls.Add(this.label_Remain);
            this.Controls.Add(this.textBox_Remain);
            this.Controls.Add(this.button_Freq);
            this.Controls.Add(this.button_RealTime);
            this.Controls.Add(this.button_OverRemain);
            this.Controls.Add(this.button_TimerTick);
            this.Controls.Add(this.textBox_Freq);
            this.Controls.Add(this.label_Freq);
            this.Controls.Add(this.textBox_RealTime);
            this.Controls.Add(this.textBox_OverCount);
            this.Controls.Add(this.textBox_TimerTick);
            this.Controls.Add(this.label_RealTime);
            this.Controls.Add(this.label_OverCount);
            this.Controls.Add(this.label_TimerTick);
            this.Controls.Add(this.groupBox_MainPar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TimCalc_Form";
            this.Text = "Calculator";
            this.groupBox_MainPar.ResumeLayout(false);
            this.groupBox_MainPar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ClockFreq;
        private System.Windows.Forms.TextBox textBox_ClockFreq;
        private System.Windows.Forms.Label label_CountRes;
        private System.Windows.Forms.Label label_Pres;
        private System.Windows.Forms.Label label_TimerTick;
        private System.Windows.Forms.Label label_OverCount;
        private System.Windows.Forms.Label label_RealTime;
        private System.Windows.Forms.TextBox textBox_Pres;
        private System.Windows.Forms.TextBox textBox_TimerTick;
        private System.Windows.Forms.TextBox textBox_OverCount;
        private System.Windows.Forms.TextBox textBox_RealTime;
        private System.Windows.Forms.Label label_Freq;
        private System.Windows.Forms.TextBox textBox_Freq;
        private System.Windows.Forms.ComboBox comboBox_CountRes;
        private System.Windows.Forms.Button button_TimerTick;
        private System.Windows.Forms.Button button_OverRemain;
        private System.Windows.Forms.Button button_RealTime;
        private System.Windows.Forms.Button button_Freq;
        private System.Windows.Forms.TextBox textBox_Remain;
        private System.Windows.Forms.Label label_Remain;
        private System.Windows.Forms.GroupBox groupBox_MainPar;
    }
}

