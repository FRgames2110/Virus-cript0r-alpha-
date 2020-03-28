using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Timers;
using System.Xml;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;


namespace cript0r
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void InFO_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Do not change the text that was written in there", "CrIpt0R.@.exe");
            Application.Restart();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void KillTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
        }
    }
}
