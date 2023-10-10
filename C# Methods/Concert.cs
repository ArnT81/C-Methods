using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace C__Methods
{
    public class Concert
    {
        public int Id { get; set; }
        public bool ReducedVenue { get; set; }
        public DateTime Date { get; set; }
        public string Performer { get; set; }
        public int BeginsAt { get; set; }
        public int FullCapacitySales { get; set; }
    }
}
