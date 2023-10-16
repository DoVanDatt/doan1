namespace CuaHangBanDoAnNhanh
{
    partial class FmonAn
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
            this.components = new System.ComponentModel.Container();
            this.ccbDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnThemDm = new System.Windows.Forms.Button();
            this.btnSuaDm = new System.Windows.Forms.Button();
            this.btnXoaDm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvmonAn = new System.Windows.Forms.DataGridView();
            this.themMonAn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tHÊMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sỬAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xÓAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonAn)).BeginInit();
            this.themMonAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // ccbDanhMuc
            // 
            this.ccbDanhMuc.FormattingEnabled = true;
            this.ccbDanhMuc.Items.AddRange(new object[] {
            "TẤT CẢ"});
            this.ccbDanhMuc.Location = new System.Drawing.Point(6, 35);
            this.ccbDanhMuc.Name = "ccbDanhMuc";
            this.ccbDanhMuc.Size = new System.Drawing.Size(164, 21);
            this.ccbDanhMuc.TabIndex = 0;
            this.ccbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.ccbDanhMuc_SelectedIndexChanged);
            // 
            // btnThemDm
            // 
            this.btnThemDm.Location = new System.Drawing.Point(176, 33);
            this.btnThemDm.Name = "btnThemDm";
            this.btnThemDm.Size = new System.Drawing.Size(75, 23);
            this.btnThemDm.TabIndex = 1;
            this.btnThemDm.Text = "THÊM";
            this.btnThemDm.UseVisualStyleBackColor = true;
            this.btnThemDm.Click += new System.EventHandler(this.btnThemDm_Click);
            // 
            // btnSuaDm
            // 
            this.btnSuaDm.Location = new System.Drawing.Point(257, 33);
            this.btnSuaDm.Name = "btnSuaDm";
            this.btnSuaDm.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDm.TabIndex = 2;
            this.btnSuaDm.Text = "SỬA";
            this.btnSuaDm.UseVisualStyleBackColor = true;
            this.btnSuaDm.Click += new System.EventHandler(this.btnSuaDm_Click);
            // 
            // btnXoaDm
            // 
            this.btnXoaDm.Location = new System.Drawing.Point(338, 33);
            this.btnXoaDm.Name = "btnXoaDm";
            this.btnXoaDm.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDm.TabIndex = 3;
            this.btnXoaDm.Text = "XÓA";
            this.btnXoaDm.UseVisualStyleBackColor = true;
            this.btnXoaDm.Click += new System.EventHandler(this.btnXoaDm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaDm);
            this.groupBox1.Controls.Add(this.ccbDanhMuc);
            this.groupBox1.Controls.Add(this.btnSuaDm);
            this.groupBox1.Controls.Add(this.btnThemDm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvmonAn);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 286);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Món ăn";
            // 
            // dgvmonAn
            // 
            this.dgvmonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmonAn.ContextMenuStrip = this.themMonAn;
            this.dgvmonAn.Location = new System.Drawing.Point(0, 33);
            this.dgvmonAn.Name = "dgvmonAn";
            this.dgvmonAn.Size = new System.Drawing.Size(394, 247);
            this.dgvmonAn.TabIndex = 0;
            this.dgvmonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmonAn_CellClick);
            // 
            // themMonAn
            // 
            this.themMonAn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHÊMToolStripMenuItem,
            this.sỬAToolStripMenuItem,
            this.xÓAToolStripMenuItem});
            this.themMonAn.Name = "themMonAn";
            this.themMonAn.Size = new System.Drawing.Size(181, 92);
            this.themMonAn.Opening += new System.ComponentModel.CancelEventHandler(this.themMonAn_Opening);
            // 
            // tHÊMToolStripMenuItem
            // 
            this.tHÊMToolStripMenuItem.Name = "tHÊMToolStripMenuItem";
            this.tHÊMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tHÊMToolStripMenuItem.Text = "THÊM";
            this.tHÊMToolStripMenuItem.Click += new System.EventHandler(this.tHÊMToolStripMenuItem_Click);
            // 
            // sỬAToolStripMenuItem
            // 
            this.sỬAToolStripMenuItem.Name = "sỬAToolStripMenuItem";
            this.sỬAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sỬAToolStripMenuItem.Text = "SỬA";
            this.sỬAToolStripMenuItem.Click += new System.EventHandler(this.sỬAToolStripMenuItem_Click);
            // 
            // xÓAToolStripMenuItem
            // 
            this.xÓAToolStripMenuItem.Name = "xÓAToolStripMenuItem";
            this.xÓAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xÓAToolStripMenuItem.Text = "XÓA";
            this.xÓAToolStripMenuItem.Click += new System.EventHandler(this.xÓAToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmonAn";
            this.Text = "FmonAn";
            this.Load += new System.EventHandler(this.FmonAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmonAn)).EndInit();
            this.themMonAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ccbDanhMuc;
        private System.Windows.Forms.Button btnThemDm;
        private System.Windows.Forms.Button btnSuaDm;
        private System.Windows.Forms.Button btnXoaDm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvmonAn;
        private System.Windows.Forms.ContextMenuStrip themMonAn;
        private System.Windows.Forms.ToolStripMenuItem tHÊMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sỬAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xÓAToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
    }
}