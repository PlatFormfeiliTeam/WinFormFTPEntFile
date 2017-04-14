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
            this.txt_delegate = new System.Windows.Forms.TextBox();
            this.cbo_declare = new System.Windows.Forms.ComboBox();
            this.cbo_recive = new System.Windows.Forms.ComboBox();
            this.lab_address = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_password = new System.Windows.Forms.Label();
            this.lab_FILEDECLAREUNIT = new System.Windows.Forms.Label();
            this.lab_FILERECEVIEUNIT = new System.Windows.Forms.Label();
            this.lab_delegate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_sevice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(96, 12);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(180, 21);
            this.txt_address.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(379, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(180, 21);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(642, 12);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(180, 21);
            this.txt_password.TabIndex = 2;
            // 
            // txt_delegate
            // 
            this.txt_delegate.Location = new System.Drawing.Point(642, 41);
            this.txt_delegate.Name = "txt_delegate";
            this.txt_delegate.Size = new System.Drawing.Size(180, 21);
            this.txt_delegate.TabIndex = 3;
            // 
            // cbo_declare
            // 
            this.cbo_declare.FormattingEnabled = true;
            this.cbo_declare.Location = new System.Drawing.Point(96, 41);
            this.cbo_declare.Name = "cbo_declare";
            this.cbo_declare.Size = new System.Drawing.Size(180, 20);
            this.cbo_declare.TabIndex = 4;
            // 
            // cbo_recive
            // 
            this.cbo_recive.FormattingEnabled = true;
            this.cbo_recive.Location = new System.Drawing.Point(379, 41);
            this.cbo_recive.Name = "cbo_recive";
            this.cbo_recive.Size = new System.Drawing.Size(180, 20);
            this.cbo_recive.TabIndex = 5;
            // 
            // lab_address
            // 
            this.lab_address.AutoSize = true;
            this.lab_address.Location = new System.Drawing.Point(34, 15);
            this.lab_address.Name = "lab_address";
            this.lab_address.Size = new System.Drawing.Size(59, 12);
            this.lab_address.TabIndex = 6;
            this.lab_address.Text = "FTP地址：";
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(307, 15);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(71, 12);
            this.lab_username.TabIndex = 7;
            this.lab_username.Text = "FTP用户名：";
            // 
            // lab_password
            // 
            this.lab_password.AutoSize = true;
            this.lab_password.Location = new System.Drawing.Point(580, 15);
            this.lab_password.Name = "lab_password";
            this.lab_password.Size = new System.Drawing.Size(59, 12);
            this.lab_password.TabIndex = 8;
            this.lab_password.Text = "FTP密码：";
            // 
            // lab_FILEDECLAREUNIT
            // 
            this.lab_FILEDECLAREUNIT.AutoSize = true;
            this.lab_FILEDECLAREUNIT.Location = new System.Drawing.Point(6, 44);
            this.lab_FILEDECLAREUNIT.Name = "lab_FILEDECLAREUNIT";
            this.lab_FILEDECLAREUNIT.Size = new System.Drawing.Size(89, 12);
            this.lab_FILEDECLAREUNIT.TabIndex = 9;
            this.lab_FILEDECLAREUNIT.Text = "文件申报单位：";
            // 
            // lab_FILERECEVIEUNIT
            // 
            this.lab_FILERECEVIEUNIT.AutoSize = true;
            this.lab_FILERECEVIEUNIT.Location = new System.Drawing.Point(288, 44);
            this.lab_FILERECEVIEUNIT.Name = "lab_FILERECEVIEUNIT";
            this.lab_FILERECEVIEUNIT.Size = new System.Drawing.Size(89, 12);
            this.lab_FILERECEVIEUNIT.TabIndex = 10;
            this.lab_FILERECEVIEUNIT.Text = "文件接受单位：";
            // 
            // lab_delegate
            // 
            this.lab_delegate.AutoSize = true;
            this.lab_delegate.Location = new System.Drawing.Point(575, 44);
            this.lab_delegate.Name = "lab_delegate";
            this.lab_delegate.Size = new System.Drawing.Size(65, 12);
            this.lab_delegate.TabIndex = 11;
            this.lab_delegate.Text = "委托企业：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(814, 304);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(568, 79);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "新增(A)";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(658, 79);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "删除(D)";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_sevice
            // 
            this.btn_sevice.Location = new System.Drawing.Point(747, 79);
            this.btn_sevice.Name = "btn_sevice";
            this.btn_sevice.Size = new System.Drawing.Size(75, 23);
            this.btn_sevice.TabIndex = 15;
            this.btn_sevice.Text = "开启服务(S)";
            this.btn_sevice.UseVisualStyleBackColor = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 475);
            this.Controls.Add(this.btn_sevice);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lab_delegate);
            this.Controls.Add(this.lab_FILERECEVIEUNIT);
            this.Controls.Add(this.lab_FILEDECLAREUNIT);
            this.Controls.Add(this.lab_password);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.lab_address);
            this.Controls.Add(this.cbo_recive);
            this.Controls.Add(this.cbo_declare);
            this.Controls.Add(this.txt_delegate);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_address);
            this.Name = "Form_main";
            this.Text = "FTP文件服务";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_delegate;
        private System.Windows.Forms.ComboBox cbo_declare;
        private System.Windows.Forms.ComboBox cbo_recive;
        private System.Windows.Forms.Label lab_address;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_password;
        private System.Windows.Forms.Label lab_FILEDECLAREUNIT;
        private System.Windows.Forms.Label lab_FILERECEVIEUNIT;
        private System.Windows.Forms.Label lab_delegate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_sevice;
    }
}

