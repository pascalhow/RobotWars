namespace RobotWars
{
    partial class RobotWarBattleField_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotWarBattleField_Form));
            this.battleground_panel = new System.Windows.Forms.Panel();
            this.R2_pbox = new System.Windows.Forms.PictureBox();
            this.R1_pbox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Output_battlePage_textbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.R2_Go_btn = new System.Windows.Forms.Button();
            this.R1_Go_btn = new System.Windows.Forms.Button();
            this.R2_panel = new System.Windows.Forms.Panel();
            this.robot_2_score_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.R2_plannedMove_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.R2_newPosition_lbl = new System.Windows.Forms.Label();
            this.robot2_name_lbl = new System.Windows.Forms.Label();
            this.R1_panel = new System.Windows.Forms.Panel();
            this.robot_1_score_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.R1_plannedMove_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.R1_newPosition_lbl = new System.Windows.Forms.Label();
            this.robot1_name_lbl = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.battleground_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R2_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1_pbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.R2_panel.SuspendLayout();
            this.R1_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // battleground_panel
            // 
            this.battleground_panel.BackColor = System.Drawing.Color.Black;
            this.battleground_panel.Controls.Add(this.R2_pbox);
            this.battleground_panel.Controls.Add(this.R1_pbox);
            this.battleground_panel.Location = new System.Drawing.Point(27, 53);
            this.battleground_panel.Name = "battleground_panel";
            this.battleground_panel.Size = new System.Drawing.Size(400, 400);
            this.battleground_panel.TabIndex = 0;
            this.battleground_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.battleground_panel_Paint);
            // 
            // R2_pbox
            // 
            this.R2_pbox.BackColor = System.Drawing.Color.Transparent;
            this.R2_pbox.Location = new System.Drawing.Point(177, 33);
            this.R2_pbox.Name = "R2_pbox";
            this.R2_pbox.Size = new System.Drawing.Size(45, 45);
            this.R2_pbox.TabIndex = 1;
            this.R2_pbox.TabStop = false;
            // 
            // R1_pbox
            // 
            this.R1_pbox.BackColor = System.Drawing.Color.Transparent;
            this.R1_pbox.Location = new System.Drawing.Point(30, 33);
            this.R1_pbox.Name = "R1_pbox";
            this.R1_pbox.Size = new System.Drawing.Size(45, 45);
            this.R1_pbox.TabIndex = 0;
            this.R1_pbox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.R2_Go_btn);
            this.panel1.Controls.Add(this.R1_Go_btn);
            this.panel1.Controls.Add(this.R2_panel);
            this.panel1.Controls.Add(this.R1_panel);
            this.panel1.Location = new System.Drawing.Point(445, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 400);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Output_battlePage_textbox);
            this.panel2.Location = new System.Drawing.Point(15, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 178);
            this.panel2.TabIndex = 13;
            // 
            // Output_battlePage_textbox
            // 
            this.Output_battlePage_textbox.BackColor = System.Drawing.Color.Black;
            this.Output_battlePage_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output_battlePage_textbox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_battlePage_textbox.ForeColor = System.Drawing.Color.White;
            this.Output_battlePage_textbox.Location = new System.Drawing.Point(12, 14);
            this.Output_battlePage_textbox.Multiline = true;
            this.Output_battlePage_textbox.Name = "Output_battlePage_textbox";
            this.Output_battlePage_textbox.ReadOnly = true;
            this.Output_battlePage_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_battlePage_textbox.Size = new System.Drawing.Size(366, 151);
            this.Output_battlePage_textbox.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(141, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Message Centre";
            // 
            // R2_Go_btn
            // 
            this.R2_Go_btn.Enabled = false;
            this.R2_Go_btn.Location = new System.Drawing.Point(257, 140);
            this.R2_Go_btn.Name = "R2_Go_btn";
            this.R2_Go_btn.Size = new System.Drawing.Size(75, 23);
            this.R2_Go_btn.TabIndex = 4;
            this.R2_Go_btn.Text = "Go";
            this.R2_Go_btn.UseVisualStyleBackColor = true;
            this.R2_Go_btn.Click += new System.EventHandler(this.R2_Go_btn_Click);
            // 
            // R1_Go_btn
            // 
            this.R1_Go_btn.Location = new System.Drawing.Point(65, 141);
            this.R1_Go_btn.Name = "R1_Go_btn";
            this.R1_Go_btn.Size = new System.Drawing.Size(75, 23);
            this.R1_Go_btn.TabIndex = 3;
            this.R1_Go_btn.Text = "Go";
            this.R1_Go_btn.UseVisualStyleBackColor = true;
            this.R1_Go_btn.Click += new System.EventHandler(this.R1_Go_btn_Click);
            // 
            // R2_panel
            // 
            this.R2_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R2_panel.Controls.Add(this.robot_2_score_lbl);
            this.R2_panel.Controls.Add(this.label2);
            this.R2_panel.Controls.Add(this.R2_plannedMove_textbox);
            this.R2_panel.Controls.Add(this.label3);
            this.R2_panel.Controls.Add(this.R2_newPosition_lbl);
            this.R2_panel.Controls.Add(this.robot2_name_lbl);
            this.R2_panel.Location = new System.Drawing.Point(207, 20);
            this.R2_panel.Name = "R2_panel";
            this.R2_panel.Size = new System.Drawing.Size(186, 114);
            this.R2_panel.TabIndex = 2;
            // 
            // robot_2_score_lbl
            // 
            this.robot_2_score_lbl.AutoSize = true;
            this.robot_2_score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robot_2_score_lbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.robot_2_score_lbl.Location = new System.Drawing.Point(152, 2);
            this.robot_2_score_lbl.Name = "robot_2_score_lbl";
            this.robot_2_score_lbl.Size = new System.Drawing.Size(30, 31);
            this.robot_2_score_lbl.TabIndex = 16;
            this.robot_2_score_lbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "E.g L, M, R";
            // 
            // R2_plannedMove_textbox
            // 
            this.R2_plannedMove_textbox.Enabled = false;
            this.R2_plannedMove_textbox.Location = new System.Drawing.Point(11, 80);
            this.R2_plannedMove_textbox.MaxLength = 10;
            this.R2_plannedMove_textbox.Name = "R2_plannedMove_textbox";
            this.R2_plannedMove_textbox.Size = new System.Drawing.Size(100, 20);
            this.R2_plannedMove_textbox.TabIndex = 13;
            this.R2_plannedMove_textbox.TextChanged += new System.EventHandler(this.R2_plannedMove_textbox_TextChanged);
            this.R2_plannedMove_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R2_plannedMove_textbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Planned Move";
            // 
            // R2_newPosition_lbl
            // 
            this.R2_newPosition_lbl.AutoSize = true;
            this.R2_newPosition_lbl.Location = new System.Drawing.Point(8, 35);
            this.R2_newPosition_lbl.Name = "R2_newPosition_lbl";
            this.R2_newPosition_lbl.Size = new System.Drawing.Size(50, 13);
            this.R2_newPosition_lbl.TabIndex = 1;
            this.R2_newPosition_lbl.Text = "Position: ";
            // 
            // robot2_name_lbl
            // 
            this.robot2_name_lbl.AutoSize = true;
            this.robot2_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robot2_name_lbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.robot2_name_lbl.Location = new System.Drawing.Point(8, 11);
            this.robot2_name_lbl.Name = "robot2_name_lbl";
            this.robot2_name_lbl.Size = new System.Drawing.Size(52, 13);
            this.robot2_name_lbl.TabIndex = 0;
            this.robot2_name_lbl.Text = "Robot 2";
            // 
            // R1_panel
            // 
            this.R1_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R1_panel.Controls.Add(this.robot_1_score_lbl);
            this.R1_panel.Controls.Add(this.label10);
            this.R1_panel.Controls.Add(this.R1_plannedMove_textbox);
            this.R1_panel.Controls.Add(this.label9);
            this.R1_panel.Controls.Add(this.R1_newPosition_lbl);
            this.R1_panel.Controls.Add(this.robot1_name_lbl);
            this.R1_panel.Location = new System.Drawing.Point(15, 20);
            this.R1_panel.Name = "R1_panel";
            this.R1_panel.Size = new System.Drawing.Size(186, 114);
            this.R1_panel.TabIndex = 0;
            // 
            // robot_1_score_lbl
            // 
            this.robot_1_score_lbl.AutoSize = true;
            this.robot_1_score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robot_1_score_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.robot_1_score_lbl.Location = new System.Drawing.Point(152, 2);
            this.robot_1_score_lbl.Name = "robot_1_score_lbl";
            this.robot_1_score_lbl.Size = new System.Drawing.Size(30, 31);
            this.robot_1_score_lbl.TabIndex = 15;
            this.robot_1_score_lbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(115, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "E.g L, M, R";
            // 
            // R1_plannedMove_textbox
            // 
            this.R1_plannedMove_textbox.Location = new System.Drawing.Point(11, 80);
            this.R1_plannedMove_textbox.MaxLength = 10;
            this.R1_plannedMove_textbox.Name = "R1_plannedMove_textbox";
            this.R1_plannedMove_textbox.Size = new System.Drawing.Size(100, 20);
            this.R1_plannedMove_textbox.TabIndex = 13;
            this.R1_plannedMove_textbox.TextChanged += new System.EventHandler(this.R1_plannedMove_textbox_TextChanged);
            this.R1_plannedMove_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R1_plannedMove_textbox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Planned Move";
            // 
            // R1_newPosition_lbl
            // 
            this.R1_newPosition_lbl.AutoSize = true;
            this.R1_newPosition_lbl.Location = new System.Drawing.Point(8, 35);
            this.R1_newPosition_lbl.Name = "R1_newPosition_lbl";
            this.R1_newPosition_lbl.Size = new System.Drawing.Size(50, 13);
            this.R1_newPosition_lbl.TabIndex = 1;
            this.R1_newPosition_lbl.Text = "Position: ";
            // 
            // robot1_name_lbl
            // 
            this.robot1_name_lbl.AutoSize = true;
            this.robot1_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robot1_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.robot1_name_lbl.Location = new System.Drawing.Point(8, 11);
            this.robot1_name_lbl.Name = "robot1_name_lbl";
            this.robot1_name_lbl.Size = new System.Drawing.Size(52, 13);
            this.robot1_name_lbl.TabIndex = 0;
            this.robot1_name_lbl.Text = "Robot 1";
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(329, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(208, 29);
            this.mainTitle.TabIndex = 2;
            this.mainTitle.Text = "Robot Wars Arena";
            // 
            // RobotWarBattleField_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 469);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.battleground_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RobotWarBattleField_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RobotWarBattleField_Form_FormClosed);
            this.Load += new System.EventHandler(this.RobotWarBattleField_Form_Load);
            this.battleground_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.R2_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1_pbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.R2_panel.ResumeLayout(false);
            this.R2_panel.PerformLayout();
            this.R1_panel.ResumeLayout(false);
            this.R1_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel battleground_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel R1_panel;
        private System.Windows.Forms.TextBox Output_battlePage_textbox;
        private System.Windows.Forms.Label R1_newPosition_lbl;
        private System.Windows.Forms.Label robot1_name_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox R1_plannedMove_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel R2_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox R2_plannedMove_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label R2_newPosition_lbl;
        private System.Windows.Forms.Label robot2_name_lbl;
        private System.Windows.Forms.Button R1_Go_btn;
        private System.Windows.Forms.Button R2_Go_btn;
        private System.Windows.Forms.PictureBox R1_pbox;
        private System.Windows.Forms.PictureBox R2_pbox;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label robot_1_score_lbl;
        private System.Windows.Forms.Label robot_2_score_lbl;
    }
}