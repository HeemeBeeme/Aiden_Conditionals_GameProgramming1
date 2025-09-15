using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Fist,
            Grenade,
            Knife,
            Pistol,
            Shotgun
        }

        static string weaponName;
        static WeaponType weapon = WeaponType.Fist;

        static string Status;
        static int CapableDamage;
        static int MaxHealth = 100;
        static int Health = 100;
        static int TakenDmG;
        static int PotionPotency;
        static string PotionName;

        enum PotionType
        {
            Weak_Potion,
            Moderate_Potion,
            Strong_Potion
        }
        static PotionType potion = PotionType.Weak_Potion;

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

        static void HealText()
        {
            Console.WriteLine($"You heal yourself with a {PotionName} for {PotionPotency} Health!");
        }

        static void SkipLine()
        {
            Console.WriteLine();
        }
        static void showHUD()
        {
            HealthStatus();

            switch (weapon)
            {
                case WeaponType.Grenade:
                    weaponName = "Grenade";
                    CapableDamage = DamageRnD.Next(10, 40);
                    break;

                case WeaponType.Fist:
                    weaponName = "Fist";
                    CapableDamage = DamageRnD.Next(2, 5);
                    break;

                case WeaponType.Knife:
                    weaponName = "Knife";
                    CapableDamage = DamageRnD.Next(3, 10);
                    break;

                case WeaponType.Pistol:
                    weaponName = "Pistol";
                    CapableDamage = DamageRnD.Next(7, 20);
                    break;

                case WeaponType.Shotgun:
                    weaponName = "Shotgun";
                    CapableDamage = DamageRnD.Next(20, 35);
                    break;
            }

            Console.WriteLine("{0,0}{1,30}{2,20}", $"Health: {Health}/{MaxHealth}", $"Status: {Status}", $"Weapon: {weaponName}");
        }

        static Random DamageRnD = new Random();
        static Random WeaponRnD = new Random();
        static Random TakenDmgRnD = new Random();
        static Random PotionRnD = new Random();


        static void RandomWeapon()
        {
            int WeaponNumb = WeaponRnD.Next(1, 4);
            weapon = (WeaponType)WeaponNumb;
        }

        static void RandomPotion()
        {
            int PotionNumb = PotionRnD.Next(0,2);
            potion = (PotionType)PotionNumb;

            switch (potion)
            {
                case PotionType.Weak_Potion:
                    PotionName = "Weak Potion";
                    PotionPotency = 10;
                    break;
                case PotionType.Moderate_Potion:
                    PotionName = "Moderate Potion";
                    PotionPotency = 25;
                    break;
                case PotionType.Strong_Potion:
                    PotionName = "Strong Potion";
                    PotionPotency = 50;
                    break;
            }

            Health += PotionPotency;

        }

        static void DamageDealt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Damage Dealt: {CapableDamage}");
            Console.ResetColor();
        }

        static void DamageTaken()
        {
            TakenDmG = TakenDmgRnD.Next(6, 25);
            Health -= TakenDmG;
        }

        static void DamageTakenText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Damage Taken: {TakenDmG}");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {

            showHUD();
            SkipLine();
            Console.WriteLine("You are walking in the forest...");
            SkipLine();
            Console.ReadKey();
            Console.Clear();

            Health -= 10;
            showHUD();
            SkipLine();
            Console.WriteLine("Ahh! You step into some thorns!");
            SkipLine();
            Console.ReadKey();
            Console.Clear();

            showHUD();
            SkipLine();
            Console.WriteLine("You finish picking thorns out of your cloak as you enter a cave...");
            SkipLine();
            Console.ReadKey();
            Console.Clear();

            showHUD();
            SkipLine();
            Console.WriteLine("The Cave is damp and dark, but you see something on the ground...");
            SkipLine();
            Console.ReadKey();
            Console.Clear();

            RandomWeapon();
            showHUD();
            SkipLine();
            Console.WriteLine($"You found a {weaponName}!");
            SkipLine();
            Console.ReadKey();
            Console.Clear();

            showHUD();
            SkipLine();
            Console.WriteLine("A goblin runs out after you, you act quickly and attack it!");
            SkipLine();
            DamageDealt();
            Console.ReadKey();
            Console.Clear();


            DamageTaken();
            showHUD();
            SkipLine();
            Console.WriteLine("The goblin hits you with his club!");
            SkipLine();
            DamageTakenText();
            Console.ReadKey();
            Console.Clear();


            RandomPotion();
            showHUD();
            SkipLine();
            HealText();
            SkipLine();
            Console.ReadKey();
            Console.Clear();


        }
    }
}
