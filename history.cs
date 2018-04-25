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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
            loadhistory();    
        }
        void loadhistory()
        {
            string query1 = "select* from bang_chi";
            string query2 = "select* from bang_thu";
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query1);
            dataGridView2.DataSource = Dataprovider.Instance.ExecuteQuery(query2);
        }

      
      
    }
}
