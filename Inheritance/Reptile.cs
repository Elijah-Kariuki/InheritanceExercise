using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animal
    {
        public string Environment { get; set; }
        public string ExternalCovering { get; set; }
        public bool IsColdBlooded { get; set; }
        public string Defense { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, int age, int legs, bool hasbackbone, string environment, string externalcovering, bool iscoldblooded, string defense)
        {
            Name = name;
            MaxAge = age;
            Legs = legs;
            HasBackBone = hasbackbone;
            Environment = environment;
            ExternalCovering = externalcovering;
            IsColdBlooded = iscoldblooded;
            Defense = defense;

        }

    }

   

}
