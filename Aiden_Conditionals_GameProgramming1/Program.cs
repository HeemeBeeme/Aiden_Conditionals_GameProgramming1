using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiden_Conditionals_GameProgramming1
{
    internal class Program
    {
        enum WeaponType
        {
            Grenade,
            Fist,
            Knife,
            Pistol,
            Shotgun,
        }


        static int MaxHealth = 100;
        static int Health = 100;

        static string HealthHUD = $"{Health}/{MaxHealth}";

        static void showHUD()
        {
            Console.WriteLine("{0,0}{0,0}{0,0}", $"Health: {HealthHUD}");
        }

        static void Main(string[] args)
        {

            WeaponType weapon = WeaponType.Fist;

            switch (weapon)
            {
                case WeaponType.Grenade:
                    //something
                    break;

                case WeaponType.Fist:
                    //something
                    break;

                case WeaponType.Knife:
                    //something
                    break;

                case WeaponType.Pistol:
                    //something
                    break;

                case WeaponType.Shotgun:
                    //something
                    break;
            }

            showHUD();

            
        }
    }
}
