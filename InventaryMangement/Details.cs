using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaryMangement
{
    public class Details
    {

        public List<TypesOfRices> typesOfRices;
        public List<TypesOfWheats> typesOfWheats;
        public List<TypesOfPulses> typesOfPulses;
    }
    public class TypesOfRices
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesOfWheats
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesOfPulses
    {
        public string name;
        public int weight;
        public int price;
    }
}