using Day1Speedrun.Models;
using Day1Speedrun.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day1Speedrun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly FoodService _foodService;

        public FoodController(FoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_foodService.GetAll());
        }

        [HttpPost]
        public IActionResult Add(Food food)
        {
            _foodService.Add(food);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Food food)
        {
            _foodService.Update(id, food);

            return Ok(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _foodService.DeleteById(id);

            return Ok("Food was deleted successfully");
        }
    }
}
