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
    public partial class formTest : Form
    {
        int i = 0;
        int maxI = TestLibrary.Question.Length - 1;
        bool ended = true;
        bool result = false;
        int count = 0;
        public formTest()
        {
            InitializeComponent();
            labelTitle.Text = TestLibrary.Title[i];
            labelQuestion.Image = TestLibrary.Question[i];
            labelResult.Text = "";
            buttonAccept.Text = "Принять";
            labelEnd.Visible = false;
        }
        
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //если тест начат и не завершен, то выводится диалоговое окно для подтверждения выхода
            if (!ended)
            {
                if (MessageBox.Show("Прервать тест?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program.formStart.Visible = true;
                    this.Close();
                }
            }
            else
            {
                Program.formStart.Visible = true;
                this.Close();
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            ended = false;
            if (!result)
            {
                //ввод ответа
                result = true;
                if (answerBox.Text == TestLibrary.Answer[i])
                {
                    labelResult.Text = "Верно";
                    count++;
                }
                else
                    labelResult.Text = "Неверно, " + TestLibrary.Answer[i];
                buttonAccept.Text = "Далее";
                if (i == maxI)
                {
                    ended = true;
                    buttonAccept.Visible = false;
                    label1.Visible = false;
                    labelResult.Visible = false;
                    answerBox.Visible = false;
                    labelQuestion.Visible = false;
                    labelTitle.Visible = false;
                    labelEnd.Visible = true;
                    labelEnd.Text = count.ToString() + "/" + TestLibrary.Answer.Length.ToString();
                }
                i++;
            }
            else
            {
                //переход к следующему вопросу
                result = false;
                labelTitle.Text = TestLibrary.Title[i];
                labelQuestion.Image = TestLibrary.Question[i];
                labelResult.Text = "";
                answerBox.Clear();
                buttonAccept.Text = "Принять";
            } 
        }
    }
}
