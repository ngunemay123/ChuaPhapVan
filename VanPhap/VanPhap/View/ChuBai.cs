using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanPhap.Controller;

namespace VanPhap.View
{
    public partial class ChuBai : Form
    {
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
        public ChuBai()
        {
            InitializeComponent();
            MaximizeBox = false;
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

        private void lbl_Birthday_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nguyen_quan_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LuuTru_Click(object sender, EventArgs e)
        {

        }

        private void ChuBai_Load(object sender, EventArgs e)
        {
            txt_name.Focus();
            //if (txt_name.Text.Equals(""))
            //{
            //    txt_name.Focus();
            //}

            comboBox_NamSinh.DropDownHeight = comboBox_NamSinh.ItemHeight * 14;// nhảy 12 số combobox không được xóa !!!!!!

            //    int year = int.Parse(comboBox1.SelectedItem.ToString());


            // Xác định can và chi 000
            string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };





            // In kết quả
            // txt_tuoi.Text = canChi;

            int currentYear = DateTime.Now.Year;
            List<string> cuong = new List<string>();
            for (int i = 1900; i < currentYear; i++)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                //MessageBox.Show("Chủ bái không được để trống!");
            }
            else
            {
                using (OleDbConnection connection = new OleDbConnection(strCon))
                {
                    try
                    {
                        // Mở kết nối
                        connection.Open();
                        string query1 = "SELECT MAX(ID) FROM tblphattu";
                        using (OleDbCommand command = new OleDbCommand(query1, connection))
                        {
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                // Kiểm tra nếu có dữ liệu trả về
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        double value1 = reader.GetDouble(0);  // Lấy giá trị của cột Column1

                                        txt_id1.Text = value1.ToString();
                                    }
                                }
                                else
                                {

                                    //MessageBox.Show("Không có dữ liệu trả về từ câu truy vấn SELECT.");
                                }
                            }
                        }
                        // Tạo câu lệnh INSERT
                        string query = "INSERT INTO tblPhatTu (ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni)  VALUES (?,?,?,?,?)";
                        double id = double.Parse(txt_id1.Text) + 1;
                        txt_id1.Text = id.ToString();
                        ////
                        //////////////////////////////
                        string inputName = txt_name.Text;
                        string[] words = inputName.Split(' ');

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (!string.IsNullOrWhiteSpace(words[i]))
                            {
                                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                            }
                        }

                        string hoten = string.Join(" ", words);

                        ////////////////////////////////////
                        string inputPhapDanh = txt_nickname.Text;
                        string[] words1 = inputPhapDanh.Split(' ');

                        for (int i = 0; i < words1.Length; i++)
                        {
                            if (!string.IsNullOrWhiteSpace(words1[i]))
                            {
                                words1[i] = char.ToUpper(words1[i][0]) + words1[i].Substring(1);
                            }
                        }

                        string phapdanh = string.Join(" ", words1);

                        ///
                        //////////////////////////////////////
                        string inputDiaChi = txt_diachi.Text;
                        string[] words2 = inputDiaChi.Split(' ');

                        for (int i = 0; i < words2.Length; i++)
                        {
                            if (!string.IsNullOrWhiteSpace(words2[i]))
                            {
                                words2[i] = char.ToUpper(words2[i][0]) + words2[i].Substring(1);
                            }
                        }

                        string diachi = string.Join(" ", words2);
                        /////////////////////////////////////////////
                        ///
                        string inputNguyenQuan = txt_nguyenquan.Text;
                        string[] words3 = inputNguyenQuan.Split(' ');

                        for (int i = 0; i < words3.Length; i++)
                        {
                            if (!string.IsNullOrWhiteSpace(words3[i]))
                            {
                                words3[i] = char.ToUpper(words3[i][0]) + words3[i].Substring(1);
                            }
                        }

                        string nguyenquan = string.Join(" ", words3);


                        //double namsinh = double.Parse(txt_birthday1.Text);

                        // Tạo đối tượng Command và liên kết với Connection
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            // Gán giá trị cho các tham số trong câu lệnh INSERT
                            command.Parameters.AddWithValue("?", id);
                            command.Parameters.AddWithValue("?", hoten);
                            command.Parameters.AddWithValue("?", phapdanh);
                            command.Parameters.AddWithValue("?", diachi);
                            command.Parameters.AddWithValue("?", nguyenquan);
                            // Thực thi câu lệnh INSERT
                            int rowsAffected = command.ExecuteNonQuery();
                            // Kiểm tra số dòng bị ảnh hưởng
                        }
                        string query2 = "INSERT INTO tblSo (ID, IDChuBai)  VALUES (?,?)";
                        double idd = double.Parse(txt_id1.Text);
                        // Tạo đối tượng Command và liên kết với Connection
                        using (OleDbCommand command = new OleDbCommand(query2, connection))
                        {
                            // Gán giá trị cho các tham số trong câu lệnh INSERT
                            command.Parameters.AddWithValue("?", idd);
                            command.Parameters.AddWithValue("?", idd);
                            // Thực thi câu lệnh INSERT
                            int rowsAffected = command.ExecuteNonQuery();
                            // Kiểm tra số dòng bị ảnh hưởng

                        }
                        string query3 = "INSERT INTO tblChiTietSo ( ID, IDSo, NamNu, NamSinh, Sao,  HoTenUni,  PhapDanhUni)  VALUES (?,?,?,?,?,?,?)";

                        //double iddd = double.Parse(txt_id.Text);
                        if (comboBox_GioiTinh.SelectedItem.Equals("Nam"))
                        {
                            txt_gioitinh_1.Text = "1";
                        }
                        else
                        {
                            txt_gioitinh_1.Text = "2";
                        }
                        double namnu = double.Parse(txt_gioitinh_1.Text);
                        string selectedValue = comboBox_NamSinh.SelectedItem.ToString();
                        string[] arr = selectedValue.Split(' ');
                        double namsinh = double.Parse(arr[0]);
                        string sao = txt_sao.Text;



                        // Tạo đối tượng Command và liên kết với Connection
                        using (OleDbCommand command = new OleDbCommand(query3, connection))
                        {
                            // Gán giá trị cho các tham số trong câu lệnh INSERT
                            command.Parameters.AddWithValue("?", 0);
                            command.Parameters.AddWithValue("?", idd);
                            command.Parameters.AddWithValue("?", namnu);
                            command.Parameters.AddWithValue("?", namsinh);
                            command.Parameters.AddWithValue("?", sao);
                            command.Parameters.AddWithValue("?", hoten);
                            command.Parameters.AddWithValue("?", phapdanh);


                            // Thực thi câu lệnh INSERT
                            int rowsAffected = command.ExecuteNonQuery();
                            // Kiểm tra số dòng bị ảnh hưởng

                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);
                    }
                    connection.Close();
                }

            }
            this.Close();
        }

        private void txt_birthday1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void lbl_NamSinh_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_NamSinh_KeyDown(object sender, KeyEventArgs e)
        {

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
            // Xác định sao  
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChuBai_Shown(object sender, EventArgs e)
        {
            txt_name.Focus();
        }
    }
}
