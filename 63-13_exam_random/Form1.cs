using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace Exam
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, Question> currentQuestions = new Dictionary<string, Question>();
        public static Dictionary<string, Question> excludedQuestions = new Dictionary<string, Question>();
        public HashSet<int> exclusions = new HashSet<int>();
        public static Question q1, q2;
        public static bool canModal = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            exclusions.Add(int.Parse(lblChoix1.Text));
        }

        private void btnLancer_MouseClick(object sender, MouseEventArgs e)
        {

            //Question q1, q2;

            (q1, q2) = Tools.randomTwoQuestions(currentQuestions);

            //Question q1 = Tools.randomQuestion(currentQuestions);
            lblChoix1.Text = q1.number;
            lblTitle1.Text = q1.title;
            tbDesc1.Text = q1.description;
            try
            {
                pbChoix1.Image = Image.FromFile(q1.imgPath);

                //TODO remove, that's for testing
                pbChoix1.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                pbChoix2.Image = Image.FromFile("default.png");
            }
           

            Thread.Sleep(50);

            //Question q2 = Tools.randomQuestion(currentQuestions);
            lblChoix2.Text = q2.number;
            lblTitle2.Text = q2.title;
            tbDesc2.Text = q2.description;

            try
            {
                pbChoix2.Image = Image.FromFile(q2.imgPath);
                pbChoix2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                pbChoix2.Image = Image.FromFile("default.png");
            }

            btnChoix1.Visible = true;
            btnChoix2.Visible = true;
            canModal = true;
            btnLancer.Visible = false;
            pbChoix1.Visible = true;
            pbChoix2.Visible = true;
        }

        private void lblChoix1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void lblChoix1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void lblChoix2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void lblChoix2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string savedStatePath = "saved_state.csv";
            string allQuestionsPath = "exa_63_13_data.csv";

            if (File.Exists(savedStatePath))
            {
                DialogResult result = MessageBox.Show("Une session entamée a été détectée, voulez-vous la récupérer?", "Récupération", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    currentQuestions = Question.loadCSV(savedStatePath);
                }
                else if (result == DialogResult.No)
                {
                    currentQuestions = Question.loadCSV(allQuestionsPath);
                }
            }
            else
            {
                currentQuestions = Question.loadCSV(allQuestionsPath);
            }

            //currentQuestions = Question.loadCSV("exa_63_13_data.csv");
            //File.WriteAllText("saved_63-13.csv", "");

            resetChoix();
        }

        private void lblChoix2_Click(object sender, EventArgs e)
        {
           // exclusions.Add(int.Parse(lblChoix2.Text));
        }

        private void btnChoix1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous certain de votre choix?", "Choix de question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                excludedQuestions.Add(lblChoix1.Text, q1);
                currentQuestions.Remove(lblChoix1.Text);
                btnLancer.Visible = true;
                resetChoix();
            }
            else if (result == DialogResult.No)
            {
                Console.WriteLine("Abandon du choix");
            }
            
            Console.WriteLine($"current number of questions : {currentQuestions.Count}");
        }

        private void btnChoix2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous certain de votre choix?", "Choix de question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                excludedQuestions.Add(lblChoix2.Text, q2);
                currentQuestions.Remove(lblChoix2.Text);
                btnLancer.Visible = true;
                resetChoix();
            }

            else if (result == DialogResult.No)
            {
                Console.WriteLine("Abandon du choix");
            }
            //currentQuestions.Remove(lblChoix2.Text);
            Console.WriteLine($"current number of questions : {currentQuestions.Count}");
        }

        private void resetChoix()
        {
            canModal = false;
            //lblQuestions.Text = $"Questions restantes : {currentQuestions.Count}";
            lblChoix1.Text = "--";
            lblChoix2.Text = "--";
            lblTitle1.Text = "--";
            lblTitle2.Text = "--";
            tbDesc1.Text = string.Empty;
            tbDesc2.Text = string.Empty;
            btnChoix1.Visible = false;
            btnChoix2.Visible = false;
            pbChoix1.Visible = false;
            pbChoix2.Visible = false;
            saveCurrentQuestions();
            if (currentQuestions.Count < 2)
            {
                btnLancer.Visible = false;
                lblQuestions.Text = "Plus de questions disponibles";
            }

        }

        private void saveCurrentQuestions()
        {
            using (StreamWriter writer = new StreamWriter("saved_state.csv", append: false))
            {
                foreach (var q in currentQuestions.Values)
                {
                    writer.WriteLine(q.toCSV());
                }
            }
        }

        private void tbDesc1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbDesc2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbDesc2_DoubleClick(object sender, EventArgs e)
        {
            showModalQuestion(q2);
        }

        private void tbDesc1_DoubleClick(object sender, EventArgs e)
        {
            showModalQuestion(q1);
        }

        private void pbChoix1_Click(object sender, EventArgs e)
        {
            showModalQuestion(q1);
        }

        private void pbChoix2_Click(object sender, EventArgs e)
        {
            showModalQuestion(q2);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void showModalQuestion(Question question)
        {
            if (canModal)
            {
                DetailedQuestion modal = new DetailedQuestion(question);
                modal.Show();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showQuestionListView();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.L)
            {
                showQuestionListView();
            }
        }

        private void showQuestionListView()
        {
            QuestionListForm questionListForm = new QuestionListForm();
            questionListForm.udpateList(currentQuestions);
            questionListForm.updateExcludedList(excludedQuestions);
            questionListForm.Show();
        }
    }
}
