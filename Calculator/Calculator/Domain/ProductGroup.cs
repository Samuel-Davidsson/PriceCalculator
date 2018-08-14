using System.Collections.Generic;

namespace Calculator.Domain
{
    public class Productgroup
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
