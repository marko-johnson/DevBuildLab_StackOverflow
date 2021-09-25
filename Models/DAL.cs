using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace FoC_StackOverflow.Models
{
    public class DAL
    {
        //public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=foc_stackoverflow;Uid=root;Password=abc123");
        public static MySqlConnection DB;

        public static QuestionAnswers GetAnswerForQuestion(int thequestID)
        {
            var keyvalues = new { questID = thequestID };
            string sql = "select * from answers where questionid = @questID";

            QuestionAnswers qa = new QuestionAnswers();
            qa.answer = DB.Query<Answers>(sql, keyvalues).ToList();
            qa.quest = DAL.GetQuestions(thequestID);
            return qa;

        }

        public static List<Questions> GetAllQuestions()
        {
            return DB.GetAll<Questions>().ToList();
        }

        public static Questions GetQuestions(int id)
        {
            return DB.Get<Questions>(id);
        }
                

        public static void UpdateQuestions(Questions quest)
        {
            DB.Update(quest);
        }

        public static void DeleteQuestion(int id)
        {
            Questions quest = new Questions();
            quest.id = id;
            DB.Delete<Questions>(quest);
        }

        public static void InsertQuestion(Questions quest)
        {
            DB.Insert(quest);
        }


        public static void InsertAnswer(Answers answer)
        {
            DB.Insert(answer);
        }
    }
}
