namespace TTESlution
{
    partial class Form4
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
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtDLongitude = new System.Windows.Forms.TextBox();
            this.txtDLatitude = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDesLongitude = new System.Windows.Forms.Label();
            this.lblDesLatitude = new System.Windows.Forms.Label();
            this.txtSLongitude = new System.Windows.Forms.TextBox();
            this.txtSLatitude = new System.Windows.Forms.TextBox();
            this.dgvDisp = new System.Windows.Forms.DataGridView();
            this.database1 = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_time1 = new System.Windows.Forms.TextBox();
            this.txt_time2 = new System.Windows.Forms.TextBox();
            this.txt_time3 = new System.Windows.Forms.TextBox();
            this.btn_save_para = new System.Windows.Forms.Button();
            this.btn_load_para = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(104, 187);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 21);
            this.txtSpeed.TabIndex = 0;
            this.txtSpeed.Text = "200";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(104, 224);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 21);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "4000";
            // 
            // txtDLongitude
            // 
            this.txtDLongitude.Location = new System.Drawing.Point(104, 377);
            this.txtDLongitude.Name = "txtDLongitude";
            this.txtDLongitude.Size = new System.Drawing.Size(100, 21);
            this.txtDLongitude.TabIndex = 2;
            this.txtDLongitude.Text = "120";
            // 
            // txtDLatitude
            // 
            this.txtDLatitude.Location = new System.Drawing.Point(104, 430);
            this.txtDLatitude.Name = "txtDLatitude";
            this.txtDLatitude.Size = new System.Drawing.Size(100, 21);
            this.txtDLatitude.TabIndex = 3;
            this.txtDLatitude.Text = "30";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 191);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(29, 12);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "速度";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 225);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(29, 12);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "高度";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(12, 276);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(65, 12);
            this.lblLongitude.TabIndex = 6;
            this.lblLongitude.Text = "发射点经度";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(11, 328);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(65, 12);
            this.lblLatitude.TabIndex = 7;
            this.lblLatitude.Text = "发射点纬度";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(61, 475);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDesLongitude
            // 
            this.lblDesLongitude.AutoSize = true;
            this.lblDesLongitude.Location = new System.Drawing.Point(11, 381);
            this.lblDesLongitude.Name = "lblDesLongitude";
            this.lblDesLongitude.Size = new System.Drawing.Size(65, 12);
            this.lblDesLongitude.TabIndex = 9;
            this.lblDesLongitude.Text = "目的点经度";
            // 
            // lblDesLatitude
            // 
            this.lblDesLatitude.AutoSize = true;
            this.lblDesLatitude.Location = new System.Drawing.Point(11, 434);
            this.lblDesLatitude.Name = "lblDesLatitude";
            this.lblDesLatitude.Size = new System.Drawing.Size(65, 12);
            this.lblDesLatitude.TabIndex = 10;
            this.lblDesLatitude.Text = "目的点纬度";
            // 
            // txtSLongitude
            // 
            this.txtSLongitude.Location = new System.Drawing.Point(104, 272);
            this.txtSLongitude.Name = "txtSLongitude";
            this.txtSLongitude.Size = new System.Drawing.Size(100, 21);
            this.txtSLongitude.TabIndex = 11;
            this.txtSLongitude.Text = "117";
            // 
            // txtSLatitude
            // 
            this.txtSLatitude.Location = new System.Drawing.Point(104, 324);
            this.txtSLatitude.Name = "txtSLatitude";
            this.txtSLatitude.Size = new System.Drawing.Size(100, 21);
            this.txtSLatitude.TabIndex = 12;
            this.txtSLatitude.Text = "40";
            // 
            // dgvDisp
            // 
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(277, 21);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.RowTemplate.Height = 23;
            this.dgvDisp.Size = new System.Drawing.Size(831, 662);
            this.dgvDisp.TabIndex = 13;
            // 
            // database1
            // 
            this.database1.Location = new System.Drawing.Point(104, 38);
            this.database1.Name = "database1";
            this.database1.Size = new System.Drawing.Size(100, 21);
            this.database1.TabIndex = 14;
            this.database1.Text = "tx1";
            // 
            // database
            // 
            this.database.AutoSize = true;
            this.database.Location = new System.Drawing.Point(12, 47);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(53, 12);
            this.database.TabIndex = 15;
            this.database.Text = "database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "等待时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "上升（下降）时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "平飞时间";
            // 
            // txt_time1
            // 
            this.txt_time1.Location = new System.Drawing.Point(104, 82);
            this.txt_time1.Name = "txt_time1";
            this.txt_time1.Size = new System.Drawing.Size(100, 21);
            this.txt_time1.TabIndex = 14;
            this.txt_time1.Text = "10";
            // 
            // txt_time2
            // 
            this.txt_time2.Location = new System.Drawing.Point(104, 111);
            this.txt_time2.Name = "txt_time2";
            this.txt_time2.Size = new System.Drawing.Size(100, 21);
            this.txt_time2.TabIndex = 14;
            this.txt_time2.Text = "50";
            // 
            // txt_time3
            // 
            this.txt_time3.Location = new System.Drawing.Point(104, 142);
            this.txt_time3.Name = "txt_time3";
            this.txt_time3.Size = new System.Drawing.Size(100, 21);
            this.txt_time3.TabIndex = 14;
            this.txt_time3.Text = "250";
            // 
            // btn_save_para
            // 
            this.btn_save_para.Location = new System.Drawing.Point(141, 551);
            this.btn_save_para.Name = "btn_save_para";
            this.btn_save_para.Size = new System.Drawing.Size(75, 23);
            this.btn_save_para.TabIndex = 19;
            this.btn_save_para.Text = "保存参数";
            this.btn_save_para.UseVisualStyleBackColor = true;
            this.btn_save_para.Click += new System.EventHandler(this.btn_save_para_Click);
            // 
            // btn_load_para
            // 
            this.btn_load_para.Location = new System.Drawing.Point(141, 589);
            this.btn_load_para.Name = "btn_load_para";
            this.btn_load_para.Size = new System.Drawing.Size(75, 23);
            this.btn_load_para.TabIndex = 19;
            this.btn_load_para.Text = "载入参数";
            this.btn_load_para.UseVisualStyleBackColor = true;
            this.btn_load_para.Click += new System.EventHandler(this.btn_load_para_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 723);
            this.Controls.Add(this.btn_load_para);
            this.Controls.Add(this.btn_save_para);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.database);
            this.Controls.Add(this.txt_time3);
            this.Controls.Add(this.txt_time2);
            this.Controls.Add(this.txt_time1);
            this.Controls.Add(this.database1);
            this.Controls.Add(this.dgvDisp);
            this.Controls.Add(this.txtSLatitude);
            this.Controls.Add(this.txtSLongitude);
            this.Controls.Add(this.lblDesLatitude);
            this.Controls.Add(this.lblDesLongitude);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtDLatitude);
            this.Controls.Add(this.txtDLongitude);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtSpeed);
            this.Name = "Form4";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtDLongitude;
        private System.Windows.Forms.TextBox txtDLatitude;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDesLongitude;
        private System.Windows.Forms.Label lblDesLatitude;
        private System.Windows.Forms.TextBox txtSLongitude;
        private System.Windows.Forms.TextBox txtSLatitude;
        private System.Windows.Forms.DataGridView dgvDisp;
        private System.Windows.Forms.TextBox database1;
        private System.Windows.Forms.Label database;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_time1;
        private System.Windows.Forms.TextBox txt_time2;
        private System.Windows.Forms.TextBox txt_time3;
        private System.Windows.Forms.Button btn_save_para;
        private System.Windows.Forms.Button btn_load_para;
    }
}