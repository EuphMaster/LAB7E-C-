using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit
{
    class RPG : Weapon
    {
        public void FindTrigger()
        {
            Console.WriteLine("Hello");
        }
        public void PullTrigger()
        {
            Console.WriteLine("Good-bye");
        }
        public override void Shooting()
        {
            Console.WriteLine("Wa-poom!");
        }
    }
}
