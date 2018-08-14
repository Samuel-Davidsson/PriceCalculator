using System.Collections.Generic;

namespace Calculator.Domain
{
    public class Category
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Id { get; set; }
        public bool IsMultiSelectable { get; set; }
        public bool IsColapsed { get; set; }

        public IEnumerable<Product> Products { get; set; }

    }
}