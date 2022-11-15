using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Animals
{
    public class HorseAnimal : IAnimal
    {
        public string Talk()
        {
            return "Neigh";
        }
    }
}
