using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanPhap.View
{
    public partial class FormUpdateNguoiNhanCauAn : Form
    {
        public FormUpdateNguoiNhanCauAn()
        {
            InitializeComponent();
            MaximizeBox = false;
        }


        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Git\\ChuaPhapVan\\VanPhap\\VanPhap\\bin\\Debug\\Demo.accdb";
        OleDbConnection sqlCon = null;
        //Hàm mở kết nối db
        public void OpenConection()
        {
            if (sqlCon == null)
            {
                sqlCon = new OleDbConnection(strCon);
            }
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }

        }
        public void CloseConection()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }

        private void FormUpdateNguoiNhanCauAn_Load(object sender, EventArgs e)
        {
            HienDanhSach();
            comboBox_NamSinh.DropDownHeight = comboBox_NamSinh.ItemHeight * 14;// nhảy 12 số combobox không được xóa !!!!!!

            //    int year = int.Parse(comboBox1.SelectedItem.ToString());


            // Xác định can và chi 000
            string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };





            // In kết quả
            // txt_tuoi.Text = canChi;


            List<string> cuong = new List<string>();
            for (int i = 1900; i < 2023; i++)
            {
                int canIndex = (i - 4) % 10;
                int chiIndex = (i - 4) % 12;
                string canChi = can[canIndex] + " " + chi[chiIndex];
                cuong.Add(i.ToString() + " " + canChi);
            }
            // Gán dữ liệu từ mảng vào ComboBox

            comboBox_NamSinh.Items.AddRange(cuong.ToArray());

            // Gán dữ liệu từ mảng vào ComboBox
        }

        public void tinhSaoNam(string gioiTinh, int tuoi)
        {
            {

                // Tính Sao
                string[] saoNam = { "La Hầu", "Thổ Tú", "Thủy Diệu", "Thái Bạch", "Thái Dương", "Vân Hớn", "Kế Đô", "Thái Âm", "Mộc Đức" };
                string[] saoNu = { "Kế Đô", "Vân Hớn", "Mộng Đức", "Thái Âm", "Thổ Tú", "La Hầu", "Thái Dương", "Thái Bạch", "Thủy Diệu" };


                if (gioiTinh.Equals("Nữ"))
                {

                    int tuoiIndex = tuoi + 1;
                    string Sao;

                    switch (tuoiIndex)
                    {
                        case 10: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 19: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 28: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 37: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 46: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 55: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 64: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 73: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 82: Sao = saoNu[0]; txt_sao.Text = Sao; break;




                        case 11: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 20: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 29: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 38: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 47: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 56: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 65: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 74: Sao = saoNu[1]; txt_sao.Text = Sao; break;
                        case 83: Sao = saoNu[1]; txt_sao.Text = Sao; break;

                        case 12: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 21: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 30: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 39: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 48: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 57: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 66: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 75: Sao = saoNu[2]; txt_sao.Text = Sao; break;
                        case 84: Sao = saoNu[2]; txt_sao.Text = Sao; break;

                        case 13: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 22: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 31: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 40: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 49: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 58: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 67: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 76: Sao = saoNu[3]; txt_sao.Text = Sao; break;
                        case 85: Sao = saoNu[3]; txt_sao.Text = Sao; break;

                        case 14: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 23: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 32: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 41: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 50: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 59: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 68: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 77: Sao = saoNu[4]; txt_sao.Text = Sao; break;
                        case 86: Sao = saoNu[4]; txt_sao.Text = Sao; break;

                        case 15: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 24: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 33: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 42: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 51: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 60: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 69: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 78: Sao = saoNu[5]; txt_sao.Text = Sao; break;
                        case 87: Sao = saoNu[5]; txt_sao.Text = Sao; break;

                        case 16: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 25: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 34: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 43: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 52: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 61: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 70: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 79: Sao = saoNu[6]; txt_sao.Text = Sao; break;
                        case 88: Sao = saoNu[6]; txt_sao.Text = Sao; break;

                        case 17: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 26: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 35: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 44: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 53: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 62: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 71: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 80: Sao = saoNu[7]; txt_sao.Text = Sao; break;
                        case 89: Sao = saoNu[7]; txt_sao.Text = Sao; break;


                        case 18: Sao = saoNu[8]; txt_sao.Text = Sao; break;
                        case 27: Sao = saoNu[8]; txt_sao.Text = Sao; break;
                        case 36: Sao = saoNu[8]; txt_sao.Text = Sao; break;
                        case 45: Sao = saoNu[8]; txt_sao.Text = Sao; break;
                        case 54: Sao = saoNu[8]; txt_sao.Text = Sao; break;
                        case 63: Sao = saoNu[8]; ; txt_sao.Text = Sao; break;
                        case 72: Sao = saoNu[8]; txt_sao.Text = Sao; break;
                        case 81: Sao = saoNu[8]; txt_sao.Text = Sao; break;
                        case 90: Sao = saoNu[8]; txt_sao.Text = Sao; break;






                    }
                }
                else
                {
                    string Sao;
                    int SaoIndex = tuoi + 1;

                    switch (SaoIndex)
                    {
                        case 10: Sao = saoNu[0]; txt_sao.Text = Sao; break;
                        case 19: Sao = saoNam[0]; txt_sao.Text = Sao; break;
                        case 28: Sao = saoNam[0]; txt_sao.Text = Sao; break;
                        case 37: Sao = saoNam[0]; txt_sao.Text = Sao; break;
                        case 46: Sao = saoNam[0]; txt_sao.Text = Sao; break;
                        case 55: Sao = saoNam[0]; txt_sao.Text = Sao; break;
                        case 64: Sao = saoNam[0]; txt_sao.Text = Sao; break;
                        case 73: Sao = saoNam[0]; txt_sao.Text = Sao; break;
                        case 82: Sao = saoNam[0]; txt_sao.Text = Sao; break;




                        case 11: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 20: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 29: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 38: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 47: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 56: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 65: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 74: Sao = saoNam[1]; txt_sao.Text = Sao; break;
                        case 83: Sao = saoNam[1]; txt_sao.Text = Sao; break;

                        case 12: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 21: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 30: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 39: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 48: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 57: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 66: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 75: Sao = saoNam[2]; txt_sao.Text = Sao; break;
                        case 84: Sao = saoNam[2]; txt_sao.Text = Sao; break;

                        case 13: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 22: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 31: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 40: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 49: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 58: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 67: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 76: Sao = saoNam[3]; txt_sao.Text = Sao; break;
                        case 85: Sao = saoNam[3]; txt_sao.Text = Sao; break;

                        case 14: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 23: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 32: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 41: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 50: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 59: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 68: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 77: Sao = saoNam[4]; txt_sao.Text = Sao; break;
                        case 86: Sao = saoNam[4]; txt_sao.Text = Sao; break;

                        case 15: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 24: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 33: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 42: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 51: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 60: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 69: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 78: Sao = saoNam[5]; txt_sao.Text = Sao; break;
                        case 87: Sao = saoNam[5]; txt_sao.Text = Sao; break;

                        case 16: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 25: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 34: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 43: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 52: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 61: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 70: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 79: Sao = saoNam[6]; txt_sao.Text = Sao; break;
                        case 88: Sao = saoNam[6]; txt_sao.Text = Sao; break;

                        case 17: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 26: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 35: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 44: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 53: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 62: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 71: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 80: Sao = saoNam[7]; txt_sao.Text = Sao; break;
                        case 89: Sao = saoNam[7]; txt_sao.Text = Sao; break;


                        case 18: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 27: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 36: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 45: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 54: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 63: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 72: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 81: Sao = saoNam[8]; txt_sao.Text = Sao; break;
                        case 90: Sao = saoNam[8]; txt_sao.Text = Sao; break;

                    }
                }



            }

        }

        public string idso { get; set; }



        public void HienDanhSach()
        {
            lsv_danhsach_cauan.Items.Clear();

            txt_id_so.Text = idso;
            string idsoo = txt_id_so.Text;
            string query = "select ID, IDSo, HoTenUni, PhapDanhUni, NamNu,NamSinh,AmLich,Sao,Han from tblchitietso where idso = @idsoo AND NamMat IS NULL";
            //sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";


            using (OleDbConnection connection = new OleDbConnection(strCon))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@idso", idsoo); // Truyền giá trị vào tham số @param
                connection.Open();

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        /*string hoten = reader.GetString(0);
                        string phapdanh1 = reader.GetString(1);
                        double gioitinh = reader.GetDouble(2);
                        double namsinh = reader.GetDouble(3);
                        string amlich = reader.GetString(4);
                        string sao = reader.GetString(5);
                        string han = reader.GetString(6);*/

                        ListViewItem lvi = new ListViewItem(reader["HoTenUni"].ToString());


                        lvi.SubItems.Add(reader["PhapDanhUni"].ToString());
                        lvi.SubItems.Add(reader["NamNu"].ToString());
                        lvi.SubItems.Add(reader["NamSinh"].ToString());
                        lvi.SubItems.Add(reader["AmLich"].ToString());
                        lvi.SubItems.Add(reader["Sao"].ToString());
                        lvi.SubItems.Add(reader["Han"].ToString());
                        lvi.SubItems.Add(reader["ID"].ToString());
                        lvi.SubItems.Add(reader["IDSo"].ToString());


                        lsv_danhsach_cauan.Items.Add(lvi);
                    }


                }
            }
        }

        private void lsv_danhsach_cauan_ItemActivate(object sender, EventArgs e)
        {
            if (lsv_danhsach_cauan.SelectedItems.Count > 0)
            {
                // Lấy item được kích hoạt (được nhấp vào)
                ListViewItem activatedItem = lsv_danhsach_cauan.SelectedItems[0];

                //Hiển thị thông tin từ item vào TextBox

                string hoten = activatedItem.SubItems[0].Text;
                string phapdanh = activatedItem.SubItems[1].Text;
                string gioitinh = activatedItem.SubItems[2].Text;
                string namsinh = activatedItem.SubItems[3].Text;


                txt_name.Text = hoten;
                txt_nickname.Text = phapdanh;
                //txt_birthday.Text = namsinh;


                int current_year = 2023;
                //int year = int.Parse(txt_birthday.Text);


                // Xác định can và chi 000
                string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
                string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

                //int canIndex = (year - 4) % 10;
                //int chiIndex = (year - 4) % 12;

                //string canChi = can[canIndex] + " " + chi[chiIndex];

                // In kết quả
                //txt_tuoi.Text = canChi;



                //Check giới tính


                // Xác định sao
                string[] saoNam = { "La Hầu", "Thổ Tú", "Thủy Diệu", "Thái Bạch", "Thái Dương", "Vân Hớn", "Kế Đô", "Thái Âm", "Mộc Đức" };
                string[] saoNu = { "Kế Đô", "Vân Hớn", "Mộng Đức", "Thái Âm", "Thổ Tú", "La Hầu", "Thái Dương", "Thái Bạch", "Thủy Diệu" };
                // Xác định hạn
                string[] hanNam = { "Huỳnh Thiền", "Tam Kheo", "Ngũ Mộ", "Thiên Tinh", "Tán Tận", "Thiên La", "Địa Võng", "Diêm Vương" };
                string[] hanNu = { "Tán Tận", "Thiên Tinh", "Ngũ Mộ", "Tam Kheo", "Huỳnh Tiền", "Diêm Vương", "Địa Võng", "Thiên La" };
                string tuoi;
                string han;
                //Tính Sao
                //int saoIndex = current_year - year;
                //if (txt_gioi_tinh_1.Text.Equals("Nữ"))
                //{

                //    int tuoiIndex = current_year - year + 1;
                //    txt_tuoiii.Text = tuoiIndex.ToString();
                //    switch (tuoiIndex)
                //    {


                //        case 10: tuoi = saoNu[0]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 19: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 28: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 37: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 46: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 55: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 64: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 73: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 82: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                //        case 11: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 20: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 29: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 38: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 47: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 56: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 65: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 74: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 83: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 12: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 21: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 30: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 39: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 48: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 57: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 66: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 75: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 84: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 13: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 22: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 31: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 40: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 49: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 58: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 67: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 76: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 85: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 14: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 23: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 32: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 41: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 50: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 59: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 68: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 77: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 86: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 15: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 24: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 33: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 42: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 51: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 60: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 69: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 78: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 87: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 16: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 25: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 34: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 43: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 52: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 61: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 70: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 79: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 88: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 17: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 26: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 35: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 44: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 53: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 62: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 71: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 80: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 89: tuoi = saoNu[7]; txt_sao.Text = tuoi; break;


                //        case 18: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 27: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 36: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 45: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 54: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 63: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 72: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 81: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 90: tuoi = saoNu[8]; txt_sao.Text = tuoi; break;






                //    }
                //}
                //else
                //{
                //    int tuoiIndex = current_year - year + 1;

                //    switch (tuoiIndex)
                //    {
                //        case 10: tuoi = saoNu[0]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 19: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 28: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 37: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 46: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 55: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 64: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 73: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 82: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                //        case 11: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 20: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 29: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 38: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 47: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 56: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 65: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 74: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 83: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 12: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 21: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 30: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 39: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 48: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 57: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 66: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 75: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 84: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 13: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 22: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 31: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 40: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 49: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 58: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 67: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 76: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 85: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 14: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 23: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 32: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 41: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 50: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 59: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 68: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 77: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 86: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 15: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 24: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 33: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 42: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 51: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 60: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 69: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 78: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 87: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 16: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 25: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 34: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 43: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 52: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 61: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 70: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 79: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 88: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                //        case 17: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 26: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 35: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 44: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 53: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 62: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 71: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 80: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 89: tuoi = saoNam[7]; txt_sao.Text = tuoi; break;


                //        case 18: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 27: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 36: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 45: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 54: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 63: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 72: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 81: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                //        case 90: tuoi = saoNam[8]; txt_sao.Text = tuoi; break;

                //    }
                //}
                //End tính sao

                //Tính Hạn


            }
        }

        /*  private void btn_xacnhan_Click(object sender, EventArgs e)
          {

              {
                  int current_year = 2023;
                  int year = int.Parse(txt_birthday.Text);


                  // Xác định can và chi 000
                  string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
                  string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

                  int canIndex = (year - 4) % 10;
                  int chiIndex = (year - 4) % 12;

                  string canChi = can[canIndex] + " " + chi[chiIndex];

                  // In kết quả
                  txt_tuoi.Text = canChi;



                  //Check giới tính
                  if (rbm_Nam.Checked)
                  {
                      txt_gioi_tinh_1.Text = "Nam";
                  }
                  else if (rbm_Nu.Checked)
                  {
                      txt_gioi_tinh_1.Text = "Nữ";
                  }

                  // Xác định sao
                  string[] saoNam = { "La Hầu", "Thổ Tú", "Thủy Diệu", "Thái Bạch", "Thái Dương", "Vân Hớn", "Kế Đô", "Thái Âm", "Mộc Đức" };
                  string[] saoNu = { "Kế Đô", "Vân Hớn", "Mộng Đức", "Thái Âm", "Thổ Tú", "La Hầu", "Thái Dương", "Thái Bạch", "Thủy Diệu" };
                  // Xác định hạn
                  string[] hanNam = { "Huỳnh Thiền", "Tam Kheo", "Ngũ Mộ", "Thiên Tinh", "Tán Tận", "Thiên La", "Địa Võng", "Diêm Vương" };
                  string[] hanNu = { "Tán Tận", "Thiên Tinh", "Ngũ Mộ", "Tam Kheo", "Huỳnh Tiền", "Diêm Vương", "Địa Võng", "Thiên La" };
                  string tuoi;
                  string han;
                  //Tính Sao
                  int saoIndex = current_year - year;
                  if (txt_gioi_tinh_1.Text.Equals("Nữ"))
                  {

                      int tuoiIndex = current_year - year + 1;
                      txt_name.Text = tuoiIndex.ToString();
                      switch (tuoiIndex)
                      {


                          case 10: tuoi = saoNu[0]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 19: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 28: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 37: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 46: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 55: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 64: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 73: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 82: tuoi = saoNu[0]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                          case 11: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 20: tuoi = saoNu[1]; han = hanNu[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 29: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 38: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 47: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 56: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 65: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 74: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 83: tuoi = saoNu[1]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 12: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 21: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 30: tuoi = saoNu[2]; han = hanNu[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 39: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 48: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 57: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 66: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 75: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 84: tuoi = saoNu[2]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 13: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 22: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 31: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 40: tuoi = saoNu[3]; han = hanNu[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 49: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 58: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 67: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 76: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 85: tuoi = saoNu[3]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 14: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 23: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 32: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 41: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 50: tuoi = saoNu[4]; han = hanNu[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 59: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 68: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 77: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 86: tuoi = saoNu[4]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 15: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 24: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 33: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 42: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 51: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 60: tuoi = saoNu[5]; han = hanNu[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 69: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 78: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 87: tuoi = saoNu[5]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 16: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 25: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 34: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 43: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 52: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 61: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 70: tuoi = saoNu[6]; han = hanNu[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 79: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 88: tuoi = saoNu[6]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 17: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 26: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 35: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 44: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 53: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 62: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 71: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 80: tuoi = saoNu[7]; han = hanNu[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 89: tuoi = saoNu[7]; txt_sao.Text = tuoi; break;


                          case 18: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 27: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 36: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 45: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 54: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 63: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 72: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 81: tuoi = saoNu[8]; han = hanNu[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 90: tuoi = saoNu[8]; txt_sao.Text = tuoi; break;






                      }
                  }
                  else
                  {
                      int tuoiIndex = current_year - year + 1;

                      switch (tuoiIndex)
                      {
                          case 10: tuoi = saoNu[0]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 19: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 28: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 37: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 46: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 55: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 64: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 73: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 82: tuoi = saoNam[0]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;




                          case 11: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 20: tuoi = saoNam[1]; han = hanNam[1]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 29: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 38: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 47: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 56: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 65: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 74: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 83: tuoi = saoNam[1]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 12: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 21: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 30: tuoi = saoNam[2]; han = hanNam[2]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 39: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 48: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 57: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 66: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 75: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 84: tuoi = saoNam[2]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 13: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 22: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 31: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 40: tuoi = saoNam[3]; han = hanNam[3]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 49: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 58: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 67: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 76: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 85: tuoi = saoNam[3]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 14: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 23: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 32: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 41: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 50: tuoi = saoNam[4]; han = hanNam[4]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 59: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 68: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 77: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 86: tuoi = saoNam[4]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 15: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 24: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 33: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 42: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 51: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 60: tuoi = saoNam[5]; han = hanNam[5]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 69: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 78: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 87: tuoi = saoNam[5]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 16: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 25: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 34: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 43: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 52: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 61: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 70: tuoi = saoNam[6]; han = hanNam[6]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 79: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 88: tuoi = saoNam[6]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;

                          case 17: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 26: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 35: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 44: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 53: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 62: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 71: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 80: tuoi = saoNam[7]; han = hanNam[7]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 89: tuoi = saoNam[7]; txt_sao.Text = tuoi; break;


                          case 18: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 27: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 36: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 45: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 54: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 63: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 72: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 81: tuoi = saoNam[8]; han = hanNam[0]; txt_han.Text = han; txt_sao.Text = tuoi; break;
                          case 90: tuoi = saoNam[8]; txt_sao.Text = tuoi; break;

                      }
                  }
                  //End tính sao

                  //Tính Hạn


              }

                  //End tính sao

                  //Tính Hạn


              }
          }*/



        private void txt_update_Click(object sender, EventArgs e)
        {
            //if (rbm_Nam.Checked)
            //{
            //    txt_GioiTinhThemVaoDb.Text = "1";
            //}
            //else if (rbm_Nu.Checked)
            //{
            //    txt_GioiTinhThemVaoDb.Text = "2";
            //}

            if (lsv_danhsach_cauan.SelectedItems.Count > 0)
            {
                // Lấy giá trị khóa chính từ dòng đang chọn

                string id = lsv_danhsach_cauan.SelectedItems[0].SubItems[7].Text; // Giả sử khóa chính ở cột đầu tiên
                string idso = lsv_danhsach_cauan.SelectedItems[0].SubItems[8].Text;
                string query = "UPDATE tblchitietso SET HoTenUni = ?, PhapDanhUni = ?, NamNu = ?, NamSinh = ?, Sao = ? WHERE ID = ? AND IDSo = ?";
                
                
                    if (comboBox_gioitinh.SelectedItem.Equals("Nam"))
                    {
                        txt_gioitinh.Text = "1";
                    }
                    else
                    {
                        txt_gioitinh.Text = "2";
                    }
                    double namnu = double.Parse(txt_gioitinh.Text);
                    string selectedValue = comboBox_NamSinh.SelectedItem.ToString();
                    string[] arr = selectedValue.Split(' ');
                    double namsinh = double.Parse(arr[0]);
                    string sao = txt_sao.Text;
                    string hoten = txt_name.Text;
                    string phapdanh = txt_nickname.Text;
                    using (OleDbConnection connection = new OleDbConnection(strCon))
                    {
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {

                            connection.Open();
                            // Gán giá trị cho các tham số trong câu lệnh INSERT

                            command.Parameters.AddWithValue("?", hoten);
                            command.Parameters.AddWithValue("?", phapdanh);
                            command.Parameters.AddWithValue("?", namnu);
                            command.Parameters.AddWithValue("?", namsinh);
                            command.Parameters.AddWithValue("?", sao);
                            command.Parameters.AddWithValue("?", id);
                            command.Parameters.AddWithValue("?", idso);
                            // Thực thi câu lệnh INSERT
                            int rowsAffected = command.ExecuteNonQuery();
                            // Kiểm tra số dòng bị ảnh hưởng

                        }
                    
                }
              


            }
            txt_name.Text = "";
            txt_nickname.Text = "";
            
            txt_tuoi.Text = "";
            txt_sao.Text = "";
            HienDanhSach();
        }//Dong if
    

      

        private void comboBox_NamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int namHienTai = 2023;
            string selectedValue = comboBox_NamSinh.SelectedItem.ToString();

            string[] arr = selectedValue.Split(' ');
            int nam = int.Parse(arr[0]);
            int tuoi = namHienTai - nam;
            txt_tuoi.Text = tuoi.ToString() + " tuổi";
        }

        private void comboBox_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = txt_tuoi.Text;
            string[] arr = selectedValue.Split(' ');
            int tuoi = int.Parse(arr[0]);
            string selectedValue1 = comboBox_gioitinh.SelectedItem.ToString();


            // Xác định sao

            tinhSaoNam(selectedValue1, tuoi);
        }

        private void txt_gioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_NamSinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int namHienTai = 2023;
            string selectedValue = comboBox_NamSinh.SelectedItem.ToString();

            string[] arr = selectedValue.Split(' ');
            int nam = int.Parse(arr[0]);
            int tuoi = namHienTai - nam;
            txt_tuoi.Text = tuoi.ToString() + " tuổi";
        }

        private void comboBox_gioitinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = txt_tuoi.Text;
            string[] arr = selectedValue.Split(' ');
            int tuoi = int.Parse(arr[0]);
            string selectedValue1 = comboBox_gioitinh.SelectedItem.ToString();


            // Xác định sao

            tinhSaoNam(selectedValue1, tuoi);
        }
    }
}

