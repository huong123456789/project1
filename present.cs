using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class present : Form
    {
        public present()
        {
            /// Tao ra cac control tren giao dien
            InitializeComponent();
            /// Nap du lieu len cac dieu khien tren giao dien
            loadpresent();
            //addpresent();
        }

        void loadpresent()
        {
            string query1 = "select * from bang_chi";
            string query2 = "select * from bang_thu";
            /// Lay du lieu tu DB va hien thi len giao dien
            dataGridView_BangChi.DataSource = Dataprovider.Instance.ExecuteQuery(query1);
            dataGridView_bangthu.DataSource = Dataprovider.Instance.ExecuteQuery(query2);
        }


        
      //ham  insert su dung khi nhan vao write
         void wirte_prentsent(string khoan, float sotien, string ngay, string ghichu)
        {
            string query;
            if (sotien <= 0)
            {
                query = string.Format("INSERT INTO [dbo].[bang_chi] ([KHOẢN CHI],[SỐ TIỀN],[NGÀY CHI],[GHI CHÚ]) VALUES(N'(1)',(2),N'(3)',N'(4)')", khoan, sotien, ngay, ghichu);
            }
            else
            {
                query = string.Format("INSERT INTO [dbo].[bang_thu]([ID],[KHOẢN THU],[SỐ TIỀN],[NGÀY THU,[GHI CHÚ])VALUES(N'(1)',(2),N'(3)',N'(4)')", khoan, sotien, ngay, ghichu);
            }
            int result = Dataprovider.Instance.ExecutenonQuery(query);
//            loadpresent();

        }
        private void write_Click(object sender, EventArgs e)
        {
            string khoan = tbtkhoan.Text;
            float sotien = (float)nmsotien.Value;
            string ngay = dateTimePicker3.Text;
            string ghichu = tbtghichu.Text;

            wirte_prentsent(khoan, sotien, ngay, ghichu);
            loadpresent();
        }
         

                /*  SqlConnection connection = new SqlConnection(Dataprovider.connectionstr);
              connection.Open();
              int currentIndex1 = dataGridView_BangChi.CurrentCell.RowIndex;
              int currentIndex = dataGridView_bangthu.CurrentCell.RowIndex;
              connection.Close();*/

         // }
        //ham hien thi nhu gia tri len textbox
     /*   void addpresent()
        {
            tbtkhoan.DataBindings.Add(new Binding("text", dataGridView_BangChi.DataSource, "[KHOẢN CHI]"));
            nmsotien.DataBindings.Add(new Binding("value", dataGridView_BangChi.DataSource, "[SỐ TIỀN]"));
            dateTimePicker3.DataBindings.Add(new Binding("text", dataGridView_BangChi.DataSource, "[NGÀY CHI]"));
            tbtghichu.DataBindings.Add(new Binding("text", dataGridView_BangChi.DataSource, "[GHI CHÚ]"));

        }
        */

       
           
        
        

          

        /// <summary>
        ///    Khi nguoi dung click dup chuot vao mot cell nao do, pm se hien thi cac thong tin o dong tuong ung len cac control o ben phai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
          private void dataGridView_BangChi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
          {
              //MessageBox.Show("Dung roi");
             Debug.WriteLine("Nguoi dung bam dup vao cell o vi tri dong {0}, cot {1}",e.RowIndex, e.ColumnIndex);
              Debug.WriteLine("Hien thi tam du lieu {1}", dataGridView_BangChi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              int numrow;
              numrow = e.RowIndex;
              tbtID.Text = dataGridView_BangChi.Rows[numrow].Cells[1].Value.ToString();
              tbtkhoan.Text = dataGridView_BangChi.Rows[numrow].Cells[2].Value.ToString();
          }

         
        }
    }
