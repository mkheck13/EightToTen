
using EightToTen.Services.MagicEight;
using Microsoft.AspNetCore.Mvc;


namespace EightToTen.Controllers;


    [ApiController]
    [Route("Magic8Ball")]
    public class MagicController : Controller
    {
       private readonly IMagicService _magicService;

       public MagicController(IMagicService magicService)
       {
        _magicService = magicService;
       }

       [HttpGet]
       [Route("Fortune")]

       public string Fortune()
       {
        return _magicService.Fortune();
       }
    }
