using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
            loadsearch();
        }
        void loadsearch()
        {
            string query1 = "select * from quanlythe";
            string query2 = "select *from vayvon";
            string query3 = "select *from chovay";
            //Dataprovider provider = new Dataprovider();
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query1);
            dataGridView2.DataSource = Dataprovider.Instance.ExecuteQuery(query2);
            dataGridView3.DataSource = Dataprovider.Instance.ExecuteQuery(query3);
        }
       

       
    }
}
