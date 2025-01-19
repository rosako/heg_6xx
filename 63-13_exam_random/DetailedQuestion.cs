using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class DetailedQuestion : Form
    {
        public static Question globalQuestion;
        public DetailedQuestion(Question question)
        {
             
            InitializeComponent();
            this.Text = $"Question {question.number} - {question.title}";
            this.StartPosition = FormStartPosition.CenterScreen;
            tbDetails.Text = question.description;
            //globalQuestion = question;

            this.KeyDown += closeWindow;


            try
            {
                pbDetails.Image = Image.FromFile(question.imgPath);

                pbDetails.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                pbDetails.Image = Image.FromFile("default.png");
            }
        }


        private void closeWindow(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                this.Close();
            }
        }


        private void DetailedQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
