
using EightToTen.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;


namespace EightToTen.Controllers;


    [ApiController]
    [Route("GuessIt")]
    public class GuessController : Controller
    {
        private readonly IGuessService _guessService;

        public GuessController(IGuessService guessService)
        {
            _guessService = guessService;
        }

        [HttpGet]
        [Route("Easy/Number1-10/{number}")]

        public string EasyGuess(string number)
        {
            return _guessService.EasyGuess(number);
        }

        [HttpGet]
        [Route("Medium/Number1-50/{number}")]

        public string MediumGuess(string number)
        {
            return _guessService.MediumGuess(number);
        }

        [HttpGet]
        [Route("Hard/Number1-100/{number}")]

        public string HardGuess(string number)
        {
            return _guessService.HardGuess(number);
        }



    }
