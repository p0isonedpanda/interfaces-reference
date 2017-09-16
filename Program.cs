using System;

namespace interfaces_reference
{
    class Program
    {
        interface Iitem
        {
            string name { get; set; }
            int goldValue { get; set; }
            
            void Equip ();
            void Sell ();
        }

        interface Idamageable
        {
            int durability { get; set; }
            
            void TakeDamage (int _amount);
        }

        interface IpartOfQuest
        {
            void TurnIn ();
        }

        class Sword : Iitem, Idamageable, IpartOfQuest
        {
            public string name { get; set;}
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Sword (string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 100;
            }

            public void Equip ()
            {
                Console.WriteLine(name + " has been equipped");
            }

            public void Sell ()
            {
                Console.WriteLine(name + " sold for " + goldValue + " gold");
            }

            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine(name + " has taken " + _dmg + " damage");
                Console.WriteLine(name + " now has " + durability + " durability remaining");
            }
            
            public void TurnIn()
            {
                Console.WriteLine(name + " turned in, quest complete!");
            }
        }

        class Axe : Iitem, Idamageable
        {
            public string name { get; set;}
            public int goldValue { get; set; }
            public int durability { get; set; }

            public Axe (string _name)
            {
                name = _name;
                goldValue = 50;
                durability = 100;
            }

            public void Equip ()
            {
                Console.WriteLine(name + " has been equipped");
            }

            public void Sell ()
            {
                Console.WriteLine(name + " sold for " + goldValue + " gold");
            }

            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine(name + " has taken " + _dmg + " damage");
                Console.WriteLine(name + " now has " + durability + " durability remaining");
            }

        }

        static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.TakeDamage(20);
            sword.Sell();
            sword.TurnIn();

            Axe axe = new Axe("Fury Axe");
            axe.Equip();
            axe.TakeDamage(10);
            axe.Sell();

            // Create inventory
            Iitem[] inventory = new Iitem[2];
            inventory[0] = sword;
            inventory[1] = axe;

            for (int i = 0; i < inventory.Length; i++)
            {
                IpartOfQuest questItem = inventory[i] as IpartOfQuest;
                if (questItem != null)
                {
                    questItem.TurnIn();
                }
            }

            Console.ReadKey();
        }
    }
}
