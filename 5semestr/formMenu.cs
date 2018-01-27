using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5semestr
{
    public partial class formMenu : System.Windows.Forms.Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            new formTest().Show();
            this.Visible = false;
        }
        
        private void buttonExample_Click(object sender, EventArgs e)
        {
            new formExample().Show();
            this.Visible = false;
        }

        private void buttonTheory_Click(object sender, EventArgs e)
        {
            new formTheory().Show();
            this.Visible = false;
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
