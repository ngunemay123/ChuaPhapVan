using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanPhap.View
{
    public partial class FormUpdateChuBai : Form
    {
        public FormUpdateChuBai()
        {
            InitializeComponent();
            MaximizeBox = false;
        }



        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\Demo.accdb";
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
        public string idso { get; set; }
        public string name { get; set; }
        public string diachi { get; set; }
        public string nguyenquan { get; set; }
        public string gioitinh { get; set; }

      public void HienDanhSach()
        {

            txt_name_kiemtra.Text = name;
            txt_id1.Text = idso.ToString();
            string idsoo = txt_id1.Text;
            
            string namee = txt_name.Text;
            txt_diachi.Text = diachi;
            txt_nguyenquan.Text = nguyenquan;
            string nguyenquann = txt_nguyenquan.Text;
            string nameKiemTra = txt_name_kiemtra.Text;
            
            
            
            
            string query = "select NamNu, NamSinh,  HoTenUni,  PhapDanhUni from tblchitietso where idso = @idso AND  HoTenUni  = @namee ";
            //sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";
            using (OleDbConnection connection = new OleDbConnection(strCon))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@idso", idsoo); // Truyền giá trị vào tham số @param
                command.Parameters.AddWithValue("@namee", nameKiemTra);
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
                        string namSinh = reader["NamSinh"].ToString();
                        string gioiTinh=  reader["NamNu"].ToString();
                        txt_name.Text =  reader["HoTenUni"].ToString();
                        txt_nickname.Text = reader["PhapDanhUni"].ToString();
                     


                        for (int i = 0; i < comboBox_NamSinh.Items.Count; i++)
                        {
                            string comboBoxItemText = comboBox_NamSinh.Items[i].ToString();

                            if (comboBoxItemText.Contains(namSinh))
                            {
                                comboBox_NamSinh.SelectedIndex = i;
                                break;
                            }
                        }
                        if (gioiTinh.Equals("1"))
                        {
                            comboBox_GioiTinh.SelectedItem = "Nam";

                        }
                        else
                        {
                            comboBox_GioiTinh.SelectedItem = "Nữ";
                        }
                        
                        


                    }
                }
                connection.Close();
            }
            string query1 = "Select DiaChiUni, NguyenQuanUni from tblphattu  where id = @idso";
            using (OleDbConnection connection = new OleDbConnection(strCon))
            {
                OleDbCommand command = new OleDbCommand(query1, connection);
                command.Parameters.AddWithValue("@idso", idsoo); // Truyền giá trị vào tham số @param
                connection.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        txt_diachi.Text = reader["DiaChiUni"].ToString();

                        txt_nguyenquan.Text = reader["NguyenQuanUni"].ToString();
                        
                    }

                }
                connection.Close();
            }




        }
        private void FormUpdateChuBai_Load(object sender, EventArgs e)
        {
           

            

            
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

            HienDanhSach();
           


        }



        
        private void btn_Add_Click(object sender, EventArgs e)
        {




            if (txt_name.Text.Equals(""))
            {
                //MessageBox.Show("Chủ bái không được để trống!");
            }
            else
            {
                double id = double.Parse(txt_id1.Text);
                //double namnu = double.Parse(txt_gioi_tinh.Text);
                /////
                string inputHoten = txt_name.Text;
                string[] words = inputHoten.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(words[i]))
                    {
                        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                    }
                }

                string hoten = string.Join(" ", words);

                //////
                string inputphapdanh = txt_nickname.Text;
                string[] words1 = inputphapdanh.Split(' ');

                for (int i = 0; i < words1.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(words1[i]))
                    {
                        words1[i] = char.ToUpper(words1[i][0]) + words1[i].Substring(1);
                    }
                }

                string phapdanh = string.Join(" ", words1);
                /////
                string hoTenKiemTra = txt_name_kiemtra.Text;
                //////
                string inputnguyenquyan = txt_nguyenquan.Text;
                string[] words2 = inputnguyenquyan.Split(' ');

                for (int i = 0; i < words2.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(words2[i]))
                    {
                        words2[i] = char.ToUpper(words2[i][0]) + words2[i].Substring(1);
                    }
                }

                string nguyenquan = string.Join(" ", words2);
                ///
                string inputdiachi = txt_diachi.Text;
                string[] words3 = inputdiachi.Split(' ');

                for (int i = 0; i < words3.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(words3[i]))
                    {
                        words3[i] = char.ToUpper(words3[i][0]) + words3[i].Substring(1);
                    }
                }

                string diachi = string.Join(" ", words3);
                ///
              
                if (comboBox_GioiTinh.SelectedItem.Equals("Nam"))
                {
                    txt_gioi_tinh.Text = "1";
                }
                else
                {
                    txt_gioi_tinh.Text = "2";
                }
                double namnu = double.Parse(txt_gioi_tinh.Text);
                string selectedValue = comboBox_NamSinh.SelectedItem.ToString();
                string[] arr = selectedValue.Split(' ');
                double namsinh = double.Parse(arr[0]);
                var sao = txt_sao.Text ;

                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    connection.Open();


                    // Thực hiện câu lệnh DELETE
                    // string query = "DELETE FROM tblchitietso WHERE id = @id AND idso = @idso";
                    // string query = "select ID, IDSo, HoTenUni, PhapDanhUni, NamNu,NamSinh,AmLich,Sao,Han from tblchitietso where idso = @idso";
                    string query = "UPDATE tblphattu SET HoTenUni = ?, PhapDanhUni = ?,DiaChiUni = ? ,NguyenQuanUni = ? WHERE ID = ? ";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("?", hoten);
                        command.Parameters.AddWithValue("?", phapdanh);
                        command.Parameters.AddWithValue("?", diachi);
                        command.Parameters.AddWithValue("?", nguyenquan);
                        command.Parameters.AddWithValue("?", id);

                        command.ExecuteNonQuery();
                        //MessageBox.Show("Cập nhật thành công");
                        this.Close();
                    }
                    connection.Close();

                }



                string query1 = "UPDATE tblchitietso SET HoTenUni = ?, PhapDanhUni = ?, NamNu = ?, NamSinh = ?, Sao = ? WHERE IDso = ? AND HoTenUni = ?";


                

                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    using (OleDbCommand command = new OleDbCommand(query1, connection))
                    {

                        connection.Open();
                        // Gán giá trị cho các tham số trong câu lệnh INSERT

                        command.Parameters.AddWithValue("?", hoten);
                        command.Parameters.AddWithValue("?", phapdanh);
                        command.Parameters.AddWithValue("?", namnu);
                        command.Parameters.AddWithValue("?", namsinh);
                        command.Parameters.AddWithValue("?", sao);
                        command.Parameters.AddWithValue("?", id);
                        command.Parameters.AddWithValue("?", hoTenKiemTra);
                        // Thực thi câu lệnh INSERT
                        int rowsAffected = command.ExecuteNonQuery();
                        // Kiểm tra số dòng bị ảnh hưởng
                        connection.Close();
                    }

                    SoCauAn form1 = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
                    TimChuBai form2 = Application.OpenForms.OfType<TimChuBai>().FirstOrDefault();
                    
                    
                    form1.id = txt_id1.Text;
                    form1.chubai = hoten;
                    form1.phapdanh = phapdanh;
                    form1.diachi = diachi;
                    form1.nguyenquan = nguyenquan;
                    form1.UpdateData("Cuong");


                    form1.Show();
                    this.Close();
                }//Dong if

            }
           

            

        }
        private void txt_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_sex_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {

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
        private void comboBox_GioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Tuoi.Text.Equals(""))
            {
                
            }
            else
            {
                string selectedValue = txt_Tuoi.Text;
                string[] arr = selectedValue.Split(' ');
                int tuoi = int.Parse(arr[0]);

                string selectedValue1 = comboBox_GioiTinh.SelectedItem.ToString();
                tinhSaoNam(selectedValue1, tuoi);

            }
        }

        private void comboBox_NamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int namHienTai = 2023;
            int currentYear = DateTime.Now.Year;
            string selectedValue = comboBox_NamSinh.SelectedItem.ToString();

            string[] arr = selectedValue.Split(' ');
            int nam = int.Parse(arr[0]);
            int tuoi = currentYear - nam;
            txt_Tuoi.Text = tuoi.ToString() + " tuổi";

            if (txt_Tuoi.Text.Equals("") || comboBox_GioiTinh.Text.Equals(""))
            {

            }
            else
            {
                string selectedValue1 = txt_Tuoi.Text;
                string[] arr1 = selectedValue.Split(' ');
                int tuoi1 = int.Parse(arr[0]);

                string selectedValue11 = comboBox_GioiTinh.SelectedItem.ToString();
                tinhSaoNam(selectedValue11, tuoi);
            }

        }

        private void FormUpdateChuBai_Shown(object sender, EventArgs e)
        {
            txt_name.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

