using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
    public class Cookie
    {
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public int BatchSize { get; set; }
        public bool IsGlutenFree { get; set; }

        public Cookie(string name, string ingredient, int batchSize, bool isGlutenFree)
        {
            Name = name;
            Ingredient = ingredient;
            BatchSize = batchSize;
            IsGlutenFree = isGlutenFree;
        }

        public Cookie()
        {

        }
    }
}
