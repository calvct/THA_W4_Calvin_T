namespace THA_W4_Calvin_T
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBox_Country = new System.Windows.Forms.ComboBox();
            this.cmbBox_Team = new System.Windows.Forms.ComboBox();
            this.cmbBox_Position = new System.Windows.Forms.ComboBox();
            this.tbox_TeamName = new System.Windows.Forms.TextBox();
            this.tbox_Country = new System.Windows.Forms.TextBox();
            this.tbox_City = new System.Windows.Forms.TextBox();
            this.tbox_PlayerName = new System.Windows.Forms.TextBox();
            this.tbox_Number = new System.Windows.Forms.TextBox();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.btn_AddPlayer = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.listBox_Player = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Team:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adding Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Team Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Team City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adding Player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Player Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Player Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(519, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Player Position:";
            // 
            // cmbBox_Country
            // 
            this.cmbBox_Country.FormattingEnabled = true;
            this.cmbBox_Country.Location = new System.Drawing.Point(132, 77);
            this.cmbBox_Country.Name = "cmbBox_Country";
            this.cmbBox_Country.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Country.TabIndex = 11;
            this.cmbBox_Country.SelectionChangeCommitted += new System.EventHandler(this.cmbBox_Country_SelectionChangeCommitted);
            // 
            // cmbBox_Team
            // 
            this.cmbBox_Team.FormattingEnabled = true;
            this.cmbBox_Team.Location = new System.Drawing.Point(132, 112);
            this.cmbBox_Team.Name = "cmbBox_Team";
            this.cmbBox_Team.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Team.TabIndex = 12;
            this.cmbBox_Team.SelectionChangeCommitted += new System.EventHandler(this.cmbBox_Team_SelectionChangeCommitted);
            // 
            // cmbBox_Position
            // 
            this.cmbBox_Position.FormattingEnabled = true;
            this.cmbBox_Position.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cmbBox_Position.Location = new System.Drawing.Point(621, 153);
            this.cmbBox_Position.Name = "cmbBox_Position";
            this.cmbBox_Position.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Position.TabIndex = 13;
            // 
            // tbox_TeamName
            // 
            this.tbox_TeamName.Location = new System.Drawing.Point(379, 77);
            this.tbox_TeamName.Name = "tbox_TeamName";
            this.tbox_TeamName.Size = new System.Drawing.Size(117, 20);
            this.tbox_TeamName.TabIndex = 14;
            // 
            // tbox_Country
            // 
            this.tbox_Country.Location = new System.Drawing.Point(379, 115);
            this.tbox_Country.Name = "tbox_Country";
            this.tbox_Country.Size = new System.Drawing.Size(117, 20);
            this.tbox_Country.TabIndex = 15;
            // 
            // tbox_City
            // 
            this.tbox_City.Location = new System.Drawing.Point(379, 154);
            this.tbox_City.Name = "tbox_City";
            this.tbox_City.Size = new System.Drawing.Size(117, 20);
            this.tbox_City.TabIndex = 16;
            // 
            // tbox_PlayerName
            // 
            this.tbox_PlayerName.Location = new System.Drawing.Point(621, 74);
            this.tbox_PlayerName.Name = "tbox_PlayerName";
            this.tbox_PlayerName.Size = new System.Drawing.Size(121, 20);
            this.tbox_PlayerName.TabIndex = 17;
            // 
            // tbox_Number
            // 
            this.tbox_Number.Location = new System.Drawing.Point(621, 112);
            this.tbox_Number.Name = "tbox_Number";
            this.tbox_Number.Size = new System.Drawing.Size(121, 20);
            this.tbox_Number.TabIndex = 18;
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.Location = new System.Drawing.Point(379, 195);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTeam.TabIndex = 19;
            this.btn_AddTeam.Text = "Add";
            this.btn_AddTeam.UseVisualStyleBackColor = true;
            this.btn_AddTeam.Click += new System.EventHandler(this.btn_AddTeam_Click);
            // 
            // btn_AddPlayer
            // 
            this.btn_AddPlayer.Location = new System.Drawing.Point(621, 195);
            this.btn_AddPlayer.Name = "btn_AddPlayer";
            this.btn_AddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPlayer.TabIndex = 20;
            this.btn_AddPlayer.Text = "Add";
            this.btn_AddPlayer.UseVisualStyleBackColor = true;
            this.btn_AddPlayer.Click += new System.EventHandler(this.btn_AddPlayer_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(30, 336);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 21;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // listBox_Player
            // 
            this.listBox_Player.FormattingEnabled = true;
            this.listBox_Player.Location = new System.Drawing.Point(30, 172);
            this.listBox_Player.Name = "listBox_Player";
            this.listBox_Player.Size = new System.Drawing.Size(223, 147);
            this.listBox_Player.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.listBox_Player);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_AddPlayer);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.tbox_Number);
            this.Controls.Add(this.tbox_PlayerName);
            this.Controls.Add(this.tbox_City);
            this.Controls.Add(this.tbox_Country);
            this.Controls.Add(this.tbox_TeamName);
            this.Controls.Add(this.cmbBox_Position);
            this.Controls.Add(this.cmbBox_Team);
            this.Controls.Add(this.cmbBox_Country);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBox_Country;
        private System.Windows.Forms.ComboBox cmbBox_Team;
        private System.Windows.Forms.ComboBox cmbBox_Position;
        private System.Windows.Forms.TextBox tbox_TeamName;
        private System.Windows.Forms.TextBox tbox_Country;
        private System.Windows.Forms.TextBox tbox_City;
        private System.Windows.Forms.TextBox tbox_PlayerName;
        private System.Windows.Forms.TextBox tbox_Number;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.Button btn_AddPlayer;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.ListBox listBox_Player;
    }
}

