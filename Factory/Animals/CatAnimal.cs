using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Animals
{
    public class CatAnimal : IAnimal
    {
        public string Talk()
        {
            return "Meow";
        }
    }
}
