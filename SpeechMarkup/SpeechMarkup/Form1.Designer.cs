using System;

namespace SpeechMarkup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntInterv = new System.Windows.Forms.Button();
            this.lblWeather = new System.Windows.Forms.Label();
            this.ddWeather = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddCondition = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AwareCondBox = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPID = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIncorrect5 = new System.Windows.Forms.Button();
            this.btnIncorrect4 = new System.Windows.Forms.Button();
            this.btnIncorrect3 = new System.Windows.Forms.Button();
            this.btnIncorrect2 = new System.Windows.Forms.Button();
            this.btnIncorrect = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntInterv
            // 
            this.bntInterv.Location = new System.Drawing.Point(6, 76);
            this.bntInterv.Name = "bntInterv";
            this.bntInterv.Size = new System.Drawing.Size(75, 23);
            this.bntInterv.TabIndex = 2;
            this.bntInterv.Text = "intervention";
            this.bntInterv.UseVisualStyleBackColor = true;
            this.bntInterv.Click += new System.EventHandler(this.btnInterv_Click);
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(6, 30);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(133, 13);
            this.lblWeather.TabIndex = 3;
            this.lblWeather.Text = "How is the weather today?";
            // 
            // ddWeather
            // 
            this.ddWeather.FormattingEnabled = true;
            this.ddWeather.Items.AddRange(new object[] {
            "Great",
            "Bad"});
            this.ddWeather.Location = new System.Drawing.Point(9, 49);
            this.ddWeather.Name = "ddWeather";
            this.ddWeather.Size = new System.Drawing.Size(121, 21);
            this.ddWeather.TabIndex = 4;
            this.ddWeather.SelectedIndexChanged += new System.EventHandler(this.ddWeather_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Experimental Condition";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ddCondition
            // 
            this.ddCondition.FormattingEnabled = true;
            this.ddCondition.Items.AddRange(new object[] {
            "Simple",
            "Metaphorical"});
            this.ddCondition.Location = new System.Drawing.Point(159, 49);
            this.ddCondition.Name = "ddCondition";
            this.ddCondition.Size = new System.Drawing.Size(121, 21);
            this.ddCondition.TabIndex = 6;
            this.ddCondition.SelectedIndexChanged += new System.EventHandler(this.ddCondition_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AwareCondBox);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lblPID);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.lblWeather);
            this.groupBox1.Controls.Add(this.ddWeather);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ddCondition);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 189);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-Experiment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aware Condition";
            // 
            // AwareCondBox
            // 
            this.AwareCondBox.FormattingEnabled = true;
            this.AwareCondBox.Items.AddRange(new object[] {
            "NotAware",
            "Aware"});
            this.AwareCondBox.Location = new System.Drawing.Point(159, 104);
            this.AwareCondBox.Name = "AwareCondBox";
            this.AwareCondBox.Size = new System.Drawing.Size(121, 21);
            this.AwareCondBox.TabIndex = 10;
            this.AwareCondBox.SelectedIndexChanged += new System.EventHandler(this.AwareCondBox_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(43, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Experiment";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(9, 93);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(28, 13);
            this.lblPID.TabIndex = 8;
            this.lblPID.Text = "PID:";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(43, 90);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(87, 20);
            this.txtPID.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIncorrect5);
            this.groupBox2.Controls.Add(this.btnIncorrect4);
            this.groupBox2.Controls.Add(this.btnIncorrect3);
            this.groupBox2.Controls.Add(this.btnIncorrect2);
            this.groupBox2.Controls.Add(this.btnIncorrect);
            this.groupBox2.Controls.Add(this.btnCorrect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bntInterv);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 227);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "During Experiment";
            // 
            // btnIncorrect5
            // 
            this.btnIncorrect5.Location = new System.Drawing.Point(149, 195);
            this.btnIncorrect5.Name = "btnIncorrect5";
            this.btnIncorrect5.Size = new System.Drawing.Size(125, 23);
            this.btnIncorrect5.TabIndex = 17;
            this.btnIncorrect5.UseVisualStyleBackColor = true;
            this.btnIncorrect5.Click += new System.EventHandler(this.btnIncorrect5_Click);
            // 
            // btnIncorrect4
            // 
            this.btnIncorrect4.Location = new System.Drawing.Point(149, 155);
            this.btnIncorrect4.Name = "btnIncorrect4";
            this.btnIncorrect4.Size = new System.Drawing.Size(125, 23);
            this.btnIncorrect4.TabIndex = 16;
            this.btnIncorrect4.UseVisualStyleBackColor = true;
            this.btnIncorrect4.Click += new System.EventHandler(this.btnIncorrect4_Click);
            // 
            // btnIncorrect3
            // 
            this.btnIncorrect3.Location = new System.Drawing.Point(149, 115);
            this.btnIncorrect3.Name = "btnIncorrect3";
            this.btnIncorrect3.Size = new System.Drawing.Size(125, 23);
            this.btnIncorrect3.TabIndex = 15;
            this.btnIncorrect3.UseVisualStyleBackColor = true;
            this.btnIncorrect3.Click += new System.EventHandler(this.btnIncorrect3_Click);
            // 
            // btnIncorrect2
            // 
            this.btnIncorrect2.Location = new System.Drawing.Point(149, 76);
            this.btnIncorrect2.Name = "btnIncorrect2";
            this.btnIncorrect2.Size = new System.Drawing.Size(125, 23);
            this.btnIncorrect2.TabIndex = 14;
            this.btnIncorrect2.UseVisualStyleBackColor = true;
            this.btnIncorrect2.Click += new System.EventHandler(this.btnIncorrect2_Click);
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.Location = new System.Drawing.Point(149, 37);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(125, 23);
            this.btnIncorrect.TabIndex = 13;
            this.btnIncorrect.UseVisualStyleBackColor = true;
            this.btnIncorrect.Click += new System.EventHandler(this.btnIncorrect_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(6, 37);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 12;
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Wizard Control Interface";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button bntInterv;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.ComboBox ddWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddCondition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnIncorrect;
        private System.Windows.Forms.Button btnIncorrect2;
        private System.Windows.Forms.Button btnIncorrect3;
        private System.Windows.Forms.Button btnIncorrect4;
        private System.Windows.Forms.Button btnIncorrect5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AwareCondBox;
    }
}