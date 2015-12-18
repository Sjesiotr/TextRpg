using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTextRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ints:
            int correct = 0;
            int Player_One_Handed = 0;
            int Player_Two_Handed = 0;
            int Player_Ranged_Weapon = 0;
            int Player_Magic = 0;
            int Arraycount = 0;
            int Player_Attack_Type = 0;
            int Player_One_Weapon_Damage = 2;
            int Player_Health_Points = 20;
            int Player_Mana_Points = 12;
            int Enemy_Health_Points;
            int Enemy_Health_Points2;
            int Enemy_Health_Points3;
            int Enemy_Health_Points4;
            int Enemy_Maximum_Damage;
            int Enemy_Maximum_Damage2;
            int Enemy_Maximum_Damage3;
            int Enemy_Maximum_Damage4;

            //Strings:
            string Player_Gender;
            string Player_Race;
            string Player_Class;
            string[] Inventory = new string[20];
            string Input;
            string Enemy_Name;
            string Enemy_Name2;
            string Enemy_Name3;
            string Enemy_Name4;



            //Character Creation:
            Console.WriteLine("    WELCOME TO THE ARENA    ");
            Console.WriteLine(" SURVIVE AS LONG AS YOU CAN ");
            Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a gender as below:");
                Console.WriteLine("Male / Female");
                Player_Gender = Console.ReadLine().ToUpper();
                if (Player_Gender == "MALE" || Player_Gender == "FEMALE")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Race Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a race as below:");
                Console.WriteLine("Human");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Elf");
                Console.WriteLine("Orc");
                Console.WriteLine("Your Choice:");
                Player_Race = Console.ReadLine().ToUpper();
                if (Player_Race == "HUMAN")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 1 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Race == "DWARF")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 0 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Race == "ELF")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 0 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons. 2 Point");
                    Console.WriteLine("Magical Attack. 1 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

                if (Player_Race == "ORC")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 0 Point");
                    Console.WriteLine("Magical Attack. 0 Point");
                    Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
            } while (correct == 0);
            correct = 0;

            //Class Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a class as below:");
                Console.WriteLine("Warrior");
                Console.WriteLine("Hunter");
                Console.WriteLine("Mage");
                Console.WriteLine("Thief");
                Console.WriteLine("Your Choice:");
                Player_Class = Console.ReadLine().ToUpper();
                if (Player_Class == "WARRIOR")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 2 Point");
                    Console.WriteLine("Ranged Weapons. 0 Point");
                    Console.WriteLine("Magical Attack. 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Player_Class == "HUNTER")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 1 Point");
                    Console.WriteLine("Ranged Weapons. 2 Point");
                    Console.WriteLine("Magical Attack. 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Player_Class == "MAGE")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 1 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 2 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Player_Class == "THIEF")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("One Handed Weapons. 2 Point");
                    Console.WriteLine("Two Handed Weapons. 0 Point");
                    Console.WriteLine("Ranged Weapons. 1 Point");
                    Console.WriteLine("Magical Attack. 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                else { }
            } while (correct == 0);
            correct = 0;


            //Bonuses:
            //Race Bonus:
            if (Player_Race == "HUMAN")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (Player_Race == "DWARF")
            {
                Player_One_Handed++;
                Player_Two_Handed = Player_Two_Handed + 2;
                Player_Ranged_Weapon++;
            }
            if (Player_Race == "ELF")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
                Player_Magic++;
            }
            if (Player_Race == "ORC")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }
            //Class Bonus:
            if (Player_Class == "WARRIOR")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Two_Handed = Player_Two_Handed + 2;
            }
            if (Player_Class == "HUNTER")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
            }
            if (Player_Class == "MAGE")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic = Player_Magic + 2;
            }
            if (Player_Class == "THIEF")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }


            //Player Description, Writeout
            Console.Clear();
            Console.WriteLine("Your Full Character Description, is:");
            Console.WriteLine("A {0} {1} {2}", Player_Gender, Player_Race, Player_Class);
            Console.WriteLine("One Handed Weapon Skill Points: {0}", Player_One_Handed);
            Console.WriteLine("Two Handed Weapon Skill Points: {0}", Player_Two_Handed);
            Console.WriteLine("Ranged Weapon Skill Points: {0}", Player_Ranged_Weapon);
            Console.WriteLine("Magical Attack Skill Points: {0}", Player_Magic);
            Console.ReadLine();




            //Enemy Declair System:
            Enemy_Name = "Rat";
            Enemy_Health_Points = 12;
            Enemy_Maximum_Damage = 2;

            Enemy_Name2 = "Wild Dog";
            Enemy_Health_Points2 = 14;
            Enemy_Maximum_Damage2 = 2;

            Enemy_Name3 = "Thief";
            Enemy_Health_Points3 = 10;
            Enemy_Maximum_Damage3 = 4;

            Enemy_Name4 = "Dragon";
            Enemy_Health_Points4 = 25;
            Enemy_Maximum_Damage4 = 8;

            //Combat System:
            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
                Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name, Enemy_Health_Points);
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");
                Player_Attack_Type = Convert.ToInt32(Console.ReadLine());
                if (Player_Attack_Type == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_One_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_One_Handed);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Two_Handed);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Two_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Two_Handed);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 3)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Ranged_Weapon);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Ranged_Weapon;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Ranged_Weapon);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 4)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Magic;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Magic);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points = Enemy_Health_Points - Random_Damage_Roll;
                }
                else { }
                if (Enemy_Health_Points > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Enemy_Maximum_Damage);
                    Console.WriteLine("The {0} Strikes back, and deal {1} Points of Damage", Enemy_Name, Random_Enemy_Damage_Roll);
                    Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;
                    Console.ReadLine();
                }
                else { }
            } while (Player_Health_Points > 0 && Enemy_Health_Points > 0);
            Console.Clear();
            if (Enemy_Health_Points < 0)
            {
                Enemy_Health_Points = 0;
            }
            if (Player_Health_Points < 0)
            {
                Player_Health_Points = 0;
            }
            Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
            Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name, Enemy_Health_Points);
            Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
            Console.WriteLine("1. One Handed Attack");
            Console.WriteLine("2. Two Handed Attack");
            Console.WriteLine("3. Ranged Weapon Attack");
            Console.WriteLine("4. Magical Attack");
            if (Enemy_Health_Points > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle.");
                Console.ReadLine();
            }
            if (Player_Health_Points > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You won the battle.");
                Console.WriteLine("Get ready for round 2");
                Console.ReadLine();
            }




            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
                Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name2, Enemy_Health_Points2);
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");
                Player_Attack_Type = Convert.ToInt32(Console.ReadLine());
                if (Player_Attack_Type == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_One_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_One_Handed);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name2);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Two_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage");
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 3)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Ranged_Weapon);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Ranged_Weapon;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Ranged_Weapon);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name2);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 4)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Magic;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Magic);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name2);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                else { }
                if (Enemy_Health_Points2 > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Enemy_Maximum_Damage2);
                    Console.WriteLine("The {0} Strikes back, and deal {1} Points of Damage", Enemy_Name2, Random_Enemy_Damage_Roll);
                    Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;
                    Console.ReadLine();
                }
                else { }
            } while (Player_Health_Points > 0 && Enemy_Health_Points2 > 0);
            Console.Clear();
            if (Enemy_Health_Points2 < 0)
            {
                Enemy_Health_Points2 = 0;
            }
            if (Player_Health_Points < 0)
            {
                Player_Health_Points = 0;
            }
            Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
            Console.WriteLine("The {0}s Healt is at {1} Points", Enemy_Name2, Enemy_Health_Points2);
            Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
            Console.WriteLine("1. One Handed Attack");
            Console.WriteLine("2. Two Handed Attack");
            Console.WriteLine("3. Ranged Weapon Attack");
            Console.WriteLine("4. Magical Attack");
            if (Enemy_Health_Points2 > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle.");
                Console.ReadLine();
            }
            if (Player_Health_Points > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You won the battle.");
                Console.WriteLine("Get ready for round 3");
                Console.ReadLine();
            }


            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
                Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name3, Enemy_Health_Points3);
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");
                Player_Attack_Type = Convert.ToInt32(Console.ReadLine());
                if (Player_Attack_Type == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_One_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_One_Handed);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name3);
                    Enemy_Health_Points3 = Enemy_Health_Points3 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Two_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage");
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name3);
                    Enemy_Health_Points3 = Enemy_Health_Points3 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 3)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Ranged_Weapon);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Ranged_Weapon;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Ranged_Weapon);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name3);
                    Enemy_Health_Points3 = Enemy_Health_Points3 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 4)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Magic;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Magic);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name3);
                    Enemy_Health_Points3 = Enemy_Health_Points3 - Random_Damage_Roll;
                }
                else { }
                if (Enemy_Health_Points3 > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Enemy_Maximum_Damage3);
                    Console.WriteLine("The {0} Strikes back, and deal {1} Points of Damage", Enemy_Name3, Random_Enemy_Damage_Roll);
                    Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;
                    Console.ReadLine();
                }
                else { }
            } while (Player_Health_Points > 0 && Enemy_Health_Points2 > 0);
            Console.Clear();
            if (Enemy_Health_Points3 < 0)
            {
                Enemy_Health_Points3 = 0;
            }
            if (Player_Health_Points < 0)
            {
                Player_Health_Points = 0;
            }
            Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
            Console.WriteLine("The {0}s Healt is at {1} Points", Enemy_Name3, Enemy_Health_Points3);
            Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
            Console.WriteLine("1. One Handed Attack");
            Console.WriteLine("2. Two Handed Attack");
            Console.WriteLine("3. Ranged Weapon Attack");
            Console.WriteLine("4. Magical Attack");
            if (Enemy_Health_Points3 > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle.");
                Console.ReadLine();
            }
            if (Player_Health_Points > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You won the battle.");
                Console.ReadLine();
            }



            
            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
                Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name2, Enemy_Health_Points2);
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");
                Player_Attack_Type = Convert.ToInt32(Console.ReadLine());
                if (Player_Attack_Type == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_One_Weapon_Damage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_One_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_One_Handed);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name2);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Two_Handed;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage");
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 3)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Ranged_Weapon);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Ranged_Weapon;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Ranged_Weapon);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name2);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                if (Player_Attack_Type == 4)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Player_Magic);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + Player_Magic;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", Player_Magic);
                    }
                    else { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name2);
                    Enemy_Health_Points2 = Enemy_Health_Points2 - Random_Damage_Roll;
                }
                else { }
                if (Enemy_Health_Points2 > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Enemy_Maximum_Damage2);
                    Console.WriteLine("The {0} Strikes back, and deal {1} Points of Damage", Enemy_Name2, Random_Enemy_Damage_Roll);
                    Player_Health_Points = Player_Health_Points - Random_Enemy_Damage_Roll;
                    Console.ReadLine();
                }
                else { }
            } while (Player_Health_Points > 0 && Enemy_Health_Points2 > 0);
            Console.Clear();
            if (Enemy_Health_Points2 < 0)
            {
                Enemy_Health_Points2 = 0;
            }
            if (Player_Health_Points < 0)
            {
                Player_Health_Points = 0;
            }
            Console.WriteLine("Your Health is at {0} Points, Your Mana is at {1} Points", Player_Health_Points, Player_Mana_Points);
            Console.WriteLine("The {0}s Healt is at {1} Points", Enemy_Name2, Enemy_Health_Points2);
            Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
            Console.WriteLine("1. One Handed Attack");
            Console.WriteLine("2. Two Handed Attack");
            Console.WriteLine("3. Ranged Weapon Attack");
            Console.WriteLine("4. Magical Attack");
            if (Enemy_Health_Points2 > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle.");
                Console.ReadLine();
            }
            if (Player_Health_Points > 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" - You won the battle.");
                Console.ReadLine();
            }



            //Quest giving system:


        }
    }
}
