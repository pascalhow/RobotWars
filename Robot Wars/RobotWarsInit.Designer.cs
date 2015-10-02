namespace RobotWars
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.Output_initPage_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridWidth_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridHeight_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.setGridSize_btn = new System.Windows.Forms.Button();
            this.panel_robot1Setup = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.robot1_FirstMove_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.robot_1_orientation_cbox = new System.Windows.Forms.ComboBox();
            this.robot_1_positionY_cbox = new System.Windows.Forms.ComboBox();
            this.robot_1_positionX_cbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_robot2Setup = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.robot2_FirstMove_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.robot_2_orientation_cbox = new System.Windows.Forms.ComboBox();
            this.robot_2_positionY_cbox = new System.Windows.Forms.ComboBox();
            this.robot_2_positionX_cbox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.initialise_btn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.Go_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidth_numUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeight_numUpDown)).BeginInit();
            this.panel_robot1Setup.SuspendLayout();
            this.panel_robot2Setup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output_initPage_textbox
            // 
            this.Output_initPage_textbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Output_initPage_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output_initPage_textbox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_initPage_textbox.ForeColor = System.Drawing.Color.White;
            this.Output_initPage_textbox.Location = new System.Drawing.Point(12, 15);
            this.Output_initPage_textbox.Multiline = true;
            this.Output_initPage_textbox.Name = "Output_initPage_textbox";
            this.Output_initPage_textbox.ReadOnly = true;
            this.Output_initPage_textbox.Size = new System.Drawing.Size(241, 173);
            this.Output_initPage_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // gridWidth_numUpDown
            // 
            this.gridWidth_numUpDown.Location = new System.Drawing.Point(54, 40);
            this.gridWidth_numUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gridWidth_numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridWidth_numUpDown.Name = "gridWidth_numUpDown";
            this.gridWidth_numUpDown.Size = new System.Drawing.Size(55, 20);
            this.gridWidth_numUpDown.TabIndex = 3;
            this.gridWidth_numUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // gridHeight_numUpDown
            // 
            this.gridHeight_numUpDown.Location = new System.Drawing.Point(173, 40);
            this.gridHeight_numUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gridHeight_numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridHeight_numUpDown.Name = "gridHeight_numUpDown";
            this.gridHeight_numUpDown.Size = new System.Drawing.Size(55, 20);
            this.gridHeight_numUpDown.TabIndex = 5;
            this.gridHeight_numUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height";
            // 
            // setGridSize_btn
            // 
            this.setGridSize_btn.Location = new System.Drawing.Point(254, 37);
            this.setGridSize_btn.Name = "setGridSize_btn";
            this.setGridSize_btn.Size = new System.Drawing.Size(61, 23);
            this.setGridSize_btn.TabIndex = 6;
            this.setGridSize_btn.Text = "Set";
            this.setGridSize_btn.UseVisualStyleBackColor = true;
            this.setGridSize_btn.Click += new System.EventHandler(this.setGridSize_btn_Click);
            // 
            // panel_robot1Setup
            // 
            this.panel_robot1Setup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_robot1Setup.Controls.Add(this.label10);
            this.panel_robot1Setup.Controls.Add(this.robot1_FirstMove_textbox);
            this.panel_robot1Setup.Controls.Add(this.label9);
            this.panel_robot1Setup.Controls.Add(this.robot_1_orientation_cbox);
            this.panel_robot1Setup.Controls.Add(this.robot_1_positionY_cbox);
            this.panel_robot1Setup.Controls.Add(this.robot_1_positionX_cbox);
            this.panel_robot1Setup.Controls.Add(this.label8);
            this.panel_robot1Setup.Controls.Add(this.label7);
            this.panel_robot1Setup.Controls.Add(this.label6);
            this.panel_robot1Setup.Controls.Add(this.label4);
            this.panel_robot1Setup.Enabled = false;
            this.panel_robot1Setup.Location = new System.Drawing.Point(16, 74);
            this.panel_robot1Setup.Name = "panel_robot1Setup";
            this.panel_robot1Setup.Size = new System.Drawing.Size(187, 145);
            this.panel_robot1Setup.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "E.g L, M, R";
            // 
            // robot1_FirstMove_textbox
            // 
            this.robot1_FirstMove_textbox.Location = new System.Drawing.Point(6, 108);
            this.robot1_FirstMove_textbox.MaxLength = 10;
            this.robot1_FirstMove_textbox.Name = "robot1_FirstMove_textbox";
            this.robot1_FirstMove_textbox.Size = new System.Drawing.Size(100, 20);
            this.robot1_FirstMove_textbox.TabIndex = 10;
            this.robot1_FirstMove_textbox.TextChanged += new System.EventHandler(this.robot1_FirstMove_textbox_TextChanged);
            this.robot1_FirstMove_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.robot1_FirstMove_textbox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "First Move";
            // 
            // robot_1_orientation_cbox
            // 
            this.robot_1_orientation_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.robot_1_orientation_cbox.FormattingEnabled = true;
            this.robot_1_orientation_cbox.Items.AddRange(new object[] {
            "N",
            "W",
            "S",
            "E"});
            this.robot_1_orientation_cbox.Location = new System.Drawing.Point(106, 55);
            this.robot_1_orientation_cbox.Name = "robot_1_orientation_cbox";
            this.robot_1_orientation_cbox.Size = new System.Drawing.Size(44, 21);
            this.robot_1_orientation_cbox.TabIndex = 8;
            // 
            // robot_1_positionY_cbox
            // 
            this.robot_1_positionY_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.robot_1_positionY_cbox.FormattingEnabled = true;
            this.robot_1_positionY_cbox.Location = new System.Drawing.Point(56, 55);
            this.robot_1_positionY_cbox.Name = "robot_1_positionY_cbox";
            this.robot_1_positionY_cbox.Size = new System.Drawing.Size(44, 21);
            this.robot_1_positionY_cbox.TabIndex = 7;
            // 
            // robot_1_positionX_cbox
            // 
            this.robot_1_positionX_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.robot_1_positionX_cbox.FormattingEnabled = true;
            this.robot_1_positionX_cbox.Location = new System.Drawing.Point(6, 55);
            this.robot_1_positionX_cbox.Name = "robot_1_positionX_cbox";
            this.robot_1_positionX_cbox.Size = new System.Drawing.Size(44, 21);
            this.robot_1_positionX_cbox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Orientation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(66, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Robot 1";
            // 
            // panel_robot2Setup
            // 
            this.panel_robot2Setup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_robot2Setup.Controls.Add(this.label11);
            this.panel_robot2Setup.Controls.Add(this.robot2_FirstMove_textbox);
            this.panel_robot2Setup.Controls.Add(this.label12);
            this.panel_robot2Setup.Controls.Add(this.robot_2_orientation_cbox);
            this.panel_robot2Setup.Controls.Add(this.robot_2_positionY_cbox);
            this.panel_robot2Setup.Controls.Add(this.robot_2_positionX_cbox);
            this.panel_robot2Setup.Controls.Add(this.label13);
            this.panel_robot2Setup.Controls.Add(this.label14);
            this.panel_robot2Setup.Controls.Add(this.label15);
            this.panel_robot2Setup.Controls.Add(this.label5);
            this.panel_robot2Setup.Enabled = false;
            this.panel_robot2Setup.Location = new System.Drawing.Point(209, 74);
            this.panel_robot2Setup.Name = "panel_robot2Setup";
            this.panel_robot2Setup.Size = new System.Drawing.Size(187, 145);
            this.panel_robot2Setup.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "E.g L, M, R";
            // 
            // robot2_FirstMove_textbox
            // 
            this.robot2_FirstMove_textbox.Location = new System.Drawing.Point(6, 107);
            this.robot2_FirstMove_textbox.MaxLength = 10;
            this.robot2_FirstMove_textbox.Name = "robot2_FirstMove_textbox";
            this.robot2_FirstMove_textbox.Size = new System.Drawing.Size(100, 20);
            this.robot2_FirstMove_textbox.TabIndex = 19;
            this.robot2_FirstMove_textbox.TextChanged += new System.EventHandler(this.robot2_FirstMove_textbox_TextChanged);
            this.robot2_FirstMove_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.robot2_FirstMove_textbox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "First Move";
            // 
            // robot_2_orientation_cbox
            // 
            this.robot_2_orientation_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.robot_2_orientation_cbox.FormattingEnabled = true;
            this.robot_2_orientation_cbox.Items.AddRange(new object[] {
            "N",
            "W",
            "S",
            "E"});
            this.robot_2_orientation_cbox.Location = new System.Drawing.Point(106, 54);
            this.robot_2_orientation_cbox.Name = "robot_2_orientation_cbox";
            this.robot_2_orientation_cbox.Size = new System.Drawing.Size(44, 21);
            this.robot_2_orientation_cbox.TabIndex = 17;
            // 
            // robot_2_positionY_cbox
            // 
            this.robot_2_positionY_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.robot_2_positionY_cbox.FormattingEnabled = true;
            this.robot_2_positionY_cbox.Location = new System.Drawing.Point(56, 54);
            this.robot_2_positionY_cbox.Name = "robot_2_positionY_cbox";
            this.robot_2_positionY_cbox.Size = new System.Drawing.Size(44, 21);
            this.robot_2_positionY_cbox.TabIndex = 16;
            // 
            // robot_2_positionX_cbox
            // 
            this.robot_2_positionX_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.robot_2_positionX_cbox.FormattingEnabled = true;
            this.robot_2_positionX_cbox.Location = new System.Drawing.Point(6, 54);
            this.robot_2_positionX_cbox.Name = "robot_2_positionX_cbox";
            this.robot_2_positionX_cbox.Size = new System.Drawing.Size(44, 21);
            this.robot_2_positionX_cbox.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(103, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Orientation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(69, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(66, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Robot 2";
            // 
            // initialise_btn
            // 
            this.initialise_btn.Enabled = false;
            this.initialise_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialise_btn.Location = new System.Drawing.Point(15, 236);
            this.initialise_btn.Name = "initialise_btn";
            this.initialise_btn.Size = new System.Drawing.Size(381, 48);
            this.initialise_btn.TabIndex = 9;
            this.initialise_btn.Text = "Initialise";
            this.initialise_btn.UseVisualStyleBackColor = true;
            this.initialise_btn.Click += new System.EventHandler(this.initialise_btn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(92, 301);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Message Centre";
            // 
            // Go_btn
            // 
            this.Go_btn.Enabled = false;
            this.Go_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_btn.Location = new System.Drawing.Point(299, 368);
            this.Go_btn.Name = "Go_btn";
            this.Go_btn.Size = new System.Drawing.Size(97, 93);
            this.Go_btn.TabIndex = 11;
            this.Go_btn.Text = "Go";
            this.Go_btn.UseVisualStyleBackColor = true;
            this.Go_btn.Click += new System.EventHandler(this.Go_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Output_initPage_textbox);
            this.panel1.Location = new System.Drawing.Point(16, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 191);
            this.panel1.TabIndex = 12;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Go_btn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.initialise_btn);
            this.Controls.Add(this.panel_robot2Setup);
            this.Controls.Add(this.panel_robot1Setup);
            this.Controls.Add(this.setGridSize_btn);
            this.Controls.Add(this.gridHeight_numUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridWidth_numUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Wars Setup";
            ((System.ComponentModel.ISupportInitialize)(this.gridWidth_numUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeight_numUpDown)).EndInit();
            this.panel_robot1Setup.ResumeLayout(false);
            this.panel_robot1Setup.PerformLayout();
            this.panel_robot2Setup.ResumeLayout(false);
            this.panel_robot2Setup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output_initPage_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown gridWidth_numUpDown;
        private System.Windows.Forms.NumericUpDown gridHeight_numUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setGridSize_btn;
        private System.Windows.Forms.Panel panel_robot1Setup;
        private System.Windows.Forms.Panel panel_robot2Setup;
        private System.Windows.Forms.ComboBox robot_1_orientation_cbox;
        private System.Windows.Forms.ComboBox robot_1_positionY_cbox;
        private System.Windows.Forms.ComboBox robot_1_positionX_cbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox robot1_FirstMove_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox robot2_FirstMove_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox robot_2_orientation_cbox;
        private System.Windows.Forms.ComboBox robot_2_positionY_cbox;
        private System.Windows.Forms.ComboBox robot_2_positionX_cbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button initialise_btn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Go_btn;
        private System.Windows.Forms.Panel panel1;
    }
}

