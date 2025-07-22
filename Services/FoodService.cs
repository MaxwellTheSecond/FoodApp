using Day1Speedrun.Models;

namespace Day1Speedrun.Services
{

    public class FoodService
    {
        private Random _random = new Random();

        private List<Food> _context = new List<Food>()
        {
            new Food {Id = 1, Name = "Pasta Carbonara", Ingredients = new List<string> { "Pasta", "Guanciale", "Egg", "Whatever" }, IsVegan = false},
            new Food {Id = 2, Name = "Egg Toast", Ingredients = new List<string> { "Egg", "Toast"}, IsVegan = false },
            new Food {Id = 3, Name = "Green Salad", Ingredients = new List<string> { "Lettuce", "Tomatoes", "Olives"}, IsVegan = true }
        };

        public FoodService() { }

        public List<Food> GetAll()
        {
            return _context;
        }

        public Food? GetById(int id)
        {
            return _context.FirstOrDefault(f => f.Id == id);
        }

        public int Add(Food food)
        {
            _context.Add(food);

            return food.Id;
        }

        public void DeleteById(int id)
        {
            var foodToDelete = _context.FirstOrDefault(f => f.Id == id);

            if (foodToDelete is null)
                return;

            _context.Remove(foodToDelete);
        }

        public Food? FindByName(string name)
        {
            return _context.FirstOrDefault(f => f.Name == name);
        }

        public Food Update(int id, Food food)
        {
            int indexToModify = _context.FindIndex(f => f.Id == id);

            _context[indexToModify] = food;

            return food;
        }

        public Food? GetRandom()
        {
            int randomElementId = _random.Next(1, _context.Count);

            return _context.FirstOrDefault(f => f.Id == randomElementId);
        }
    }

}