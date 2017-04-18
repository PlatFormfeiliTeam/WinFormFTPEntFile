namespace WinFormFTPEntFile
{
    partial class Form_main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_enterprisecode = new System.Windows.Forms.TextBox();
            this.lab_address = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_FILEDECLAREUNIT = new System.Windows.Forms.Label();
            this.lab_delegate = new System.Windows.Forms.Label();
            this.gr_ftpitem = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_sevice = new System.Windows.Forms.Button();
            this.txt_templetename = new System.Windows.Forms.TextBox();
            this.lab_templete = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_declareunitcode = new System.Windows.Forms.TextBox();
            this.txt_declareunitname = new System.Windows.Forms.TextBox();
            this.txt_enterprisename = new System.Windows.Forms.TextBox();
            this.txt_reciveunitcode = new System.Windows.Forms.TextBox();
            this.txt_reciveunitname = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.Column_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gr_ftpitem)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(100, 486);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(180, 21);
            this.txt_address.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(383, 486);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(180, 21);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(646, 486);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(180, 21);
            this.txt_password.TabIndex = 2;
            // 
            // txt_enterprisecode
            // 
            this.txt_enterprisecode.Location = new System.Drawing.Point(100, 583);
            this.txt_enterprisecode.Name = "txt_enterprisecode";
            this.txt_enterprisecode.Size = new System.Drawing.Size(180, 21);
            this.txt_enterprisecode.TabIndex = 3;
            // 
            // lab_address
            // 
            this.lab_address.AutoSize = true;
            this.lab_address.Location = new System.Drawing.Point(38, 489);
            this.lab_address.Name = "lab_address";
            this.lab_address.Size = new System.Drawing.Size(59, 12);
            this.lab_address.TabIndex = 6;
            this.lab_address.Text = "FTP地址：";
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(311, 489);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(71, 12);
            this.lab_username.TabIndex = 7;
            this.lab_username.Text = "FTP用户名：";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(584, 489);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(59, 12);
            this.lab_password.TabIndex = 8;
            this.lab_password.Text = "FTP密码：";
            // 
            // lab_FILEDECLAREUNIT
            // 
            this.lab_FILEDECLAREUNIT.AutoSize = true;
            this.lab_FILEDECLAREUNIT.Location = new System.Drawing.Point(10, 518);
            this.lab_FILEDECLAREUNIT.Name = "lab_FILEDECLAREUNIT";
            this.lab_FILEDECLAREUNIT.Size = new System.Drawing.Size(89, 12);
            this.lab_FILEDECLAREUNIT.TabIndex = 9;
            this.lab_FILEDECLAREUNIT.Text = "文件申报单位：";
            // 
            // lab_delegate
            // 
            this.lab_delegate.AutoSize = true;
            this.lab_delegate.Location = new System.Drawing.Point(31, 586);
            this.lab_delegate.Name = "lab_delegate";
            this.lab_delegate.Size = new System.Drawing.Size(65, 12);
            this.lab_delegate.TabIndex = 11;
            this.lab_delegate.Text = "委托企业：";
            // 
            // gr_ftpitem
            // 
            this.gr_ftpitem.AllowUserToAddRows = false;
            this.gr_ftpitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr_ftpitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_check});
            this.gr_ftpitem.Location = new System.Drawing.Point(12, 41);
            this.gr_ftpitem.Name = "gr_ftpitem";
            this.gr_ftpitem.RowTemplate.Height = 23;
            this.gr_ftpitem.RowTemplate.ReadOnly = true;
            this.gr_ftpitem.Size = new System.Drawing.Size(814, 417);
            this.gr_ftpitem.TabIndex = 12;
            this.gr_ftpitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gr_ftpitem_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(660, 650);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "新增(A)";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(750, 650);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "删除(D)";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_sevice
            // 
            this.btn_sevice.Location = new System.Drawing.Point(274, 12);
            this.btn_sevice.Name = "btn_sevice";
            this.btn_sevice.Size = new System.Drawing.Size(82, 23);
            this.btn_sevice.TabIndex = 15;
            this.btn_sevice.Text = "开启服务(S)";
            this.btn_sevice.UseVisualStyleBackColor = true;
            this.btn_sevice.Click += new System.EventHandler(this.btn_sevice_Click);
            // 
            // txt_templetename
            // 
            this.txt_templetename.Location = new System.Drawing.Point(100, 614);
            this.txt_templetename.Name = "txt_templetename";
            this.txt_templetename.Size = new System.Drawing.Size(726, 21);
            this.txt_templetename.TabIndex = 16;
            // 
            // lab_templete
            // 
            this.lab_templete.AutoSize = true;
            this.lab_templete.Location = new System.Drawing.Point(32, 617);
            this.lab_templete.Name = "lab_templete";
            this.lab_templete.Size = new System.Drawing.Size(65, 12);
            this.lab_templete.TabIndex = 17;
            this.lab_templete.Text = "模板名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "文件接收单位：";
            // 
            // txt_declareunitcode
            // 
            this.txt_declareunitcode.Location = new System.Drawing.Point(100, 515);
            this.txt_declareunitcode.Name = "txt_declareunitcode";
            this.txt_declareunitcode.Size = new System.Drawing.Size(180, 21);
            this.txt_declareunitcode.TabIndex = 24;
            // 
            // txt_declareunitname
            // 
            this.txt_declareunitname.Location = new System.Drawing.Point(313, 515);
            this.txt_declareunitname.Name = "txt_declareunitname";
            this.txt_declareunitname.Size = new System.Drawing.Size(513, 21);
            this.txt_declareunitname.TabIndex = 25;
            // 
            // txt_enterprisename
            // 
            this.txt_enterprisename.Location = new System.Drawing.Point(313, 586);
            this.txt_enterprisename.Name = "txt_enterprisename";
            this.txt_enterprisename.Size = new System.Drawing.Size(513, 21);
            this.txt_enterprisename.TabIndex = 26;
            // 
            // txt_reciveunitcode
            // 
            this.txt_reciveunitcode.Location = new System.Drawing.Point(100, 549);
            this.txt_reciveunitcode.Name = "txt_reciveunitcode";
            this.txt_reciveunitcode.Size = new System.Drawing.Size(180, 21);
            this.txt_reciveunitcode.TabIndex = 24;
            // 
            // txt_reciveunitname
            // 
            this.txt_reciveunitname.Location = new System.Drawing.Point(313, 549);
            this.txt_reciveunitname.Name = "txt_reciveunitname";
            this.txt_reciveunitname.Size = new System.Drawing.Size(513, 21);
            this.txt_reciveunitname.TabIndex = 25;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(362, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(79, 23);
            this.btn_close.TabIndex = 27;
            this.btn_close.Text = "关闭服务(C)";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Column_check
            // 
            this.Column_check.HeaderText = "选择";
            this.Column_check.Name = "Column_check";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 681);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_enterprisename);
            this.Controls.Add(this.txt_reciveunitname);
            this.Controls.Add(this.txt_reciveunitcode);
            this.Controls.Add(this.txt_declareunitname);
            this.Controls.Add(this.txt_declareunitcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_templete);
            this.Controls.Add(this.txt_templetename);
            this.Controls.Add(this.btn_sevice);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.gr_ftpitem);
            this.Controls.Add(this.lab_delegate);
            this.Controls.Add(this.lab_FILEDECLAREUNIT);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.lab_address);
            this.Controls.Add(this.txt_enterprisecode);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_main";
            this.Text = "FTP文件服务";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gr_ftpitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_enterprisecode;
        private System.Windows.Forms.Label lab_address;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_FILEDECLAREUNIT;
        private System.Windows.Forms.Label lab_delegate;
        private System.Windows.Forms.DataGridView gr_ftpitem;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_sevice;
        private System.Windows.Forms.TextBox txt_templetename;
        private System.Windows.Forms.Label lab_templete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_declareunitcode;
        private System.Windows.Forms.TextBox txt_declareunitname;
        private System.Windows.Forms.TextBox txt_enterprisename;
        private System.Windows.Forms.TextBox txt_reciveunitcode;
        private System.Windows.Forms.TextBox txt_reciveunitname;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_check;
    }
}

