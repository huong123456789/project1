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


        
   
 void tiendu()
        {
            float chi = tongtienbangchi();
            float thu = tongtienbangthu();
            float tien = thu + chi;
            tbtiendu.Text = tien.ToString();

        }
        float tongtienbangchi()
        {
            int so = dataGridView_BangChi.Rows.Count;
            float tongtien= 0;
            for (int i = 0; i < so-1; i++)
            {
                tongtien+= float.Parse(dataGridView_BangChi.Rows[i].Cells["SỐ TIỀN"].Value.ToString());
                    
            }
            tbtongchi.Text = tongtien.ToString();
            return tongtien;
            
        }
      
        

        float  tongtienbangthu()
        {
            int so = dataGridView_bangthu.Rows.Count;
            float tongtien = 0;
            for (int i = 0; i < so - 1; i++)
            {
                tongtien += float.Parse(dataGridView_bangthu.Rows[i].Cells["SỐ TIỀN"].Value.ToString());

            }
            tbtongthu.Text = tongtien.ToString();
            return tongtien;
        }
        
        // }
        //ham hien thi nhu gia tri len textbox dùng DataBindings
        /*  void addpresent()
          {
              tbtkhoan.DataBindings.Add(new Binding("text", dataGridView_BangChi.DataSource, "[KHOẢN CHI]"));
             // nmsotien.DataBindings.Add(new Binding("value", dataGridView_BangChi.DataSource, "[SỐ TIỀN]"));
              //dateTimePicker3.DataBindings.Add(new Binding("text", dataGridView_BangChi.DataSource, "[NGÀY CHI]"));
              //tbtghichu.DataBindings.Add(new Binding("text", dataGridView_BangChi.DataSource, "[GHI CHÚ]"));

          }*/

        /// <summary>
        ///    Khi nguoi dung click dup chuot vao mot cell nao do, pm se hien thi cac thong tin o dong tuong ung len cac control o ben phai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void dataGridView_BangChi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            nmID.Text = dataGridView_BangChi.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbtkhoan.Text = dataGridView_BangChi.Rows[e.RowIndex].Cells[1].Value.ToString();
            nmsotien.Text = dataGridView_BangChi.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker3.Text = dataGridView_BangChi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbtghichu.Text = dataGridView_BangChi.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void dataGridView_bangthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nmID.Text = dataGridView_bangthu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbtkhoan.Text = dataGridView_bangthu.Rows[e.RowIndex].Cells[1].Value.ToString();
            nmsotien.Text = dataGridView_bangthu.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker3.Text = dataGridView_bangthu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbtghichu.Text = dataGridView_bangthu.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        bool wirte_prentsent(int ID, string khoan, float sotien, string ngay, string ghichu)
        {
            string query;
            if (sotien < 0)
            {
                query = string.Format("INSERT INTO [dbo].[bang_chi] ([KHOẢN CHI],[SỐ TIỀN],[NGÀY CHI],[GHI CHÚ]) VALUES(N'{0}',{1},N'{2}',N'{3}')", khoan, sotien, ngay, ghichu);
            }
            else
            {
                query = string.Format("INSERT INTO [dbo].[bang_thu]([ID],[KHOẢN THU],[SỐ TIỀN],[NGÀY THU],[GHI CHÚ]) VALUES ({0},N'{1}',{2},N'{3}',N'{4}')", ID, khoan, sotien, ngay, ghichu);
            }
            int result = Dataprovider.Instance.ExecutenonQuery(query);
            return result > 0;


        }

        private void write_Click_1(object sender, EventArgs e)
        {
            int ID = (int)nmID.Value;
            string khoan = tbtkhoan.Text;
            float sotien = (float)nmsotien.Value;
            string ngay = dateTimePicker3.Text;
            string ghichu = tbtghichu.Text;

            if (wirte_prentsent(ID, khoan, sotien, ngay, ghichu))
            {
                loadpresent();
            }

        }

        bool repair_prentsent(int ID, string khoan, float sotien, string ngay, string ghichu)
        {
            string query;
            if (sotien < 0)
            {
                query = string.Format("UPDATE [dbo].[bang_chi] SET [KHOẢN CHI] =N'{0}',[SỐ TIỀN] ={1},[NGÀY CHI] =N'{2}' ,[GHI CHÚ] =N'{3}' WHERE [ID] = {4}", khoan, sotien, ngay, ghichu, ID);
            }
            else
            {
                query = string.Format("UPDATE [dbo].[bang_thu] SET [ID] = {0},[KHOẢN THU] =N'{1}',[SỐ TIỀN] ={2},[NGÀY THU] =N'{3}' ,[GHI CHÚ] =N'{4}' WHERE [ID]={5}", ID, khoan, sotien, ngay, ghichu, ID);
            }
            int result = Dataprovider.Instance.ExecutenonQuery(query);
            return result > 0;

        }

        private void repair_Click(object sender, EventArgs e)
        {
            int ID = (int)nmID.Value;
            string khoan = tbtkhoan.Text;
            float sotien = (float)nmsotien.Value;
            string ngay = dateTimePicker3.Text;
            string ghichu = tbtghichu.Text;

            if (repair_prentsent(ID, khoan, sotien, ngay, ghichu))
            {
                loadpresent();

            }


        }
        bool delete_prentsent(int ID,float sotien)
        {
            string query;
            if (sotien < 0)
            {
                query = string.Format("DELETE FROM [dbo].[bang_chi] WHERE ID={0} ", ID);
            }
            else
            {
                query = string.Format("DELETE FROM [dbo].[bang_thu] WHERE ID={0} ", ID);
            }
            int result = Dataprovider.Instance.ExecutenonQuery(query);
            return result > 0;

        }

        private void deleter_Click(object sender, EventArgs e)
        {
            int ID = (int)nmID.Value;
            float sotien = (float)nmsotien.Value;
            
            if (delete_prentsent(ID,sotien))
            {
                loadpresent();

            }
        }
    }

        

       
           
        
        

          

      
