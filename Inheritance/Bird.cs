using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public double MaxWingSpan { get; set; }
        public bool CanFly { get; set; }
        public bool IsWarmBlooded { get; set; }
        public bool HasFeathers { get; set; }

        public Bird()
        {

        }

        public Bird(string name, int maxage, int legs, bool hasbackbone, double wingspan, bool canfly, bool iswarmblooded, bool hasfeathers)
        {
            Name = name;
            MaxAge = maxage;
            Legs = legs;
            HasBackBone = hasbackbone;
            MaxWingSpan = wingspan;
            CanFly = canfly;
            IsWarmBlooded = iswarmblooded;
            HasFeathers = hasfeathers;

        }

    }
}
