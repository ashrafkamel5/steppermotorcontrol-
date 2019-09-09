namespace Stepper_Motor_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portsComboBox = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.motorcombo1 = new System.Windows.Forms.ComboBox();
            this.motorMove1 = new System.Windows.Forms.Button();
            this.motortextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.motorStop1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.motorStop2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.motortextBox2 = new System.Windows.Forms.TextBox();
            this.motorMove2 = new System.Windows.Forms.Button();
            this.motorcombo2 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.motorStop3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.motortextBox3 = new System.Windows.Forms.TextBox();
            this.motorMove3 = new System.Windows.Forms.Button();
            this.motorcombo3 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.motorStop4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.motortextBox4 = new System.Windows.Forms.TextBox();
            this.motorMove4 = new System.Windows.Forms.Button();
            this.motorcombo4 = new System.Windows.Forms.ComboBox();
            this.moveAll_B = new System.Windows.Forms.Button();
            this.stopAll_B = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // portsComboBox
            // 
            this.portsComboBox.FormattingEnabled = true;
            this.portsComboBox.Location = new System.Drawing.Point(9, 24);
            this.portsComboBox.Name = "portsComboBox";
            this.portsComboBox.Size = new System.Drawing.Size(116, 21);
            this.portsComboBox.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(160, 24);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(69, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(48, 54);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.portsComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 70);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SelectPort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status:";
            // 
            // motorcombo1
            // 
            this.motorcombo1.FormattingEnabled = true;
            this.motorcombo1.IntegralHeight = false;
            this.motorcombo1.Items.AddRange(new object[] {
            "clockwise rotation",
            "counter clockwise rotation"});
            this.motorcombo1.Location = new System.Drawing.Point(9, 26);
            this.motorcombo1.Name = "motorcombo1";
            this.motorcombo1.Size = new System.Drawing.Size(120, 21);
            this.motorcombo1.TabIndex = 8;
            // 
            // motorMove1
            // 
            this.motorMove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorMove1.Location = new System.Drawing.Point(9, 79);
            this.motorMove1.Name = "motorMove1";
            this.motorMove1.Size = new System.Drawing.Size(75, 23);
            this.motorMove1.TabIndex = 12;
            this.motorMove1.Text = "Move";
            this.motorMove1.UseVisualStyleBackColor = true;
            this.motorMove1.Click += new System.EventHandler(this.motorMove1_Click);
            // 
            // motortextBox1
            // 
            this.motortextBox1.Location = new System.Drawing.Point(9, 53);
            this.motortextBox1.MaxLength = 10;
            this.motortextBox1.Name = "motortextBox1";
            this.motortextBox1.Size = new System.Drawing.Size(57, 20);
            this.motortextBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "S";
            // 
            // motorStop1
            // 
            this.motorStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorStop1.Location = new System.Drawing.Point(110, 79);
            this.motorStop1.Name = "motorStop1";
            this.motorStop1.Size = new System.Drawing.Size(75, 23);
            this.motorStop1.TabIndex = 26;
            this.motorStop1.Text = "Stop";
            this.motorStop1.UseVisualStyleBackColor = true;
            this.motorStop1.Click += new System.EventHandler(this.motorStop1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.motorStop1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.motortextBox1);
            this.groupBox2.Controls.Add(this.motorMove1);
            this.groupBox2.Controls.Add(this.motorcombo1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 117);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1st Motor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 42);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.motorStop2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.motortextBox2);
            this.groupBox3.Controls.Add(this.motorMove2);
            this.groupBox3.Controls.Add(this.motorcombo2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(215, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 117);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2nd Motor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(145, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 42);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // motorStop2
            // 
            this.motorStop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorStop2.Location = new System.Drawing.Point(122, 79);
            this.motorStop2.Name = "motorStop2";
            this.motorStop2.Size = new System.Drawing.Size(75, 23);
            this.motorStop2.TabIndex = 26;
            this.motorStop2.Text = "Stop";
            this.motorStop2.UseVisualStyleBackColor = true;
            this.motorStop2.Click += new System.EventHandler(this.motorStop2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "S";
            // 
            // motortextBox2
            // 
            this.motortextBox2.Location = new System.Drawing.Point(9, 53);
            this.motortextBox2.MaxLength = 10;
            this.motortextBox2.Name = "motortextBox2";
            this.motortextBox2.Size = new System.Drawing.Size(57, 20);
            this.motortextBox2.TabIndex = 16;
            // 
            // motorMove2
            // 
            this.motorMove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorMove2.Location = new System.Drawing.Point(9, 79);
            this.motorMove2.Name = "motorMove2";
            this.motorMove2.Size = new System.Drawing.Size(75, 23);
            this.motorMove2.TabIndex = 12;
            this.motorMove2.Text = "Move";
            this.motorMove2.UseVisualStyleBackColor = true;
            this.motorMove2.Click += new System.EventHandler(this.motorMove2_Click);
            // 
            // motorcombo2
            // 
            this.motorcombo2.FormattingEnabled = true;
            this.motorcombo2.IntegralHeight = false;
            this.motorcombo2.Items.AddRange(new object[] {
            "clockwise rotation",
            "counter clockwise rotation"});
            this.motorcombo2.Location = new System.Drawing.Point(9, 26);
            this.motorcombo2.Name = "motorcombo2";
            this.motorcombo2.Size = new System.Drawing.Size(120, 21);
            this.motorcombo2.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.motorStop3);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.motortextBox3);
            this.groupBox4.Controls.Add(this.motorMove3);
            this.groupBox4.Controls.Add(this.motorcombo3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 117);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3rd Motor";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(146, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 42);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // motorStop3
            // 
            this.motorStop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorStop3.Location = new System.Drawing.Point(110, 79);
            this.motorStop3.Name = "motorStop3";
            this.motorStop3.Size = new System.Drawing.Size(75, 23);
            this.motorStop3.TabIndex = 26;
            this.motorStop3.Text = "Stop";
            this.motorStop3.UseVisualStyleBackColor = true;
            this.motorStop3.Click += new System.EventHandler(this.motorStop3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "S";
            // 
            // motortextBox3
            // 
            this.motortextBox3.Location = new System.Drawing.Point(9, 53);
            this.motortextBox3.MaxLength = 10;
            this.motortextBox3.Name = "motortextBox3";
            this.motortextBox3.Size = new System.Drawing.Size(57, 20);
            this.motortextBox3.TabIndex = 16;
            // 
            // motorMove3
            // 
            this.motorMove3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorMove3.Location = new System.Drawing.Point(9, 79);
            this.motorMove3.Name = "motorMove3";
            this.motorMove3.Size = new System.Drawing.Size(75, 23);
            this.motorMove3.TabIndex = 12;
            this.motorMove3.Text = "Move";
            this.motorMove3.UseVisualStyleBackColor = true;
            this.motorMove3.Click += new System.EventHandler(this.motorMove3_Click);
            // 
            // motorcombo3
            // 
            this.motorcombo3.FormattingEnabled = true;
            this.motorcombo3.IntegralHeight = false;
            this.motorcombo3.Items.AddRange(new object[] {
            "clockwise rotation",
            "counter clockwise rotation"});
            this.motorcombo3.Location = new System.Drawing.Point(9, 26);
            this.motorcombo3.Name = "motorcombo3";
            this.motorcombo3.Size = new System.Drawing.Size(120, 21);
            this.motorcombo3.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.motorStop4);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.motortextBox4);
            this.groupBox5.Controls.Add(this.motorMove4);
            this.groupBox5.Controls.Add(this.motorcombo4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(215, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 117);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4th Motor";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(146, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 42);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // motorStop4
            // 
            this.motorStop4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorStop4.Location = new System.Drawing.Point(122, 79);
            this.motorStop4.Name = "motorStop4";
            this.motorStop4.Size = new System.Drawing.Size(75, 23);
            this.motorStop4.TabIndex = 26;
            this.motorStop4.Text = "Stop";
            this.motorStop4.UseVisualStyleBackColor = true;
            this.motorStop4.Click += new System.EventHandler(this.motorStop4_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "S";
            // 
            // motortextBox4
            // 
            this.motortextBox4.Location = new System.Drawing.Point(9, 53);
            this.motortextBox4.MaxLength = 10;
            this.motortextBox4.Name = "motortextBox4";
            this.motortextBox4.Size = new System.Drawing.Size(57, 20);
            this.motortextBox4.TabIndex = 16;
            // 
            // motorMove4
            // 
            this.motorMove4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorMove4.Location = new System.Drawing.Point(9, 79);
            this.motorMove4.Name = "motorMove4";
            this.motorMove4.Size = new System.Drawing.Size(75, 23);
            this.motorMove4.TabIndex = 12;
            this.motorMove4.Text = "Move";
            this.motorMove4.UseVisualStyleBackColor = true;
            this.motorMove4.Click += new System.EventHandler(this.motorMove4_Click);
            // 
            // motorcombo4
            // 
            this.motorcombo4.FormattingEnabled = true;
            this.motorcombo4.IntegralHeight = false;
            this.motorcombo4.Items.AddRange(new object[] {
            "clockwise rotation",
            "counter clockwise rotation"});
            this.motorcombo4.Location = new System.Drawing.Point(9, 26);
            this.motorcombo4.Name = "motorcombo4";
            this.motorcombo4.Size = new System.Drawing.Size(120, 21);
            this.motorcombo4.TabIndex = 8;
            // 
            // moveAll_B
            // 
            this.moveAll_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveAll_B.Location = new System.Drawing.Point(327, 12);
            this.moveAll_B.Name = "moveAll_B";
            this.moveAll_B.Size = new System.Drawing.Size(92, 23);
            this.moveAll_B.TabIndex = 35;
            this.moveAll_B.Text = "Move All Motors";
            this.moveAll_B.UseVisualStyleBackColor = true;
            this.moveAll_B.Click += new System.EventHandler(this.moveAll_B_Click);
            // 
            // stopAll_B
            // 
            this.stopAll_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAll_B.Location = new System.Drawing.Point(327, 54);
            this.stopAll_B.Name = "stopAll_B";
            this.stopAll_B.Size = new System.Drawing.Size(92, 23);
            this.stopAll_B.TabIndex = 36;
            this.stopAll_B.Text = "Stop All Motors";
            this.stopAll_B.UseVisualStyleBackColor = true;
            this.stopAll_B.Click += new System.EventHandler(this.stopAll_B_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkSerialPorts_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 330);
            this.Controls.Add(this.stopAll_B);
            this.Controls.Add(this.moveAll_B);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Motor control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portsComboBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox motorcombo1;
        private System.Windows.Forms.Button motorMove1;
        private System.Windows.Forms.TextBox motortextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button motorStop1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button motorStop2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox motortextBox2;
        private System.Windows.Forms.Button motorMove2;
        private System.Windows.Forms.ComboBox motorcombo2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button motorStop3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox motortextBox3;
        private System.Windows.Forms.Button motorMove3;
        private System.Windows.Forms.ComboBox motorcombo3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button motorStop4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox motortextBox4;
        private System.Windows.Forms.Button motorMove4;
        private System.Windows.Forms.ComboBox motorcombo4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button moveAll_B;
        private System.Windows.Forms.Button stopAll_B;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

