using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoC_StackOverflow.Models;

namespace FoC_StackOverflow.Controllers
{
    public class QandAController : Controller
    {
        public IActionResult Index()
        {
            List<Questions> results = DAL.GetAllQuestions();
            return View(results);
        }

        public IActionResult editform(int questid)
        {
            Questions quest = DAL.GetQuestions(questid);
            return View(quest);
        }

        public IActionResult questions(int quest)
        {
            Questions thequestion = DAL.GetQuestions(quest);
            return View(thequestion);
        }

        public IActionResult savequest(Questions quest)
        {
            DAL.UpdateQuestions(quest);
            //return Redirect($"/QandA/questions?quest={quest.id}");
            return Redirect($"/QandA");
        }

        public IActionResult delete(int id)
        {
            DAL.DeleteQuestion(id);
            return Redirect("/QandA");
        }

        public IActionResult addform()
        {
            return View();
        }

        public IActionResult addquest(Questions quest)
        {
            DAL.InsertQuestion(quest);
            
            //return Redirect($"/QandA/questions?quest={quest.id}");
            return Redirect($"/QandA");
        }


        public IActionResult addform_answer(int questid)
        {
            ViewBag.questid = questid;
            return View();
        }

        public IActionResult addanswer(Answers answer)
        {
            DAL.InsertAnswer(answer);
            return Redirect($"/QandA");
        }

        public IActionResult ListAnswers(int questID)
        {
            QuestionAnswers answer = DAL.GetAnswerForQuestion(questID);
            return View(answer);
        }

    }
}
