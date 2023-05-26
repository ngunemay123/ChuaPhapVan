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
    public partial class FormXemTruoc : Form
    {
        public FormXemTruoc()
        {
            InitializeComponent();
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

        private void FormXemTruoc_Load(object sender, EventArgs e)
        {
            HienDanhSach();
            MaximizeBox = false;
        }
        public void HienDanhSach()
        {
            lsv_danhsach_cauan.Items.Clear();

            txt_idchubai.Text = id;
            txt_name.Text = chubai;
            txt_nickname.Text = phapdanh;
            txt_diachi.Text = diachi;
            txt_nguyenquan.Text = nguyenquan;

            string idso = txt_idchubai.Text;
            string query = "select ID, IDSo, HoTenUni, PhapDanhUni, NamNu,NamSinh,Sao from tblchitietso where idso = @idso AND NamMat IS NULL ";
            //sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";


            using (OleDbConnection connection = new OleDbConnection(strCon))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@idso", idso); // Truyền giá trị vào tham số @param
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
                connection.Close();
            }
        }
        public void UpdateData(string data)
        {
            lsv_danhsach_cauan.Items.Clear();
            HienDanhSach();
        }
        public string id { get; set; }
        public string loaiso { get; set; }
        public string chubai { get; set; }
        public string phapdanh { get; set; }
        public string diachi { get; set; }
        public string nguyenquan { get; set; }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            SoCauAn form1 = Application.OpenForms.OfType<SoCauAn>().FirstOrDefault();
            TimChuBai form2 = Application.OpenForms.OfType<TimChuBai>().FirstOrDefault();
            form1.id = id;
            form1.chubai = chubai;
            form1.phapdanh = phapdanh;
            form1.diachi = diachi;
            form1.nguyenquan = nguyenquan;
            form1.UpdateData("Cuong");

            form2.Show();
            form2.Close();
            form1.Show();
            this.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
