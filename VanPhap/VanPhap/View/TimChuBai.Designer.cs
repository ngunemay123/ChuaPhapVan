namespace VanPhap.View
{
    partial class TimChuBai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimChuBai));
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lsv_timchubai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_huy_bo = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_DanhsachChuBai = new System.Windows.Forms.Label();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.txt_nguyenquan = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_nguyenquan = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.pnl_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_List
            // 
            this.pnl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_List.Controls.Add(this.lsv_timchubai);
            this.pnl_List.Controls.Add(this.dgv_list);
            this.pnl_List.Controls.Add(this.btn_Update);
            this.pnl_List.Controls.Add(this.btn_Add);
            this.pnl_List.Controls.Add(this.btn_Delete);
            this.pnl_List.Location = new System.Drawing.Point(12, 275);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(1046, 267);
            this.pnl_List.TabIndex = 30;
            // 
            // lsv_timchubai
            // 
            this.lsv_timchubai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsv_timchubai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_timchubai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_timchubai.FullRowSelect = true;
            this.lsv_timchubai.GridLines = true;
            this.lsv_timchubai.HideSelection = false;
            this.lsv_timchubai.Location = new System.Drawing.Point(0, 0);
            this.lsv_timchubai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsv_timchubai.Name = "lsv_timchubai";
            this.lsv_timchubai.Size = new System.Drawing.Size(1042, 263);
            this.lsv_timchubai.TabIndex = 0;
            this.lsv_timchubai.UseCompatibleStateImageBehavior = false;
            this.lsv_timchubai.View = System.Windows.Forms.View.Details;
            this.lsv_timchubai.ItemActivate += new System.EventHandler(this.lsv_timchubai_ItemActivate);
            this.lsv_timchubai.SelectedIndexChanged += new System.EventHandler(this.lsv_timchubai_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chủ bái";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pháp danh";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 328;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nguyên quán";
            this.columnHeader5.Width = 153;
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_list.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(-2, -2);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.Size = new System.Drawing.Size(1046, 267);
            this.dgv_list.TabIndex = 1;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ImageIndex = 1;
            this.btn_Update.Location = new System.Drawing.Point(280, 237);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 34);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.Location = new System.Drawing.Point(200, 237);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 34);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 2;
            this.btn_Delete.Location = new System.Drawing.Point(361, 237);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 34);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tim_kiem.FlatAppearance.BorderSize = 0;
            this.btn_tim_kiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim_kiem.ImageIndex = 4;
            this.btn_tim_kiem.ImageList = this.imageList1;
            this.btn_tim_kiem.Location = new System.Drawing.Point(923, 24);
            this.btn_tim_kiem.Margin = new System.Windows.Forms.Padding(0);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_tim_kiem.Size = new System.Drawing.Size(135, 40);
            this.btn_tim_kiem.TabIndex = 5;
            this.btn_tim_kiem.Text = "Tìm kiếm";
            this.btn_tim_kiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim_kiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
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
            // 
            // btn_huy_bo
            // 
            this.btn_huy_bo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_huy_bo.FlatAppearance.BorderSize = 0;
            this.btn_huy_bo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy_bo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy_bo.ImageIndex = 2;
            this.btn_huy_bo.ImageList = this.imageList1;
            this.btn_huy_bo.Location = new System.Drawing.Point(923, 124);
            this.btn_huy_bo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_huy_bo.Name = "btn_huy_bo";
            this.btn_huy_bo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_huy_bo.Size = new System.Drawing.Size(135, 40);
            this.btn_huy_bo.TabIndex = 8;
            this.btn_huy_bo.Text = "Hủy bỏ";
            this.btn_huy_bo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy_bo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_huy_bo.UseVisualStyleBackColor = true;
            this.btn_huy_bo.Click += new System.EventHandler(this.btn_huy_bo_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.ImageIndex = 8;
            this.btn_xoa.ImageList = this.imageList1;
            this.btn_xoa.Location = new System.Drawing.Point(923, 72);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_xoa.Size = new System.Drawing.Size(135, 40);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_DanhsachChuBai
            // 
            this.lbl_DanhsachChuBai.AutoSize = true;
            this.lbl_DanhsachChuBai.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhsachChuBai.Location = new System.Drawing.Point(22, 239);
            this.lbl_DanhsachChuBai.Name = "lbl_DanhsachChuBai";
            this.lbl_DanhsachChuBai.Size = new System.Drawing.Size(230, 31);
            this.lbl_DanhsachChuBai.TabIndex = 301;
            this.lbl_DanhsachChuBai.Text = "Danh sách chủ bái";
            this.lbl_DanhsachChuBai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Form
            // 
            this.pnl_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnl_Form.Location = new System.Drawing.Point(12, 24);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(900, 204);
            this.pnl_Form.TabIndex = 302;
            // 
            // lbl_diachi
            // 
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
            this.txt_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguyenquan.Location = new System.Drawing.Point(484, 132);
            this.txt_nguyenquan.Name = "txt_nguyenquan";
            this.txt_nguyenquan.Size = new System.Drawing.Size(404, 35);
            this.txt_nguyenquan.TabIndex = 105;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(484, 48);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(404, 35);
            this.txt_diachi.TabIndex = 104;
            // 
            // lbl_nguyenquan
            // 
            this.lbl_nguyenquan.AutoSize = true;
            this.lbl_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguyenquan.Location = new System.Drawing.Point(484, 101);
            this.lbl_nguyenquan.Name = "lbl_nguyenquan";
            this.lbl_nguyenquan.Size = new System.Drawing.Size(140, 27);
            this.lbl_nguyenquan.TabIndex = 106;
            this.lbl_nguyenquan.Text = "Nguyên quán";
            this.lbl_nguyenquan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
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
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(25, 48);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(399, 35);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(20, 101);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(114, 27);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(25, 132);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(399, 35);
            this.txt_nickname.TabIndex = 2;
            // 
            // TimChuBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1066, 555);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.lbl_DanhsachChuBai);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huy_bo);
            this.Controls.Add(this.btn_tim_kiem);
            this.Controls.Add(this.pnl_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimChuBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimChuBai";
            this.Load += new System.EventHandler(this.TimChuBai_Load);
            this.pnl_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_tim_kiem;
        private System.Windows.Forms.Button btn_huy_bo;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ListView lsv_timchubai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_DanhsachChuBai;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.TextBox txt_nguyenquan;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_nguyenquan;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_nickname;
    }
}