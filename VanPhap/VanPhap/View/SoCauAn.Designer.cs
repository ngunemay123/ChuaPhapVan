namespace VanPhap.View
{
    partial class SoCauAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoCauAn));
            this.lbl_PhieuDiemThongTin = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lsv_danhsach_cauan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.lbl_List = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_idchubai = new System.Windows.Forms.TextBox();
            this.txt_loaiso = new System.Windows.Forms.TextBox();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_nguyenquan = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_nguyenquan = new System.Windows.Forms.Label();
            this.btn_ThemSo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_List.SuspendLayout();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PhieuDiemThongTin
            // 
            this.lbl_PhieuDiemThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_PhieuDiemThongTin.AutoSize = true;
            this.lbl_PhieuDiemThongTin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuDiemThongTin.Location = new System.Drawing.Point(21, 17);
            this.lbl_PhieuDiemThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PhieuDiemThongTin.Name = "lbl_PhieuDiemThongTin";
            this.lbl_PhieuDiemThongTin.Size = new System.Drawing.Size(250, 31);
            this.lbl_PhieuDiemThongTin.TabIndex = 101;
            this.lbl_PhieuDiemThongTin.Text = "Phiếu điền thông tin";
            this.lbl_PhieuDiemThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.imageList1.Images.SetKeyName(6, "reload_icon.png");
            this.imageList1.Images.SetKeyName(7, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(8, "bin.png");
            this.imageList1.Images.SetKeyName(9, "bin.png");
            this.imageList1.Images.SetKeyName(10, "print_48_icon.png");
            // 
            // pnl_List
            // 
            this.pnl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_List.Controls.Add(this.lsv_danhsach_cauan);
            this.pnl_List.Location = new System.Drawing.Point(11, 314);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(910, 288);
            this.pnl_List.TabIndex = 102;
            // 
            // lsv_danhsach_cauan
            // 
            this.lsv_danhsach_cauan.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lsv_danhsach_cauan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_danhsach_cauan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsv_danhsach_cauan.CheckBoxes = true;
            this.lsv_danhsach_cauan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11});
            this.lsv_danhsach_cauan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_danhsach_cauan.FullRowSelect = true;
            this.lsv_danhsach_cauan.GridLines = true;
            this.lsv_danhsach_cauan.HideSelection = false;
            this.lsv_danhsach_cauan.Location = new System.Drawing.Point(0, 0);
            this.lsv_danhsach_cauan.Margin = new System.Windows.Forms.Padding(2);
            this.lsv_danhsach_cauan.Name = "lsv_danhsach_cauan";
            this.lsv_danhsach_cauan.Size = new System.Drawing.Size(910, 288);
            this.lsv_danhsach_cauan.TabIndex = 103;
            this.lsv_danhsach_cauan.UseCompatibleStateImageBehavior = false;
            this.lsv_danhsach_cauan.View = System.Windows.Forms.View.Details;
            this.lsv_danhsach_cauan.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pháp danh";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm sinh";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tuổi";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sao";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "IDSo";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 115;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Năm mất";
            this.columnHeader11.Width = 120;
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
            // 
            // lbl_List
            // 
            this.lbl_List.AutoSize = true;
            this.lbl_List.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List.Location = new System.Drawing.Point(18, 277);
            this.lbl_List.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_List.Name = "lbl_List";
            this.lbl_List.Size = new System.Drawing.Size(361, 31);
            this.lbl_List.TabIndex = 104;
            this.lbl_List.Text = "Danh sách người nhận cầu an";
            this.lbl_List.Click += new System.EventHandler(this.lbl_List_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.ImageIndex = 8;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(932, 430);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Delete.Size = new System.Drawing.Size(130, 40);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.ImageIndex = 3;
            this.btn_Update.ImageList = this.imageList1;
            this.btn_Update.Location = new System.Drawing.Point(932, 373);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Update.Size = new System.Drawing.Size(130, 40);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(932, 315);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Add.Size = new System.Drawing.Size(130, 40);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.MouseLeave += new System.EventHandler(this.btn_Add_MouseLeave);
            this.btn_Add.MouseHover += new System.EventHandler(this.btn_Add_MouseHover);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.ImageIndex = 10;
            this.btn_print.ImageList = this.imageList1;
            this.btn_print.Location = new System.Drawing.Point(932, 484);
            this.btn_print.Margin = new System.Windows.Forms.Padding(0);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_print.Size = new System.Drawing.Size(130, 40);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "In sớ";
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_nickname
            // 
            this.txt_nickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nickname.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(25, 132);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.ReadOnly = true;
            this.txt_nickname.Size = new System.Drawing.Size(399, 35);
            this.txt_nickname.TabIndex = 2;
            this.txt_nickname.TextChanged += new System.EventHandler(this.txt_nickname_TextChanged);
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(20, 101);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(114, 27);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(25, 48);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(399, 35);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(20, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(87, 27);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Chủ bái";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(932, 197);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(96, 35);
            this.txt_id.TabIndex = 30;
            this.txt_id.TabStop = false;
            this.txt_id.Text = " ";
            // 
            // txt_idchubai
            // 
            this.txt_idchubai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idchubai.Location = new System.Drawing.Point(932, 238);
            this.txt_idchubai.Name = "txt_idchubai";
            this.txt_idchubai.Size = new System.Drawing.Size(96, 35);
            this.txt_idchubai.TabIndex = 31;
            this.txt_idchubai.TabStop = false;
            // 
            // txt_loaiso
            // 
            this.txt_loaiso.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loaiso.Location = new System.Drawing.Point(932, 151);
            this.txt_loaiso.Name = "txt_loaiso";
            this.txt_loaiso.ReadOnly = true;
            this.txt_loaiso.Size = new System.Drawing.Size(96, 35);
            this.txt_loaiso.TabIndex = 101;
            this.txt_loaiso.TabStop = false;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Form.Controls.Add(this.lbl_diachi);
            this.pnl_Form.Controls.Add(this.txt_nguyenquan);
            this.pnl_Form.Controls.Add(this.txt_diachi);
            this.pnl_Form.Controls.Add(this.lbl_nguyenquan);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Form.Location = new System.Drawing.Point(12, 57);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(910, 204);
            this.pnl_Form.TabIndex = 31;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(484, 17);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(81, 27);
            this.lbl_diachi.TabIndex = 107;
            this.lbl_diachi.Text = "Địa chỉ";
            this.lbl_diachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nguyenquan
            // 
            this.txt_nguyenquan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nguyenquan.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nguyenquan.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguyenquan.Location = new System.Drawing.Point(484, 132);
            this.txt_nguyenquan.Name = "txt_nguyenquan";
            this.txt_nguyenquan.ReadOnly = true;
            this.txt_nguyenquan.Size = new System.Drawing.Size(404, 35);
            this.txt_nguyenquan.TabIndex = 105;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_diachi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_diachi.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(484, 48);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = true;
            this.txt_diachi.Size = new System.Drawing.Size(404, 35);
            this.txt_diachi.TabIndex = 104;
            // 
            // lbl_nguyenquan
            // 
            this.lbl_nguyenquan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nguyenquan.AutoSize = true;
            this.lbl_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguyenquan.Location = new System.Drawing.Point(484, 101);
            this.lbl_nguyenquan.Name = "lbl_nguyenquan";
            this.lbl_nguyenquan.Size = new System.Drawing.Size(140, 27);
            this.lbl_nguyenquan.TabIndex = 106;
            this.lbl_nguyenquan.Text = "Nguyên quán";
            this.lbl_nguyenquan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ThemSo
            // 
            this.btn_ThemSo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemSo.FlatAppearance.BorderSize = 2;
            this.btn_ThemSo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemSo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemSo.ImageIndex = 0;
            this.btn_ThemSo.ImageList = this.imageList1;
            this.btn_ThemSo.Location = new System.Drawing.Point(932, 57);
            this.btn_ThemSo.Name = "btn_ThemSo";
            this.btn_ThemSo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_ThemSo.Size = new System.Drawing.Size(130, 40);
            this.btn_ThemSo.TabIndex = 107;
            this.btn_ThemSo.Text = "Thêm sổ";
            this.btn_ThemSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemSo.UseVisualStyleBackColor = true;
            this.btn_ThemSo.Click += new System.EventHandler(this.btn_ThemSo_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(932, 104);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(130, 40);
            this.button3.TabIndex = 108;
            this.button3.Text = "Tìm sổ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SoCauAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 615);
            this.Controls.Add(this.btn_ThemSo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_PhieuDiemThongTin);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.lbl_List);
            this.Controls.Add(this.txt_idchubai);
            this.Controls.Add(this.txt_loaiso);
            this.Controls.Add(this.txt_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoCauAn";
            this.Text = "Sớ cầu an";
            this.Load += new System.EventHandler(this.SoCauAn_Load);
            this.pnl_List.ResumeLayout(false);
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_PhieuDiemThongTin;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.Label lbl_List;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListView lsv_danhsach_cauan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        protected System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_idchubai;
        private System.Windows.Forms.TextBox txt_loaiso;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Button btn_ThemSo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.TextBox txt_nguyenquan;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_nguyenquan;
    }
}