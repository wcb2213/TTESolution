namespace TTESlution
{
    partial class Form2
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(96, 30);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 21);
            this.txtSpeed.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(96, 83);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 21);
            this.txtHeight.TabIndex = 1;
            // 
            // txtDLongitude
            // 
            this.txtDLongitude.Location = new System.Drawing.Point(96, 245);
            this.txtDLongitude.Name = "txtDLongitude";
            this.txtDLongitude.Size = new System.Drawing.Size(100, 21);
            this.txtDLongitude.TabIndex = 2;
            // 
            // txtDLatitude
            // 
            this.txtDLatitude.Location = new System.Drawing.Point(96, 283);
            this.txtDLatitude.Name = "txtDLatitude";
            this.txtDLatitude.Size = new System.Drawing.Size(100, 21);
            this.txtDLatitude.TabIndex = 3;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 39);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(29, 12);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "速度";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 92);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(29, 12);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "高度";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(13, 143);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(65, 12);
            this.lblLongitude.TabIndex = 6;
            this.lblLongitude.Text = "发射点经度";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(12, 195);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(65, 12);
            this.lblLatitude.TabIndex = 7;
            this.lblLatitude.Text = "发射点纬度";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(96, 390);
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
            this.lblDesLongitude.Location = new System.Drawing.Point(12, 248);
            this.lblDesLongitude.Name = "lblDesLongitude";
            this.lblDesLongitude.Size = new System.Drawing.Size(65, 12);
            this.lblDesLongitude.TabIndex = 9;
            this.lblDesLongitude.Text = "目的点经度";
            // 
            // lblDesLatitude
            // 
            this.lblDesLatitude.AutoSize = true;
            this.lblDesLatitude.Location = new System.Drawing.Point(12, 292);
            this.lblDesLatitude.Name = "lblDesLatitude";
            this.lblDesLatitude.Size = new System.Drawing.Size(65, 12);
            this.lblDesLatitude.TabIndex = 10;
            this.lblDesLatitude.Text = "目的点纬度";
            // 
            // txtSLongitude
            // 
            this.txtSLongitude.Location = new System.Drawing.Point(96, 140);
            this.txtSLongitude.Name = "txtSLongitude";
            this.txtSLongitude.Size = new System.Drawing.Size(100, 21);
            this.txtSLongitude.TabIndex = 11;
            // 
            // txtSLatitude
            // 
            this.txtSLatitude.Location = new System.Drawing.Point(96, 192);
            this.txtSLatitude.Name = "txtSLatitude";
            this.txtSLatitude.Size = new System.Drawing.Size(100, 21);
            this.txtSLatitude.TabIndex = 12;
            // 
            // dgvDisp
            // 
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(355, 30);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.RowTemplate.Height = 23;
            this.dgvDisp.Size = new System.Drawing.Size(340, 416);
            this.dgvDisp.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 492);
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
            this.Name = "Form2";
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
    }
}