﻿using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
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
using VanPhap.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;
using Color = System.Drawing.Color;
using System.Diagnostics;
using System.IO;

namespace VanPhap.View
{
    public partial class SoCauAn : Form
    {
        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\Manager1.mdb";
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
        public string id { get; set; }
        public string loaiso { get; set; }
        public string chubai { get; set; }
        public string phapdanh { get; set; }
        public string diachi { get; set; }
        public string nguyenquan { get; set; }

        public string status { get; set; }

        public SoCauAn()
        {
            InitializeComponent();
            myListView = lsv_danhsach_cauan;
        }

        
        public ListView myListView;
        
        private void SoCauAn_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            lsv_danhsach_cauan.Items.Clear();
            cuon();
            HienDanhSach();
        }
        public async Task cuon()
        {
            await Task.Delay(100);
            string cuong = loaiso;
            

            txt_loaiso.Text = cuong;
        }

        public void UpdateData(string data)
        {
            lsv_danhsach_cauan.Items.Clear();
            HienDanhSach();
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
            string query = "select ID, IDSo, HoTenUni, PhapDanhUni, NamNu,NamSinh,Sao from tblchitietso where idso = @idso AND NamMat IS NULL ORDER BY ID ASC ";
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
                        lvi.SubItems.Add(tuoi.ToString() );
                        lvi.SubItems.Add(reader["Sao"].ToString());               
                        lvi.SubItems.Add(reader["ID"].ToString());
                        lvi.SubItems.Add(reader["IDSo"].ToString());


                        lsv_danhsach_cauan.Items.Add(lvi);
                    }


                }
                connection.Close();
            }
        }


        public void CheckGioiTinh()
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (txt_name.Text.Equals(""))
            {
                //MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
                
            }
            else
            {
                //Hiển thị thông tin từ item vào TextBox
                string id = txt_idchubai.Text;


                NguoiNhanCauAn formNguoiNhan = new NguoiNhanCauAn();
                formNguoiNhan.DataFromForm11 = id;
                formNguoiNhan.Show();

               
               
            }
        }




        

        //public void clear()
        //{
        //    txt_birthday.Text = "";
        //    rbm_Man.Checked = true;
        //    txt_name.Text = "";
        //    txt_nickname.Text = "";
        //    txt_luutru.Text = "";
        //    txt_han.Text = "";
        //    txt_tuoi.Text = "";
        //    txt_sao.Text = "";

        //}

        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_List_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_MouseHover(object sender, EventArgs e)
        {
            //btn_Add.ForeColor = System.Drawing.Color.Red;
        }

        private void btn_Add_MouseLeave(object sender, EventArgs e)
        {
            btn_Add.ForeColor = System.Drawing.Color.Black;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            SoCauAn sca = new SoCauAn();
            sca.Show();
        }

        private void rdbtn_coso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtn_chua_Click(object sender, EventArgs e)
        {
            ChuBai cb = new ChuBai();
            cb.Show();
        }

        private void rdbtn_coso_Click(object sender, EventArgs e)
        {
            TimChuBai tcb = new TimChuBai();
            tcb.loaiso = loaiso;
            tcb.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbtn_chua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_gioi_tinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_luutru_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                //MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            {
                lsv_danhsach_cauan.Items.Clear();
                HienDanhSach();
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                //MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");

            }
            else
            {
               
                if (lsv_danhsach_cauan.SelectedItems.Count > 0)
                {
                    // Lấy giá trị khóa chính từ dòng đang chọn

                    string id = lsv_danhsach_cauan.SelectedItems[0].SubItems[6].Text; // Giả sử khóa chính ở cột đầu tiên
                    string idso = lsv_danhsach_cauan.SelectedItems[0].SubItems[7].Text;

                    using (OleDbConnection connection = new OleDbConnection(strCon))
                    {
                        connection.Open();


                        // Thực hiện câu lệnh DELETE
                        string query = "DELETE FROM tblchitietso WHERE id = @id AND idso = @idso";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@idso", idso);
                            command.ExecuteNonQuery();
                        }
                        if (lsv_danhsach_cauan.SelectedItems.Count > 0)
                        {
                            // Xóa thành công
                            //MessageBox.Show("Xóa thành công");
                            HienDanhSach();
                        }
                        else
                        {
                            // Không có dòng nào được xóa
                            MessageBox.Show("Không có dòng nào được xóa");
                        }
                        connection.Close();
                    }
                }//Dong if
                else
                {
                    MessageBox.Show("Vui lòng chọn một người bên dưới để xóa!");

                }

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                //MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            {
                FormUpdateNguoiNhanCauAn frm = new FormUpdateNguoiNhanCauAn();

                frm.idso = txt_idchubai.Text;
                frm.Show();
            }

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_diachi_Click(object sender, EventArgs e)
        {

        }

        private void lbl_List_Click(object sender, EventArgs e)
        {

        }

        /* public void btn_print_Click(object sender, EventArgs e)
         {
                 List<string> user = new List<string>();
                 List<List<string>> ls = new List<List<string>>();
                 int count = 0;

                 *//*  lsv_danhsach_cauan.SelectedIndexChanged += lsv_danhsach_cauan_SelectedIndexChanged;
                   if (lsv_danhsach_cauan.SelectedItems.Count > 0)
                   {
                       // Xử lý lựa chọn dòng được chọn
                       ListViewItem selectedItem = lsv_danhsach_cauan.SelectedItems[0];
                       string name = selectedItem.SubItems[1].Text; // Lấy giá trị của cột
                       txt_id.Text = name;
                   }*//*
                 foreach (ListViewItem item in lsv_danhsach_cauan.Items)
                 {
                     if (item.Checked)
                     {
                         ls.Add(new List<string>());
                     }

                 }
                 foreach (ListViewItem item in lsv_danhsach_cauan.Items)
                 {
                     if (item.Checked)
                     {
                         ls[count].Add(item.SubItems[1].Text);
                         ls[count].Add(item.SubItems[2].Text);
                         ls[count].Add(item.SubItems[3].Text);
                         ls[count].Add(item.SubItems[4].Text);
                         ls[count].Add(item.SubItems[5].Text);
                         ls[count].Add(item.SubItems[6].Text);
                         ls[count].Add(item.SubItems[7].Text);

                         count++;
                     }
                 }
                 try
                 {
                     string filePath = "D:/file.docx";
                     using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                     {
                         // Add a main document part
                         MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                         // Create a new document tree

                         mainPart.Document = new Document();
                         // Create a body for the document

                         DocumentFormat.OpenXml.Wordprocessing.Body body = new DocumentFormat.OpenXml.Wordprocessing.Body();

                         // Add a paragraph to the body
                         Paragraph paragraph = new Paragraph();
                         Run run = new Run();

                         foreach (List<string> sublist in ls)
                         {
                             foreach (string subitem in sublist)
                             {
                                 run.Append(new Text(subitem + "\n"));
                             }
                             run.Append(new Break());
                         }
                         paragraph.Append(run);
                         body.Append(paragraph);

                         // Add the body to the document
                         mainPart.Document.Append(body);

                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.ToString());

                 }


         }
 */
        public class ChuBai1
        {
            public String Chubai { get; set; }
            public String Phapdanh { get; set; }
            public String NguyenQuan { get; set; }
            public String DiaChi { get; set; }
        }


        public void btn_print_Click(object sender, EventArgs e)
        {
            List<string> user = new List<string>();
            List<List<string>> ls = new List<List<string>>();
            int count = 0;


            ChuBai1 chu = new ChuBai1();
            {
                chu.Chubai = txt_name.Text;
                chu.Phapdanh = txt_nickname.Text;
                chu.DiaChi = txt_diachi.Text;
                chu.NguyenQuan = txt_nguyenquan.Text;
            }



            /*  lsv_danhsach_cauan.SelectedIndexChanged += lsv_danhsach_cauan_SelectedIndexChanged;
              if (lsv_danhsach_cauan.SelectedItems.Count > 0)
              {
                  // Xử lý lựa chọn dòng được chọn
                  ListViewItem selectedItem = lsv_danhsach_cauan.SelectedItems[0];
                  string name = selectedItem.SubItems[1].Text; // Lấy giá trị của cột
                  txt_id.Text = name;
              }*/

            foreach (ListViewItem item in lsv_danhsach_cauan.Items)
            {
                
                    ls.Add(new List<string>());
                

            }
            foreach (ListViewItem item in lsv_danhsach_cauan.Items)
            {

               
                
                    string kiemTra = item.SubItems[2].Text;//gioi tinh
                    if (kiemTra.Equals("1"))
                    {
                        ls[count].Add("X");
                        ls[count].Add("");
                        ls[count].Add(item.SubItems[0].Text); //name
                        ls[count].Add(item.SubItems[1].Text); // phapdanh
                        ls[count].Add(item.SubItems[3].Text);//nam sinh
                        ls[count].Add(item.SubItems[4].Text);//tuoi
                        ls[count].Add(item.SubItems[5].Text);//sao
                    
                    }
                    else
                    {
                        ls[count].Add("");
                        ls[count].Add("X");
                        ls[count].Add(item.SubItems[0].Text); //name
                        ls[count].Add(item.SubItems[1].Text); // phapdanh
                        ls[count].Add(item.SubItems[3].Text);//nam sinh
                        ls[count].Add(item.SubItems[4].Text);//tuoi
                        ls[count].Add(item.SubItems[5].Text);//sao
                    
                    }



                    count++;
                
            }

            try
            {
                // tạo tệp mới
                string path = @"Z:\index.html";
                File.Create(path).Close();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("<html><head><title>So cau an</title></head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"1000\">");
                    sw.WriteLine("<tbody><tr>");
                    sw.WriteLine("<td width=\"998\" colspan=\"3\" height=\"60\">");
                    sw.WriteLine("<p align=\"center\"><b><font size=\"5\" face=\"VNI-Cooper\">DAÂNG LEÃ CAÀU AN</font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Chuû baùi&nbsp;</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("<p style=\"line-height: 100%; margin-bottom: 0\"><b>: " + chu.Chubai + "");
                    sw.WriteLine("<font face=\"VNI-Times\" size=\"2\"><span style=\"text-transform: uppercase\">");
                    sw.WriteLine("</span></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Phaùp danh&nbsp;</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\"><p style=\"line-height: 100%; margin-bottom: 0\"><b>: " + chu.Phapdanh + "");
                    sw.WriteLine("</b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Nguyeân quaùn</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("<p style=\"line-height: 100%; margin-bottom: 0\"><b>: " + chu.NguyenQuan + "");
                    sw.WriteLine("</b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("<p style=\"line-height: 150%; margin-bottom: 0\"><b><font size=\"3\" face=\"vni-times\"><i>Ñòa chæ</i></font></b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("<p style=\"line - height: 100 %; margin - bottom: 0\"><b>: " + chu.DiaChi + "");
                    sw.WriteLine("</b></p>");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width=\"265\"><b><font size=\"3\" face=\"vni-times\"><i>&nbsp;</i></font></b></td>");
                    sw.WriteLine("<td width=\"124\">");
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td width=\"605\">");
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr></tbody></table>");
                    sw.WriteLine("<table border=\".1\" width=\"1000\" cellspacing=\"0\" bordercolor=\"#808080\" bordercolorlight=\"#808080\" bordercolordark=\"#FFFFFF\" cellpadding=\"0\" height=\"62\">");
                    sw.WriteLine("<tbody><tr>");
                    sw.WriteLine("<td width=\"60\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">NAM</font></b></td>");
                    sw.WriteLine("<td width=\"60\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">NÖÕ</font></b></td>");
                    sw.WriteLine("<td width=\"350\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">HOÏ VAØ TEÂN</font></b></td>");
                    sw.WriteLine("<td width=\"150\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">PHAÙP DANH</font></b></td>");
                    sw.WriteLine("<td width=\"150\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">NAÊM SINH</font></b></td>");
                    sw.WriteLine("<td width=\"100\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">TUOÅI</font></b></td>");
                    sw.WriteLine("<td width=\"130\" align=\"center\" height=\"39\"><b><font face=\"VNI-Times\" size=\"3\">SAO</font></b></td>");
                    
                    sw.WriteLine("</tr>");
                    //Dữ liệu thêm vào
                    foreach (List<string> sublist in ls)
                    {
                        sw.WriteLine("<tr>");
                        foreach (string subitem in sublist)
                        {

                            sw.WriteLine("<td width=\"130\" align=\"center\" height=\"39\"><b>" + subitem + "</b></td>"); //name //nam//nu


                        }
                        sw.WriteLine("</tr>");


                    }



                    sw.WriteLine("</body></html>");



                }
                Process.Start("Z:\\index.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                //MessageBox.Show("Chủ bái đang trống!\nVui lòng chọn || Có sớ || Chưa có sớ || để thêm chủ bái!");
            }
            else
            {
                //FormUpdateChuBai frm = new FormUpdateChuBai();

                //frm.idso = txt_idchubai.Text;
                //frm.name = txt_name.Text;
                //frm.diachi = txt_diachi.Text;
                //frm.nguyenquan = txt_nguyenquan.Text;
                //frm.gioitinh = txt_gioi_tinh.Text;
                //frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_loaiso.Text = loaiso;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimChuBai tcb = new TimChuBai();
            tcb.loaiso = loaiso;
            tcb.Show();
        }

        private void btn_ThemSo_Click(object sender, EventArgs e)
        {
            ChuBai cb = new ChuBai();
            cb.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            HienDanhSach();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if(txt_name.Text.Equals(""))
            {

            }
            else
            {
                string nguyenquann = txt_nguyenquan.Text;
                string namee = txt_name.Text;
                FormUpdateChuBai tcb = new FormUpdateChuBai();
                tcb.idso = id; ;
                tcb.nguyenquan = nguyenquann;
                tcb.name = namee;
                tcb.Show();
            }
            

        }

        private void lsv_danhsach_cauan_ItemActivate(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MoveSelectedItemUp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveSelectedItemDown();
        }
        private void MoveSelectedItemUp()
        {
            if (lsv_danhsach_cauan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_danhsach_cauan.SelectedItems[0];
                int currentIndex = selectedItem.Index;

                // Kiểm tra xem mục đã ở đầu danh sách chưa
                if (currentIndex > 0)
                {
                    // Di chuyển mục lên trên
                    lsv_danhsach_cauan.Items.RemoveAt(currentIndex);
                    lsv_danhsach_cauan.Items.Insert(currentIndex - 1, selectedItem);
                    lsv_danhsach_cauan.Items[currentIndex - 1].Selected = true;
                    lsv_danhsach_cauan.Focus();
                }
            }
        }

        private void MoveSelectedItemDown()
        {
            if (lsv_danhsach_cauan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_danhsach_cauan.SelectedItems[0];
                int currentIndex = selectedItem.Index;
                int lastIndex = lsv_danhsach_cauan.Items.Count - 1;

                // Kiểm tra xem mục đã ở cuối danh sách chưa
                if (currentIndex < lastIndex)
                {
                    // Di chuyển mục xuống dưới
                    lsv_danhsach_cauan.Items.RemoveAt(currentIndex);
                    lsv_danhsach_cauan.Items.Insert(currentIndex + 1, selectedItem);
                    lsv_danhsach_cauan.Items[currentIndex + 1].Selected = true;
                    lsv_danhsach_cauan.Focus();
                }
            }
        }

        private void SoCauAn_Shown(object sender, EventArgs e)
        {
            btn_ThemSo.Focus();
        }
    }
}
