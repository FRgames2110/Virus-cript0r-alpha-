using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cript0r
{
    public partial class Form2 : Form
    {
        public const int V = 100;

        public Form2()
        {
            InitializeComponent();
        }

        private void DeCript_Click(object sender, EventArgs e)
        {
            //decript files
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FR_Click(object sender, EventArgs e)
        {
            Hide();
            RestartTimer.Start();
        }

        private void RestartTimer_Tick(object sender, EventArgs e)
        {
            Hide();
            
        }

        public void RestartTimer_Finished(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
