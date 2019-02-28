namespace wizardControl
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
            this.lblPID = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnInter = new System.Windows.Forms.Button();
            this.lblCont = new System.Windows.Forms.Label();
            this.ddCondition = new System.Windows.Forms.ComboBox();
            this.lblInc = new System.Windows.Forms.Label();
            this.ddCondition2 = new System.Windows.Forms.ComboBox();
            this.boxPre = new System.Windows.Forms.GroupBox();
            this.lblweather = new System.Windows.Forms.Label();
            this.ddWeather = new System.Windows.Forms.ComboBox();
            this.waterIntake = new System.Windows.Forms.ComboBox();
            this.lblWatIn = new System.Windows.Forms.Label();
            this.ddGlas = new System.Windows.Forms.ComboBox();
            this.lblGlas = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.boxPre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(24, 29);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(25, 13);
            this.lblPID.TabIndex = 2;
            this.lblPID.Text = "PID";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(70, 26);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(68, 20);
            this.txtPID.TabIndex = 3;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(27, 165);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(111, 23);
            this.btnSetup.TabIndex = 4;
            this.btnSetup.Text = "Start";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(12, 308);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(75, 23);
            this.btnInter.TabIndex = 5;
            this.btnInter.Text = "Intervention";
            this.btnInter.UseVisualStyleBackColor = true;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(213, 20);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(117, 26);
            this.lblCont.TabIndex = 7;
            this.lblCont.Text = "Experimental Condition:\r\n Awareness";
            // 
            // ddCondition
            // 
            this.ddCondition.FormattingEnabled = true;
            this.ddCondition.Items.AddRange(new object[] {
            "High",
            "Low"});
            this.ddCondition.Location = new System.Drawing.Point(216, 49);
            this.ddCondition.Name = "ddCondition";
            this.ddCondition.Size = new System.Drawing.Size(121, 21);
            this.ddCondition.TabIndex = 8;
            this.ddCondition.SelectedIndexChanged += new System.EventHandler(this.ddCondition_SelectedIndexChanged);
            // 
            // lblInc
            // 
            this.lblInc.AutoSize = true;
            this.lblInc.Location = new System.Drawing.Point(213, 86);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(117, 26);
            this.lblInc.TabIndex = 9;
            this.lblInc.Text = "Experimental Condition:\r\nIncrementality";
            // 
            // ddCondition2
            // 
            this.ddCondition2.FormattingEnabled = true;
            this.ddCondition2.Items.AddRange(new object[] {
            "Incremental",
            "Non-Incremental"});
            this.ddCondition2.Location = new System.Drawing.Point(216, 115);
            this.ddCondition2.Name = "ddCondition2";
            this.ddCondition2.Size = new System.Drawing.Size(121, 21);
            this.ddCondition2.TabIndex = 10;
            this.ddCondition2.SelectedIndexChanged += new System.EventHandler(this.ddCondition2_SelectedIndexChanged);
            // 
            // boxPre
            // 
            this.boxPre.BackColor = System.Drawing.Color.Transparent;
            this.boxPre.Controls.Add(this.lblweather);
            this.boxPre.Controls.Add(this.ddWeather);
            this.boxPre.Controls.Add(this.lblInc);
            this.boxPre.Controls.Add(this.ddCondition2);
            this.boxPre.Controls.Add(this.lblPID);
            this.boxPre.Controls.Add(this.lblCont);
            this.boxPre.Controls.Add(this.ddCondition);
            this.boxPre.Controls.Add(this.txtPID);
            this.boxPre.Controls.Add(this.btnSetup);
            this.boxPre.Location = new System.Drawing.Point(12, 12);
            this.boxPre.Name = "boxPre";
            this.boxPre.Size = new System.Drawing.Size(360, 194);
            this.boxPre.TabIndex = 11;
            this.boxPre.TabStop = false;
            this.boxPre.Text = "Pre Experiment";
            this.boxPre.Enter += new System.EventHandler(this.boxPre_Enter);
            // 
            // lblweather
            // 
            this.lblweather.AutoSize = true;
            this.lblweather.Location = new System.Drawing.Point(213, 151);
            this.lblweather.Name = "lblweather";
            this.lblweather.Size = new System.Drawing.Size(48, 13);
            this.lblweather.TabIndex = 12;
            this.lblweather.Text = "Weather";
            // 
            // ddWeather
            // 
            this.ddWeather.FormattingEnabled = true;
            this.ddWeather.Items.AddRange(new object[] {
            "Great",
            "Bad"});
            this.ddWeather.Location = new System.Drawing.Point(216, 167);
            this.ddWeather.Name = "ddWeather";
            this.ddWeather.Size = new System.Drawing.Size(121, 21);
            this.ddWeather.TabIndex = 11;
            this.ddWeather.SelectedIndexChanged += new System.EventHandler(this.ddWeather_SelectedIndexChanged);
            // 
            // waterIntake
            // 
            this.waterIntake.FormattingEnabled = true;
            this.waterIntake.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.waterIntake.Location = new System.Drawing.Point(12, 265);
            this.waterIntake.Name = "waterIntake";
            this.waterIntake.Size = new System.Drawing.Size(121, 21);
            this.waterIntake.TabIndex = 12;
            this.waterIntake.SelectedIndexChanged += new System.EventHandler(this.waterIntake_SelectedIndexChanged);
            // 
            // lblWatIn
            // 
            this.lblWatIn.AutoSize = true;
            this.lblWatIn.Location = new System.Drawing.Point(12, 249);
            this.lblWatIn.Name = "lblWatIn";
            this.lblWatIn.Size = new System.Drawing.Size(69, 13);
            this.lblWatIn.TabIndex = 13;
            this.lblWatIn.Text = "Water Intake";
            // 
            // ddGlas
            // 
            this.ddGlas.FormattingEnabled = true;
            this.ddGlas.Items.AddRange(new object[] {
            "Untouched",
            "Full",
            "Halfempty",
            "Empty"});
            this.ddGlas.Location = new System.Drawing.Point(175, 265);
            this.ddGlas.Name = "ddGlas";
            this.ddGlas.Size = new System.Drawing.Size(121, 21);
            this.ddGlas.TabIndex = 14;
            this.ddGlas.SelectedIndexChanged += new System.EventHandler(this.ddGlas_SelectedIndexChanged);
            // 
            // lblGlas
            // 
            this.lblGlas.AutoSize = true;
            this.lblGlas.Location = new System.Drawing.Point(175, 249);
            this.lblGlas.Name = "lblGlas";
            this.lblGlas.Size = new System.Drawing.Size(61, 13);
            this.lblGlas.TabIndex = 15;
            this.lblGlas.Text = "Glas Status";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(12, 347);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 16;
            this.btnYes.Text = "yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(103, 347);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 17;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 440);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblGlas);
            this.Controls.Add(this.ddGlas);
            this.Controls.Add(this.lblWatIn);
            this.Controls.Add(this.waterIntake);
            this.Controls.Add(this.boxPre);
            this.Controls.Add(this.btnInter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxPre.ResumeLayout(false);
            this.boxPre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.ComboBox ddCondition;
        private System.Windows.Forms.Label lblInc;
        private System.Windows.Forms.ComboBox ddCondition2;
        private System.Windows.Forms.GroupBox boxPre;
        private System.Windows.Forms.ComboBox waterIntake;
        private System.Windows.Forms.Label lblWatIn;
        private System.Windows.Forms.Label lblweather;
        private System.Windows.Forms.ComboBox ddWeather;
        private System.Windows.Forms.ComboBox ddGlas;
        private System.Windows.Forms.Label lblGlas;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}