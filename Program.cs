using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter your name to generate a character sheet.");
            String name = Console.ReadLine();
            Console.WriteLine("Name = " + name);

            string[] Classes = { "Knight", "Mage", "Thief", "Ranger" };
            Random rand = new Random(); 
            int index = rand.Next(Classes.Length); 
            Console.WriteLine($"Class = {Classes[index]}");

            string[] Race = { "Human", "Elf", "Orc", "Dwarf" };
            int index1 = rand.Next(Race.Length); 
            Console.WriteLine($"Race = {Race[index1]}");

            string[] Health= { "10", "20", "30", "40" };
            int index2= rand.Next(Health.Length);
            Console.WriteLine($"Health = {Health[index2]}");

            string[] Mana = { "10", "20", "30", "40" };
            int index3 = rand.Next(Mana.Length);
            Console.WriteLine($"Mana = {Mana[index3]}");

            string[] Dexterity= { "10", "20", "30", "40" };
            int index4 = rand.Next(Dexterity.Length);
            Console.WriteLine($"Dexterity = {Dexterity[index4]}");


            string[] Weapon = { "Sword", "Staff", "Bow", "Axe" };
            int index5 = rand.Next(Weapon.Length);
            Console.WriteLine($"Weapon of Choice = {Weapon[index5]}");

            string[] Armour = { "Clothing", "Light", "Medium", "Heavy" };
            Random rand = new Random();
            int index6 = rand.Next(Armour.Length);
            Console.WriteLine($"Weapon of Choice = {Armour[index6]}");

            Console.ReadKey();
        }

    
    }
}
