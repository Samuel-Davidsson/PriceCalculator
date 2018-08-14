using Calculator.Domain;
using System;
using System.Collections.Generic;

namespace Calculator.Data
{
    public class ProductData
    {
        public static ProductData Current { get; } = new ProductData();
        public List<Productgroup> ProductGroups { get; set; }

        public ProductData()
        {

            
        }
    }
}

            