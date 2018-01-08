namespace HTC_OEM_Tool
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_board_info = new System.Windows.Forms.GroupBox();
            this.groupBox_mfg = new System.Windows.Forms.GroupBox();
            this.groupBox_misc = new System.Windows.Forms.GroupBox();
            this.button_Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_off_cid = new System.Windows.Forms.Label();
            this.label_off_mid = new System.Windows.Forms.Label();
            this.label_off_sn = new System.Windows.Forms.Label();
            this.label_off_ver = new System.Windows.Forms.Label();
            this.textBox_CID = new System.Windows.Forms.TextBox();
            this.textBox_MID = new System.Windows.Forms.TextBox();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.textBox_VER = new System.Windows.Forms.TextBox();
            this.button_CID = new System.Windows.Forms.Button();
            this.button_MID = new System.Windows.Forms.Button();
            this.button_SN = new System.Windows.Forms.Button();
            this.button_VER = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox_board_info.SuspendLayout();
            this.groupBox_mfg.SuspendLayout();
            this.groupBox_misc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_board_info
            // 
            this.groupBox_board_info.Controls.Add(this.button_CID);
            this.groupBox_board_info.Controls.Add(this.textBox_CID);
            this.groupBox_board_info.Controls.Add(this.label_off_cid);
            this.groupBox_board_info.Controls.Add(this.label1);
            this.groupBox_board_info.Enabled = false;
            this.groupBox_board_info.Location = new System.Drawing.Point(12, 59);
            this.groupBox_board_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_board_info.Name = "groupBox_board_info";
            this.groupBox_board_info.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_board_info.Size = new System.Drawing.Size(360, 70);
            this.groupBox_board_info.TabIndex = 0;
            this.groupBox_board_info.TabStop = false;
            this.groupBox_board_info.Text = "BOARD_INFO";
            // 
            // groupBox_mfg
            // 
            this.groupBox_mfg.Controls.Add(this.button_SN);
            this.groupBox_mfg.Controls.Add(this.button_MID);
            this.groupBox_mfg.Controls.Add(this.textBox_SN);
            this.groupBox_mfg.Controls.Add(this.textBox_MID);
            this.groupBox_mfg.Controls.Add(this.label_off_sn);
            this.groupBox_mfg.Controls.Add(this.label_off_mid);
            this.groupBox_mfg.Controls.Add(this.label3);
            this.groupBox_mfg.Controls.Add(this.label2);
            this.groupBox_mfg.Enabled = false;
            this.groupBox_mfg.Location = new System.Drawing.Point(12, 137);
            this.groupBox_mfg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_mfg.Name = "groupBox_mfg";
            this.groupBox_mfg.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_mfg.Size = new System.Drawing.Size(360, 105);
            this.groupBox_mfg.TabIndex = 1;
            this.groupBox_mfg.TabStop = false;
            this.groupBox_mfg.Text = "MFG";
            // 
            // groupBox_misc
            // 
            this.groupBox_misc.Controls.Add(this.button_VER);
            this.groupBox_misc.Controls.Add(this.textBox_VER);
            this.groupBox_misc.Controls.Add(this.label_off_ver);
            this.groupBox_misc.Controls.Add(this.label4);
            this.groupBox_misc.Enabled = false;
            this.groupBox_misc.Location = new System.Drawing.Point(12, 250);
            this.groupBox_misc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_misc.Name = "groupBox_misc";
            this.groupBox_misc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_misc.Size = new System.Drawing.Size(360, 70);
            this.groupBox_misc.TabIndex = 2;
            this.groupBox_misc.TabStop = false;
            this.groupBox_misc.Text = "MISC";
            // 
            // button_Check
            // 
            this.button_Check.Location = new System.Drawing.Point(12, 12);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(360, 40);
            this.button_Check.TabIndex = 3;
            this.button_Check.TabStop = false;
            this.button_Check.Text = "Check (ROOT, S-OFF, INFO)";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "MID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "VER";
            // 
            // label_off_cid
            // 
            this.label_off_cid.AutoSize = true;
            this.label_off_cid.Location = new System.Drawing.Point(50, 30);
            this.label_off_cid.Name = "label_off_cid";
            this.label_off_cid.Size = new System.Drawing.Size(77, 15);
            this.label_off_cid.TabIndex = 1;
            this.label_off_cid.Text = "0x00000000";
            // 
            // label_off_mid
            // 
            this.label_off_mid.AutoSize = true;
            this.label_off_mid.Location = new System.Drawing.Point(50, 30);
            this.label_off_mid.Name = "label_off_mid";
            this.label_off_mid.Size = new System.Drawing.Size(77, 15);
            this.label_off_mid.TabIndex = 3;
            this.label_off_mid.Text = "0x00000000";
            // 
            // label_off_sn
            // 
            this.label_off_sn.AutoSize = true;
            this.label_off_sn.Location = new System.Drawing.Point(50, 63);
            this.label_off_sn.Name = "label_off_sn";
            this.label_off_sn.Size = new System.Drawing.Size(77, 15);
            this.label_off_sn.TabIndex = 4;
            this.label_off_sn.Text = "0x00000000";
            // 
            // label_off_ver
            // 
            this.label_off_ver.AutoSize = true;
            this.label_off_ver.Location = new System.Drawing.Point(50, 30);
            this.label_off_ver.Name = "label_off_ver";
            this.label_off_ver.Size = new System.Drawing.Size(77, 15);
            this.label_off_ver.TabIndex = 5;
            this.label_off_ver.Text = "0x00000000";
            // 
            // textBox_CID
            // 
            this.textBox_CID.Location = new System.Drawing.Point(150, 27);
            this.textBox_CID.MaxLength = 8;
            this.textBox_CID.Name = "textBox_CID";
            this.textBox_CID.Size = new System.Drawing.Size(100, 23);
            this.textBox_CID.TabIndex = 2;
            this.textBox_CID.TabStop = false;
            // 
            // textBox_MID
            // 
            this.textBox_MID.Location = new System.Drawing.Point(150, 27);
            this.textBox_MID.MaxLength = 9;
            this.textBox_MID.Name = "textBox_MID";
            this.textBox_MID.Size = new System.Drawing.Size(100, 23);
            this.textBox_MID.TabIndex = 5;
            this.textBox_MID.TabStop = false;
            // 
            // textBox_SN
            // 
            this.textBox_SN.Location = new System.Drawing.Point(150, 60);
            this.textBox_SN.MaxLength = 12;
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(100, 23);
            this.textBox_SN.TabIndex = 6;
            this.textBox_SN.TabStop = false;
            // 
            // textBox_VER
            // 
            this.textBox_VER.Location = new System.Drawing.Point(150, 27);
            this.textBox_VER.MaxLength = 12;
            this.textBox_VER.Name = "textBox_VER";
            this.textBox_VER.Size = new System.Drawing.Size(100, 23);
            this.textBox_VER.TabIndex = 7;
            this.textBox_VER.TabStop = false;
            // 
            // button_CID
            // 
            this.button_CID.Location = new System.Drawing.Point(270, 26);
            this.button_CID.Name = "button_CID";
            this.button_CID.Size = new System.Drawing.Size(75, 25);
            this.button_CID.TabIndex = 3;
            this.button_CID.TabStop = false;
            this.button_CID.Text = "Write";
            this.button_CID.UseVisualStyleBackColor = true;
            this.button_CID.Click += new System.EventHandler(this.button_CID_Click);
            // 
            // button_MID
            // 
            this.button_MID.Location = new System.Drawing.Point(270, 26);
            this.button_MID.Name = "button_MID";
            this.button_MID.Size = new System.Drawing.Size(75, 25);
            this.button_MID.TabIndex = 7;
            this.button_MID.TabStop = false;
            this.button_MID.Text = "Write";
            this.button_MID.UseVisualStyleBackColor = true;
            this.button_MID.Click += new System.EventHandler(this.button_MID_Click);
            // 
            // button_SN
            // 
            this.button_SN.Location = new System.Drawing.Point(270, 59);
            this.button_SN.Name = "button_SN";
            this.button_SN.Size = new System.Drawing.Size(75, 25);
            this.button_SN.TabIndex = 8;
            this.button_SN.TabStop = false;
            this.button_SN.Text = "Write";
            this.button_SN.UseVisualStyleBackColor = true;
            this.button_SN.Click += new System.EventHandler(this.button_SN_Click);
            // 
            // button_VER
            // 
            this.button_VER.Location = new System.Drawing.Point(270, 26);
            this.button_VER.Name = "button_VER";
            this.button_VER.Size = new System.Drawing.Size(75, 25);
            this.button_VER.TabIndex = 8;
            this.button_VER.TabStop = false;
            this.button_VER.Text = "Write";
            this.button_VER.UseVisualStyleBackColor = true;
            this.button_VER.Click += new System.EventHandler(this.button_VER_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(12, 327);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(49, 15);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "Status";
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.groupBox_misc);
            this.Controls.Add(this.groupBox_mfg);
            this.Controls.Add(this.groupBox_board_info);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTC OEM Tool";
            this.groupBox_board_info.ResumeLayout(false);
            this.groupBox_board_info.PerformLayout();
            this.groupBox_mfg.ResumeLayout(false);
            this.groupBox_mfg.PerformLayout();
            this.groupBox_misc.ResumeLayout(false);
            this.groupBox_misc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_board_info;
        private System.Windows.Forms.GroupBox groupBox_mfg;
        private System.Windows.Forms.GroupBox groupBox_misc;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_off_cid;
        private System.Windows.Forms.Label label_off_sn;
        private System.Windows.Forms.Label label_off_mid;
        private System.Windows.Forms.Label label_off_ver;
        private System.Windows.Forms.TextBox textBox_CID;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.TextBox textBox_MID;
        private System.Windows.Forms.TextBox textBox_VER;
        private System.Windows.Forms.Button button_CID;
        private System.Windows.Forms.Button button_MID;
        private System.Windows.Forms.Button button_SN;
        private System.Windows.Forms.Button button_VER;
        private System.Windows.Forms.Label label_Status;
    }
}

