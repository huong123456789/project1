using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class TableMain : Form
    {
       
       
        public TableMain()
        {
            InitializeComponent();
     
         }

        private void đăngXuấtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            account f = new account();
            f.ShowDialog();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            present f = new present();
            f.ShowDialog();
        }

       

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history f = new history();
            f.ShowDialog();
        }


        private void dựĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plant f = new plant();
            f.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search f = new search();
            f.ShowDialog();
        }

        

        private void tàiKhoảnTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search f = new search();
            f.ShowDialog();
            
        }

        private void vayVốnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search f = new search();
            f.ShowDialog();
        }


        
    }
}
