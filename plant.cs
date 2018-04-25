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
    public partial class plant : Form
    {
        public plant()
        {
            InitializeComponent();
            loadplant();
            
        }
        void loadplant()
        {
            string query1 = "select* from du_dinh";
            string query2 = "select *from du_dinh";
            //Dataprovider provider = new Dataprovider();
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query1);
            dataGridView2.DataSource = Dataprovider.Instance.ExecuteQuery(query2);
        }

       
      
    }
}
