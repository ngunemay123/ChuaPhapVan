using DocumentFormat.OpenXml.ExtendedProperties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

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
            string query = "select ID, IDSo, HoTenUni, PhapDanhUni, NamNu,NamSinh,Sao from tblchitietso where idso = @idsoo AND NamMat IS NULL";
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
                        string namSinh = reader["NamSinh"].ToString();
                        double tuoi = 2023 - double.Parse(namSinh);

                        ListViewItem lvi = new ListViewItem(reader["HoTenUni"].ToString());


                        lvi.SubItems.Add(reader["PhapDanhUni"].ToString());
                        lvi.SubItems.Add(reader["NamNu"].ToString());
                        lvi.SubItems.Add(reader["NamSinh"].ToString());
                        lvi.SubItems.Add(tuoi.ToString());
                        lvi.SubItems.Add(reader["Sao"].ToString());
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
                for (int i = 0; i < comboBox_NamSinh.Items.Count; i++)
                {
                    string comboBoxItemText = comboBox_NamSinh.Items[i].ToString();

                    if (comboBoxItemText.Contains(namsinh))
                    {
                        comboBox_NamSinh.SelectedIndex = i;
                        break;
                    }
                }
                if (gioitinh.Equals("1"))
                {
                    comboBox_gioitinh.SelectedItem = "Nam";

                }
                else
                {
                    comboBox_gioitinh.SelectedItem = "Nữ";
                }
                //txt_birthday.Text = namsinh;



            }
        }

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

                string id = lsv_danhsach_cauan.SelectedItems[0].SubItems[6].Text; // Giả sử khóa chính ở cột đầu tiên
                string idso = lsv_danhsach_cauan.SelectedItems[0].SubItems[7].Text;
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
                ///////////////////
                string inputPhapDanh = txt_name.Text;
                string[] words1 = inputPhapDanh.Split(' ');

                for (int i = 0; i < words1.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(words1[i]))
                    {
                        words1[i] = char.ToUpper(words1[i][0]) + words1[i].Substring(1);
                    }
                }

                string phapdanh = string.Join(" ", words1);

               
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
            SoCauAn form2 = System.Windows.Forms.Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
            form2.HienDanhSach();
        }//Dong if
    

      

        private void comboBox_NamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int namHienTai = 2023;
            int currentYear = DateTime.Now.Year;
            string selectedValue = comboBox_NamSinh.SelectedItem.ToString();

            string[] arr = selectedValue.Split(' ');
            int nam = int.Parse(arr[0]);
            int tuoi = currentYear - nam;
            txt_tuoi.Text = tuoi.ToString() + " tuổi";
        }

        private void comboBox_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_tuoi.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập năm sinh trước");
            }
            else
            {
                string selectedValue = txt_tuoi.Text;
                string[] arr = selectedValue.Split(' ');
                int tuoi = int.Parse(arr[0]);

                string selectedValue1 = comboBox_gioitinh.SelectedItem.ToString();
                tinhSaoNam(selectedValue1, tuoi);

            }
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

            if (txt_tuoi.Text.Equals(""))
            {

            }
            else
            {
                string selectedValue1 = txt_tuoi.Text;
                string[] arr1 = selectedValue.Split(' ');
                int tuoi1 = int.Parse(arr[0]);

                string selectedValue11 = comboBox_NamSinh.SelectedItem.ToString();
                tinhSaoNam(selectedValue11, tuoi);
            }
        }

        private void comboBox_gioitinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedValue = txt_tuoi.Text;
            string[] arr = selectedValue.Split(' ');
            int tuoi = int.Parse(arr[0]);
            string selectedValue1 = comboBox_gioitinh.SelectedItem.ToString();


            // Xác định sao

            tinhSaoNam(selectedValue1, tuoi);
            if (txt_tuoi.Text.Equals("") || comboBox_gioitinh.Text.Equals(""))
            {

            }
            else
            {
                string selectedValue2 = txt_tuoi.Text;
                string[] arr1 = selectedValue2.Split(' ');
                int tuoi1 = int.Parse(arr[0]);

                string selectedValue11 = comboBox_gioitinh.SelectedItem.ToString();
                tinhSaoNam(selectedValue11, tuoi);
            }
        }
    }
}
