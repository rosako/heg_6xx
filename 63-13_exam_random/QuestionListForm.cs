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
    public partial class QuestionListForm : Form
    {
        public QuestionListForm()
        {
            InitializeComponent();
        }

        public void udpateList(Dictionary<string, Question> questions)
        {
            foreach (var question in questions)
            {
                lbEnabled.Items.Add(question.Value.toListItem());
            }
        }


        public void updateExcludedList(Dictionary<string, Question> questions)
        {
            foreach (var question in questions)
            {
                lbDisabled.Items.Add(question.Value.toListItem());
            }
        }

        private void QuestionListForm_Load(object sender, EventArgs e)
        {

        }

        private void QuestionListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
    }
}
