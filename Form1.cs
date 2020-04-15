using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola2
{
    public partial class Form1 : Form
    {
        int remainingTime = 120, correctNumber = 0, wrongNumber = 0, totalPoints = 0;
        Button[] buttonList = new Button[26];
        Timer remainingTimer = new Timer();

        
        QuestionDictionary qList = new QuestionDictionary();
        string currentQuestion, currentAnswer;
        public Form1()
        {
            InitializeComponent();
            startTimer();
            SetLabels();
            changeQuestion();
        }

        private void startTimer()
        {
            remainingTimer.Interval = 1000;
            remainingTimer.Tick += new EventHandler(changeRemainingTime);
            remainingTimer.Start();
        }

        private void SetLabels()
        {
            foreach (Control c in gamegb.Controls)
            {
                if (c.Name.Length == 7)
                {
                    buttonList[(c.Name[6]-65 )] = (Button)c;
                }
            }
        }
       

        private void changeRemainingTime(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                label5.Text = remainingTime.ToString();
                
            }

            else if (remainingTime == 0)
            {
                showResults();
            }
            remainingTime--;
        }

        private void showResults()
        {
            remainingTimer.Stop();
            //this.Dispose();
            this.Hide();
            Result r = new Result(correctNumber, wrongNumber,totalPoints, remainingTime);
            r.Show();
            //this.Close();
        }

        private void changeQuestion()
        {
            KeyValuePair<string, string> qa = qList.getNextQuestion();
            currentQuestion = qa.Key;
            currentAnswer = qa.Value;

            if (currentAnswer.ToLower() == "gameover" && currentQuestion.ToLower() == "gameover")
            {
                showResults();
            }
            else
            {
                richTextBox1.Text = currentQuestion;
                currenLetterButton.Text = currentAnswer[0].ToString().ToUpper();
                label3.Text = correctNumber.ToString();
                label4.Text = wrongNumber.ToString();
                total.Text = totalPoints.ToString();

            }
        }


        private void checkAnswer()
        {
            string answer = textBox1.Text.ToLower();

            if (currentAnswer[0] == 'I')
            {
                currentAnswer = "i" + currentAnswer.Substring(1);
            }

            if (answer != "" && answer[0] == 'ı')
            {
                answer = "i" + answer.Substring(1);
            }

            if (answer == currentAnswer.ToLower())
            {
       
                buttonList[currenLetterButton.Text[0] - 65].BackColor = System.Drawing.Color.Green;
                totalPoints += 100;
                correctNumber++;
            }
            else
            {
               
                buttonList[(currenLetterButton.Text[0]-65)].BackColor = Color.Red;
                totalPoints -= 200;
                wrongNumber++;
            }

            textBox1.Clear();
            changeQuestion();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            linkLabel1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkAnswer();
        }

    
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            buttonList[currentAnswer[0] - 97].BackColor = System.Drawing.Color.Yellow;
            textBox1.Clear();
            qList.passQuestion(currentQuestion, currentAnswer);
            changeQuestion();
            textBox1.Focus();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
