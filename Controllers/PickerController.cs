
using EightToTen.Services.RestPicker;
using Microsoft.AspNetCore.Mvc;


namespace EightToTen.Controllers;


    [ApiController]
    [Route("RestaurantPicker")]
    public class PickerController : Controller
    {
      private readonly IPickerService _pickerService;

      public PickerController(IPickerService pickerService)
      {
        _pickerService = pickerService;
      }

      [HttpGet]
      [Route("Pizza,Fast Food, Mexican/{choice}")]

      public string RestaurantPicker(string choice)
      {
        return _pickerService.RestaurantPicker(choice);
      }
    }
