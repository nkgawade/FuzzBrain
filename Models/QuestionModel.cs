using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuzzBrain.Models
{
    public class QuestionModel
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }


        public static List<QuestionModel> GetReactQuestionList()
        {
            return new List<QuestionModel>
            {
                new QuestionModel
                {
                    QuestionId = 1,
                    Question = "In which directory React Components are saved?",
                    Option1 = "Class",
                    Option2 = "Module",
                    Option3 = "Package",
                    Option4 = "Component"
                },
                new QuestionModel
                {
                    QuestionId = 2,
                    Question = "What is used in ReactJs to increase performance?",
                    Option1 = "Both B and c",
                    Option2 = "Original DOM",
                    Option3 = "Virtual DOM",
                    Option4 = "None of the above"
                },
                new QuestionModel
                {
                    QuestionId = 3,
                    Question = "Default port where webpack-server will run",
                    Option1 = "8080",
                    Option2 = "3333",
                    Option3 = "3030",
                    Option4 = "6020"
                },
                new QuestionModel
                {
                    QuestionId = 4,
                    Question = "What is ReactJs?",
                    Option1 = "Server side framework",
                    Option2 = "A Library for building interaction interfaces",
                    Option3 = "Client Side Framework",
                    Option4 = "None of the above"
                },
                new QuestionModel
                {
                    QuestionId = 5,
                    Question = "What is state in react",
                    Option1 = "A prement storage",
                    Option2 = "Internal storage of the component",
                    Option3 = "Both A and B",
                    Option4 = "None of the above"
                }
            };
        }
    }
}