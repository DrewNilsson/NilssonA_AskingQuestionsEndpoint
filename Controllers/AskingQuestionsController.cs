//Andrew Nilsson
//10/25/22
//Asking Questions
//This is a webapi that gets 2 inputs and returns a string
//Peer review by: Brandon Le - Program works as intended. I was able to input my name and a number into the URL and I was able to get the return of Hello Brandon you woke up at 6. No issues and worked how it should. Good job!


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_AskingQuestions.Controllers
{
    [Route("[controller]")]
    public class AskingQuestionsController : Controller
    {
        [HttpGet]
        [Route("Questions/{myName}/{time}")]

        public string Questions(string myName, string time)
        {
            return $"Hello {myName}. You woke up at {time}";
        }
    }
}