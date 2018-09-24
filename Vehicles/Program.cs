using System;

namespace Unit
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Firing an RPG:");
            RPG rpg = new RPG();
            rpg.BeforeFiring("Back blast area clear");
            rpg.FindTrigger();
            rpg.Shooting();
            rpg.PullTrigger();
            rpg.AfterFiring("This is a big gun");

            Console.WriteLine("\nFiring a Handgun:");
            HandGun handGun = new HandGun();
            handGun.BeforeFiring("Good sight picture");
            handGun.SafetyOff();
            handGun.Shooting();
            handGun.SafetyOn();
            handGun.AfterFiring("Wish I had a bigger gun");

            Console.WriteLine("\nTesting polymorphism");
            Weapon v = handGun;
            v.Shooting();
            v = rpg;
            v.Shooting();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
