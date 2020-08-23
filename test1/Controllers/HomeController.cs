using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        public class Student
        {
            public string id { get; set; }
            public string name { get; set; }
            public int score { get; set; }
            public Student()
            {
                id = string.Empty;
                name = string.Empty;
                score = 0;
            }
            public Student(string _id, string _name, int _score)
            {
                id = _id;
                name = _name;
                score = _score;
            }
            public override string ToString()
            {
                return $"學號:{id}, 姓名:{name}, 分數:{score}.";
            }
        }

        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
           
            Student data = new Student("1", "小明", 80);
            return View(data);
                                   
            
        }

        public ActionResult Transcripts(string id, string name, int score)
        {
            Student data = new Student(id, name, score);
            return View(data);
        }
    }
}