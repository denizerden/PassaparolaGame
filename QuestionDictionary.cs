using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passaparola2
{
   
    class QuestionDictionary
    {
        SqlConnection conn = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=PassaparolaGame;Integrated Security=True");

        private Dictionary<string, string> gameQuestions;
        private Dictionary<string, string> passedQuestions = new Dictionary<string, string>();
        IEnumerator nextQuestion;

        public QuestionDictionary()
        {
            this.gameQuestions = new Dictionary<string, string>();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from QuestionDictionary", conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                string question = dr.GetString(1);
                string answer = dr.GetString(2);
                gameQuestions.Add(question, answer);
            }
            conn.Close();

            nextQuestion = gameQuestions.GetEnumerator();

        }

        public KeyValuePair<string, string> getNextQuestion()
        {
            bool iterated = nextQuestion.MoveNext();
            if (iterated)
            {
                KeyValuePair<string, string> currentQuestion = (KeyValuePair<string, string>)nextQuestion.Current;
                return currentQuestion;
            }
            else
            {
                gameQuestions.Clear();
                foreach (KeyValuePair<string, string> qa in passedQuestions)
                {
                    gameQuestions.Add(qa.Key, qa.Value);
                }

                if (gameQuestions.Count == 0)
                {
                    return new KeyValuePair<string, string>("Game", "Over");
                }
                else
                {
                    passedQuestions.Clear();
                    nextQuestion = gameQuestions.GetEnumerator();
                    nextQuestion.MoveNext();
                    KeyValuePair<string, string> currentQuestion = (KeyValuePair<string, string>)nextQuestion.Current;
                    return currentQuestion;
                }
            }
        }

        public void passQuestion(string question, string answer)
        {
            passedQuestions.Add(answer, question);
        }

    }
}
