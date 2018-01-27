using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5semestr;

namespace _5semestr
{
    public partial class formTheory : System.Windows.Forms.Form
    {
        int i = 0;
        int maxI = TheoryLibrary.Paragraph.Length - 1;
        public formTheory()
        {
            InitializeComponent();
            //вывод текста 0й страницы
            labelTheory.Image = TheoryLibrary.Paragraph[i];
            //вывод заголовка
            labelTitle.Text = TheoryLibrary.Title[i];
            //вывод номера страницы
            labelPage.Text = (i + 1).ToString() + "/" + (maxI + 1).ToString();
            //на первой странице кнопка назад не отображается
            buttonBack.Visible = false;
        }
        //кнопка вперед для страниц текста
        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (buttonBack.Visible == false) buttonBack.Visible = true;
            labelTheory.Image = TheoryLibrary.Paragraph[++i];
            labelTitle.Text = TheoryLibrary.Title[i];
            labelPage.Text = (i + 1).ToString() + "/" + (maxI + 1).ToString();
            //на последней странице кнопка вперед не отображается
            if (i == maxI)
                buttonForward.Visible = false;                
        }
        //кнопка назад для страниц текста
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (buttonForward.Visible == false) buttonForward.Visible = true;
            labelTheory.Image = TheoryLibrary.Paragraph[--i];
            labelTitle.Text = TheoryLibrary.Title[i];
            labelPage.Text = (i + 1).ToString() + "/" + (maxI + 1).ToString();
            if (i == 0)
                buttonBack.Visible = false;
        }
        //кнопка меню
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Program.formStart.Visible = true;
            this.Close();
        }
        //кнопка выход
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
