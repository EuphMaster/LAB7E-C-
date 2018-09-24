using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    class Weapon
    {
        public void BeforeFiring(string beforeFiringSound)
        {
            Console.WriteLine($"Thinking to myself: {beforeFiringSound}");
        }
        public void AfterFiring(string afterFiringSound)
        {
            Console.WriteLine($"Saying out loud: {afterFiringSound}");
        }
        public virtual void Shooting()
        {
            Console.WriteLine("Default implementation of the Shoot method");
        }
    }
}
