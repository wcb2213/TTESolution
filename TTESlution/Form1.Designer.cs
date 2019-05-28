namespace TTESlution
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDISP = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDisp = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstModifyLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 537);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加数据";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelect
            // 
            this.btnDelect.Location = new System.Drawing.Point(272, 537);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(94, 23);
            this.btnDelect.TabIndex = 1;
            this.btnDelect.Text = "删除数据";
            this.btnDelect.UseVisualStyleBackColor = true;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(403, 537);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(94, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改数据";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDISP
            // 
            this.btnDISP.Location = new System.Drawing.Point(690, 493);
            this.btnDISP.Name = "btnDISP";
            this.btnDISP.Size = new System.Drawing.Size(99, 32);
            this.btnDISP.TabIndex = 3;
            this.btnDISP.Text = "显示表格";
            this.btnDISP.UseVisualStyleBackColor = true;
            this.btnDISP.Click += new System.EventHandler(this.btnDISP_Click);
            // 
            // dgvDisp
            // 
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(530, 33);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.RowTemplate.Height = 23;
            this.dgvDisp.Size = new System.Drawing.Size(376, 412);
            this.dgvDisp.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 461);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(118, 21);
            this.txtID.TabIndex = 5;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(352, 461);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(122, 21);
            this.txtSpeed.TabIndex = 6;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(168, 493);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(118, 21);
            this.txtX.TabIndex = 7;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(352, 493);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(122, 21);
            this.txtY.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y";
            // 
            // lstModifyLog
            // 
            this.lstModifyLog.FormattingEnabled = true;
            this.lstModifyLog.ItemHeight = 12;
            this.lstModifyLog.Location = new System.Drawing.Point(126, 33);
            this.lstModifyLog.Name = "lstModifyLog";
            this.lstModifyLog.Size = new System.Drawing.Size(364, 412);
            this.lstModifyLog.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 652);
            this.Controls.Add(this.lstModifyLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvDisp);
            this.Controls.Add(this.btnDISP);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelect);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDISP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvDisp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstModifyLog;
    }
}

