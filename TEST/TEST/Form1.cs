using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
        List<Question> listQuestion;
        List<RadioButton> listAnswer;
        private int questionIndex;
        public Form1()
        {
            InitializeComponent();
            InitializeAnswerRadioButtons();
            InitalizeQuestion();
            ShowCurrentQuestion();
        }
        private void InitalizeQuestion()
        {
            listQuestion = new List<Question>
            {
                new Question("Câu 1: 1+2= ?", "C. 3", new List<string> {"A. 1","B. 2","C. 3","D. 4"}),
                new Question("Câu 2: Bạn tên là ?", "B. Quang", new List<string> {"A. Tèo","B. Quang","C. Bi","D. Tú"}),
                new Question("Câu 3: Bạn học trường ?", "D. HUIT", new List<string> {"A. UEH","B. UEF","C. HUFLIT","D. HUIT"}),
            };
            questionIndex = 0;
        }
        private void InitializeAnswerRadioButtons()
        {
            listAnswer = new List<RadioButton>
            {
                rbtn_A,
                rbtn_B,
                rbtn_C,
                rbtn_D
            };
        }
        private void ShowCurrentQuestion()
        {
            if (questionIndex < listQuestion.Count)
            {
                Question currentQuestion = listQuestion[questionIndex];
                lb_Question.Text = currentQuestion.questionText;
                UpdateAnswerRadioButtons(currentQuestion.answers);
            }
            else
            {
                MessageBox.Show("Hoàn thành kiểm tra!");
            }
        }
        private void ClearAnswerRadioButtons()
        {
            rbtn_A.Checked = false;
            rbtn_B.Checked = false;
            rbtn_C.Checked = false;
            rbtn_D.Checked = false;
        }
        private void UpdateAnswerRadioButtons(List<string> answers)
        {
            if (listAnswer == null || answers == null || listAnswer.Count != answers.Count)
            {
                MessageBox.Show("Không có đáp án hoặc số lượng câu trả lời không khớp.");
                return;
            }

            for (int i = 0; i < answers.Count; i++)
            {
                listAnswer[i].Text = answers[i];
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (questionIndex < listQuestion.Count)
            {
                Question currentQuestion = listQuestion[questionIndex];
                string userAnswer = GetSelectedAnswer();

                if (userAnswer == currentQuestion.answer)
                {
                    MessageBox.Show("Bạn đã làm đúng :)");
                    questionIndex++;
                    ShowCurrentQuestion();
                }
                else
                {
                    MessageBox.Show("Câu trả lời sai. Bạn bị trừ điểm :(");
                    questionIndex++;
                    ShowCurrentQuestion();
                }
            }
        }
        private string GetSelectedAnswer()
        {
            if (rbtn_A.Checked)
                return rbtn_A.Text;
            if (rbtn_B.Checked)
                return rbtn_B.Text;
            if (rbtn_C.Checked)
                return rbtn_C.Text;
            else
                return rbtn_D.Text;
        }
    }
}
