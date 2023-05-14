namespace VanPhap.View
{
    partial class NguoiNhanCauAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiNhanCauAn));
            this.txt_id_so = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_sao = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_Sao = new System.Windows.Forms.Label();
            this.lbl_tuoi = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox_NamSinh = new System.Windows.Forms.ComboBox();
            this.txt_tuoiii = new System.Windows.Forms.TextBox();
            this.txt_id_kiemtra = new System.Windows.Forms.TextBox();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Tuoi = new System.Windows.Forms.TextBox();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id_so
            // 
            this.txt_id_so.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_so.Location = new System.Drawing.Point(370, 18);
            this.txt_id_so.Name = "txt_id_so";
            this.txt_id_so.Size = new System.Drawing.Size(10, 35);
            this.txt_id_so.TabIndex = 30;
            this.txt_id_so.TabStop = false;
            this.txt_id_so.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(9, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(84, 27);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Họ Tên";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(129, 18);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(230, 35);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_sao
            // 
            this.txt_sao.BackColor = System.Drawing.SystemColors.Control;
            this.txt_sao.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_sao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sao.Location = new System.Drawing.Point(508, 105);
            this.txt_sao.Name = "txt_sao";
            this.txt_sao.ReadOnly = true;
            this.txt_sao.Size = new System.Drawing.Size(230, 35);
            this.txt_sao.TabIndex = 5;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(405, 20);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(97, 27);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_Sao
            // 
            this.lbl_Sao.AutoSize = true;
            this.lbl_Sao.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Sao.Location = new System.Drawing.Point(405, 109);
            this.lbl_Sao.Name = "lbl_Sao";
            this.lbl_Sao.Size = new System.Drawing.Size(47, 27);
            this.lbl_Sao.TabIndex = 15;
            this.lbl_Sao.Text = "Sao";
            this.lbl_Sao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_tuoi
            // 
            this.lbl_tuoi.AutoSize = true;
            this.lbl_tuoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tuoi.Location = new System.Drawing.Point(405, 65);
            this.lbl_tuoi.Name = "lbl_tuoi";
            this.lbl_tuoi.Size = new System.Drawing.Size(55, 27);
            this.lbl_tuoi.TabIndex = 13;
            this.lbl_tuoi.Text = "Tuổi";
            this.lbl_tuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(9, 109);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(103, 27);
            this.lbl_Birthday.TabIndex = 12;
            this.lbl_Birthday.Text = "Năm sinh";
            this.lbl_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(9, 65);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(114, 27);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(129, 61);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(230, 35);
            this.txt_nickname.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(2, "delete-icon.png");
            this.imageList1.Images.SetKeyName(3, "Pencil-icon.png");
            this.imageList1.Images.SetKeyName(4, "search-icon.png");
            this.imageList1.Images.SetKeyName(5, "guide_icon.png");
            this.imageList1.Images.SetKeyName(6, "confirm_icon.png");
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(354, 18);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(10, 35);
            this.txt_id.TabIndex = 35;
            this.txt_id.TabStop = false;
            this.txt_id.Visible = false;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.txt_Tuoi);
            this.pnl_Form.Controls.Add(this.comboBox1);
            this.pnl_Form.Controls.Add(this.comboBox_NamSinh);
            this.pnl_Form.Controls.Add(this.txt_tuoiii);
            this.pnl_Form.Controls.Add(this.txt_id_kiemtra);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Controls.Add(this.txt_sao);
            this.pnl_Form.Controls.Add(this.txt_id);
            this.pnl_Form.Controls.Add(this.lbl_sex);
            this.pnl_Form.Controls.Add(this.txt_id_so);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.lbl_Sao);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.lbl_tuoi);
            this.pnl_Form.Controls.Add(this.lbl_Birthday);
            this.pnl_Form.Location = new System.Drawing.Point(12, 12);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(760, 167);
            this.pnl_Form.TabIndex = 66;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953"});
            this.comboBox1.Location = new System.Drawing.Point(508, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 35);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.Text = "Chọn năm sinh";
            // 
            // comboBox_NamSinh
            // 
            this.comboBox_NamSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_NamSinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_NamSinh.FormattingEnabled = true;
            this.comboBox_NamSinh.Items.AddRange(new object[] {
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953"});
            this.comboBox_NamSinh.Location = new System.Drawing.Point(129, 105);
            this.comboBox_NamSinh.Name = "comboBox_NamSinh";
            this.comboBox_NamSinh.Size = new System.Drawing.Size(230, 35);
            this.comboBox_NamSinh.TabIndex = 41;
            this.comboBox_NamSinh.Text = "Chọn năm sinh";
            // 
            // txt_tuoiii
            // 
            this.txt_tuoiii.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoiii.Location = new System.Drawing.Point(386, 18);
            this.txt_tuoiii.Name = "txt_tuoiii";
            this.txt_tuoiii.Size = new System.Drawing.Size(10, 35);
            this.txt_tuoiii.TabIndex = 37;
            this.txt_tuoiii.TabStop = false;
            this.txt_tuoiii.Visible = false;
            // 
            // txt_id_kiemtra
            // 
            this.txt_id_kiemtra.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_kiemtra.Location = new System.Drawing.Point(338, 18);
            this.txt_id_kiemtra.Name = "txt_id_kiemtra";
            this.txt_id_kiemtra.Size = new System.Drawing.Size(10, 35);
            this.txt_id_kiemtra.TabIndex = 36;
            this.txt_id_kiemtra.TabStop = false;
            this.txt_id_kiemtra.Visible = false;
            this.txt_id_kiemtra.TextChanged += new System.EventHandler(this.txt_id_kiemtra_TextChanged);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_xacnhan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xacnhan.ImageKey = "confirm_icon.png";
            this.btn_xacnhan.ImageList = this.imageList1;
            this.btn_xacnhan.Location = new System.Drawing.Point(226, 188);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_xacnhan.Size = new System.Drawing.Size(131, 40);
            this.btn_xacnhan.TabIndex = 4;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xacnhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.ImageKey = "285657_floppy_guardar_save_icon.png";
            this.btn_Add.ImageList = this.icon;
            this.btn_Add.Location = new System.Drawing.Point(429, 188);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Add.Size = new System.Drawing.Size(130, 40);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Lưu";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Tuoi
            // 
            this.txt_Tuoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Tuoi.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Tuoi.Enabled = false;
            this.txt_Tuoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tuoi.Location = new System.Drawing.Point(508, 61);
            this.txt_Tuoi.Name = "txt_Tuoi";
            this.txt_Tuoi.Size = new System.Drawing.Size(230, 35);
            this.txt_Tuoi.TabIndex = 43;
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "find_icon.png");
            this.icon.Images.SetKeyName(1, "find_icon1.png");
            this.icon.Images.SetKeyName(2, "computer_icon.png");
            this.icon.Images.SetKeyName(3, "add-icon.png");
            this.icon.Images.SetKeyName(4, "delete-icon.png");
            this.icon.Images.SetKeyName(5, "Pencil-icon.png");
            this.icon.Images.SetKeyName(6, "search-icon.png");
            this.icon.Images.SetKeyName(7, "285657_floppy_guardar_save_icon.png");
            // 
            // NguoiNhanCauAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(781, 240);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.btn_Add);
            this.Name = "NguoiNhanCauAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người nhận cầu an";
            this.Load += new System.EventHandler(this.NguoiNhanCauAn_Load);
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id_so;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_sao;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_Sao;
        private System.Windows.Forms.Label lbl_tuoi;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.TextBox txt_id_kiemtra;
        private System.Windows.Forms.TextBox txt_tuoiii;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox_NamSinh;
        private System.Windows.Forms.TextBox txt_Tuoi;
        private System.Windows.Forms.ImageList icon;
    }
}