using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

        static string weaponName;
        static string Status;

        static int MaxHealth = 100;
        static int Health = 100;

        static string HealthHUD = $"{Health}/{MaxHealth}";
        static string HealthStatus()
        {

            if (Health == 100 & Health > 90)
            {
                Status = "Perfectly Healthy!";
            }
            else if (Health > 60 && Health < 90)
            {
                Status = "Healthy!";
            }
            else if (Health > 30 && Health < 60)
            {
                Status = "Hurt";
            }
            else if (Health > 1 && Health < 30)
            {
                Status = "Critical Health!";
            }
            else if(Health == 0 && Health < 0)
            {
                Health = 0;
                Status = "You are Dead!";
            }

                return Status;
        }

        static void showHUD()
        {
            HealthStatus();

            Console.WriteLine("{0,0}{1,30}{2,15}", $"Health: {HealthHUD}", $"Status: {Status}", $"Weapon: {weaponName}");
        }

        static void Main(string[] args)
        {

            WeaponType weapon = WeaponType.Fist;

            switch (weapon)
            {
                case WeaponType.Grenade:
                    weaponName = "Grenade";
                    break;

                case WeaponType.Fist:
                    weaponName = "Fist";
                    break;

                case WeaponType.Knife:
                    weaponName = "Knife";
                    break;

                case WeaponType.Pistol:
                    weaponName = "Pistol";
                    break;

                case WeaponType.Shotgun:
                    weaponName = "Shotgun";
                    break;
            }

            Health -= 10;
            Console.WriteLine($"{Health}");
            showHUD();
            Console.WriteLine();
            Console.WriteLine("You are walking in the forest and you step on some thorns!");

            Console.ReadKey();

            
        }
    }
}
