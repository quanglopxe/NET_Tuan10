using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TEST
{
    public partial class Form1 : Form
    {
        string conStr = "Data Source=A209PC38;Initial Catalog=TEST;Integrated Security=True";
        List<Question> listQuestion;
        List<RadioButton> listAnswer;
        private int questionIndex;

        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr;

            listQuestion = new List<Question>();
            questionIndex = 0;
            LoadQuestions();
            ShowCurrentQuestion();
        }

        private void LoadQuestions()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Question";

                    using (SqlDataReader rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string questionText = rdr["QuestionText"].ToString();
                            string answerA = rdr["AnswerA"].ToString();
                            string answerB = rdr["AnswerB"].ToString();
                            string answerC = rdr["AnswerC"].ToString();
                            string answerD = rdr["AnswerD"].ToString();
                            string correctAnswer = rdr["CorrectAnswer"].ToString();

                            Question question = new Question(questionText, answerA, answerB, answerC, answerD, correctAnswer);
                            listQuestion.Add(question);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowCurrentQuestion()
        {
            if (questionIndex < listQuestion.Count)
            {
                btn_Result.Enabled = false;
                Question currentQuestion = listQuestion[questionIndex];
                lb_Question.Text = currentQuestion.QuestionText;
                rbtn_A.Text = currentQuestion.AnswerA;
                rbtn_B.Text = currentQuestion.AnswerB;
                rbtn_C.Text = currentQuestion.AnswerC;
                rbtn_D.Text = currentQuestion.AnswerD;
            }
            else
            {
                MessageBox.Show("Hoàn thành kiểm tra!");
                btn_Result.Enabled = true;
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
            if (rbtn_D.Checked)
                return rbtn_D.Text;

            return string.Empty;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (questionIndex < listQuestion.Count)
            {
                Question currentQuestion = listQuestion[questionIndex];
                string userAnswer = GetSelectedAnswer();

                if (userAnswer == currentQuestion.CorrectAnswer)
                {
                    MessageBox.Show("Bạn đã làm đúng :)");
                }
                else
                {
                    MessageBox.Show("Bạn đã làm sai :(");
                }

                questionIndex++;
                ShowCurrentQuestion();
            }
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (questionIndex < listQuestion.Count)
            {
                Question currentQuestion = listQuestion[questionIndex];
                string userAnswer = GetSelectedAnswer();

                if (userAnswer == currentQuestion.CorrectAnswer)
                {
                    score++;
                }
            }
            MessageBox.Show("Số điểm của bạn là: " + score + "/" + listQuestion.Count);
        }
    }
}