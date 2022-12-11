namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Topic: {Topic}";
        }
    }
}
