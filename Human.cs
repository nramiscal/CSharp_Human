using System;

namespace Human
{

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // add a public "getter" property to access health

        public int Health
        {   
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string n)
        {
            Name = n;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields
        public Human()
        {
            Name = "Hooman";
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;

        }

        // Build Attack method
        public int Attack(Human target)
        {
            System.Console.WriteLine($"Target's health was {target.Health}");
            target.Health -= 5 * Strength;
            System.Console.WriteLine($"Target's health is now {target.Health}");

            return target.Health;
        }
    }


}

