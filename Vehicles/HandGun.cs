using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    class HandGun : Weapon
    {
        public void SafetyOff()
        {
            Console.WriteLine("Hasta la vista");
        }
        public void SafetyOn()
        {
            Console.WriteLine("Baby");
        }
        public override void Shooting()
        {
            Console.WriteLine("Pew-Pew");
        }
    }
}
