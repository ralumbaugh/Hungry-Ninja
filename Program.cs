using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        public class Food
        {
            public string Name;
            public int Calories;
            public bool IsSpicy;
            public bool IsSweet;

            public Food(string Name, int Calories, bool IsSpicy, bool IsSweet)
            {
                this.Name = Name;
                this.Calories = Calories;
                this.IsSpicy = IsSpicy;
                this.IsSweet = IsSweet;
            }
        }

        public class Buffet
        {
            public List<Food> Menu;

            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Sweet and Spicy Chicken", 560, true, true),
                    new Food("1 Scoop of Cold Stone ice cream", 329, false, true),
                    new Food("A single serving of Takis", 150, true, false),
                    new Food("One slice of Lasagna", 166, false, false),
                    new Food("A bowl of Chili", 313, true, false),
                    new Food("One mochi ball", 100, false, true),
                    new Food("A Chipotle Burrito", 1000, false, false)
                };
            }

            public Food Serve()
            {
                Random rand = new Random();
                int FoodPosition = rand.Next(0, Menu.Count);
                // Console.WriteLine($"Today we're serving {Menu[FoodPosition].Name}");
                return Menu[FoodPosition];
            }
        }
        public class Ninja
        {
            public string Name;
            public bool IsFull;
            public bool EnjoysSpicy;
            public bool EnjoysSweet;
            private int CalorieIntake;
            public List<Food> FoodHistory;

            public Ninja(string Name, bool EnjoysSpicy, bool EnjoysSweet)
            {
                this.Name = Name;
                this.EnjoysSpicy = EnjoysSpicy;
                this.EnjoysSweet = EnjoysSweet;
                this.IsFull = false;
                this.CalorieIntake = 0;
                this.FoodHistory = new List<Food>();
            }

            public void Eat(Buffet buffet)
            {
                Food FoodEaten = buffet.Serve();
                if(this.CalorieIntake > 1000 && this.Name != "George")
                {
                    Console.WriteLine($"Although it looks delicious, {this.Name} is too full to eat {FoodEaten.Name}");
                }
                else if(this.CalorieIntake > 2250 && this.Name == "George")
                {
                    Console.WriteLine($"Tapey cannot be appeased!");
                    if((FoodEaten.IsSpicy == true && this.EnjoysSpicy) && (FoodEaten.IsSweet == true && this.EnjoysSweet))
                    {
                        Console.WriteLine($"Delicious! A perfect combination of sweet and spicy! {this.Name} loves it!");
                    }
                    else if(FoodEaten.IsSpicy == true && this.EnjoysSpicy)
                    {
                        Console.WriteLine($"Ooooh, that food has that spicy kick that {this.Name} enjoys!");
                    }
                    else if(FoodEaten.IsSweet == true && this.EnjoysSweet)
                    {
                        Console.WriteLine($"{this.Name} has a sweet tooth, and {FoodEaten.Name} is just right!");
                    }
                    else{
                        Console.WriteLine($"Chomp chomp chomp! {this.Name} eats {FoodEaten.Name}");
                    }
                    this.CalorieIntake += FoodEaten.Calories;
                    this.FoodHistory.Add(FoodEaten);
                }
                else
                {
                    if((FoodEaten.IsSpicy == true && this.EnjoysSpicy) && (FoodEaten.IsSweet == true && this.EnjoysSweet))
                    {
                        Console.WriteLine($"Delicious! A perfect combination of sweet and spicy! {this.Name} loves it!");
                    }
                    else if(FoodEaten.IsSpicy == true && this.EnjoysSpicy)
                    {
                        Console.WriteLine($"Ooooh, that food has that spicy kick that {this.Name} enjoys!");
                    }
                    else if(FoodEaten.IsSweet == true && this.EnjoysSweet)
                    {
                        Console.WriteLine($"{this.Name} has a sweet tooth, and {FoodEaten.Name} is just right!");
                    }
                    else{
                        Console.WriteLine($"Chomp chomp chomp! {this.Name} eats {FoodEaten.Name}");
                    }
                    this.CalorieIntake += FoodEaten.Calories;
                    this.FoodHistory.Add(FoodEaten);
                }
            }
        }
        static void Main(string[] args)
        {
            Buffet DojoEats = new Buffet();
            Ninja Ryan = new Ninja("Ryan", true, true);
            Ninja Cody = new Ninja("Cody", false, true);
            Ninja George = new Ninja("George", true, false);
            Console.WriteLine("############################################################################################################");
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Ryan.Eat(DojoEats);
            Console.WriteLine("############################################################################################################");
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Cody.Eat(DojoEats);
            Console.WriteLine("############################################################################################################");
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
            George.Eat(DojoEats);
        }
    }
}
