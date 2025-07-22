namespace Day1Speedrun.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> Ingredients { get; set; }

        public bool IsVegan { get; set; }
    }
}
