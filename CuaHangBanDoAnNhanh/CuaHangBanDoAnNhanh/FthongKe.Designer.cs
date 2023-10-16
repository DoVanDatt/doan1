namespace CuaHangBanDoAnNhanh
{
    partial class FthongKe
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInTK = new System.Windows.Forms.Button();
            this.txtTongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tháng = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDsTk = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtInTK);
            this.groupBox4.Controls.Add(this.txtTongKe);
            this.groupBox4.Location = new System.Drawing.Point(343, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 139);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "xác nhận";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInTK
            // 
            this.txtInTK.Location = new System.Drawing.Point(142, 19);
            this.txtInTK.Name = "txtInTK";
            this.txtInTK.Size = new System.Drawing.Size(99, 53);
            this.txtInTK.TabIndex = 4;
            this.txtInTK.Text = "in thống kê";
            this.txtInTK.UseVisualStyleBackColor = true;
            this.txtInTK.Click += new System.EventHandler(this.txtInTK_Click);
            // 
            // txtTongKe
            // 
            this.txtTongKe.Location = new System.Drawing.Point(20, 19);
            this.txtTongKe.Name = "txtTongKe";
            this.txtTongKe.Size = new System.Drawing.Size(99, 53);
            this.txtTongKe.TabIndex = 0;
            this.txtTongKe.Text = "thống kê";
            this.txtTongKe.UseVisualStyleBackColor = true;
            this.txtTongKe.Click += new System.EventHandler(this.txtTongKe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tháng);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.txtThang);
            this.groupBox1.Location = new System.Drawing.Point(343, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thống kê theo tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nhập đầy đủ cả hai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "năm";
            // 
            // tháng
            // 
            this.tháng.AutoSize = true;
            this.tháng.Location = new System.Drawing.Point(24, 56);
            this.tháng.Name = "tháng";
            this.tháng.Size = new System.Drawing.Size(34, 13);
            this.tháng.TabIndex = 2;
            this.tháng.Text = "tháng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(76, 117);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 1;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(76, 56);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDsTk);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 424);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "danh sách";
            // 
            // dgvDsTk
            // 
            this.dgvDsTk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsTk.Location = new System.Drawing.Point(16, 19);
            this.dgvDsTk.Name = "dgvDsTk";
            this.dgvDsTk.Size = new System.Drawing.Size(303, 387);
            this.dgvDsTk.TabIndex = 0;
            // 
            // FthongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FthongKe";
            this.Text = "FthongKe";
            this.Load += new System.EventHandler(this.FthongKe_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button txtInTK;
        private System.Windows.Forms.Button txtTongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tháng;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDsTk;
        private System.Windows.Forms.Button button1;
    }
}