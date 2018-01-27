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
    public partial class formExample : Form
    {
        int i = 0;
        int maxI = ExampleLibrary.Title.Length - 1;
        public formExample()
        {
            InitializeComponent();
            labelExample.Image = ExampleLibrary.Paragraph[i];
            labelTitle.Text = ExampleLibrary.Title[i];
            labelPage.Text = (i + 1).ToString() + "/" + (maxI + 1).ToString();
            buttonBack.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Program.formStart.Visible = true;
            this.Close();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (buttonBack.Visible == false) buttonBack.Visible = true;
            labelExample.Image = ExampleLibrary.Paragraph[++i];
            labelTitle.Text = ExampleLibrary.Title[i];
            labelPage.Text = (i + 1).ToString() + "/" + (maxI + 1).ToString();
            //на последней странице кнопка вперед не отображается
            if (i == maxI)
                buttonForward.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (buttonForward.Visible == false) buttonForward.Visible = true;
            labelExample.Image = ExampleLibrary.Paragraph[--i];
            labelTitle.Text = ExampleLibrary.Title[i];
            labelPage.Text = (i + 1).ToString() + "/" + (maxI + 1).ToString();
            if (i == 0)
                buttonBack.Visible = false;
        }
    }
}
