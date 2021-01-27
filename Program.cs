using System;

namespace Inheritance
{
    abstract class Goods
    {
        public double price;
        public string code;
    }
    abstract class Animal : Goods
    {
        public string name;
        public string kinde;
        public double weight;
        public string color;
    }
    class Dog : Animal
    {
        public void GetFullInfo()
        {
            code = "D-01";
            price = 500;
            name = "Doge";
            kinde = "Taxa";
            weight = 2.3;
            color = "Ginger";
            Console.WriteLine(
                $"Dog:\ncode {code};" +
                $"\nprice {price};" +
                $"\nname {name};" +
                $"\nkide {kinde};" +
                $"\nweight {weight};" +
                $"\ncolor {color}."
                );
        }
    }
    class Cat : Animal
    {
        public void GetFullInfo()
        {
            code = "C-05";
            price = 300;
            name = "Masya";
            kinde = "British";
            weight = 2.8;
            color = "Black";
            Console.WriteLine(
                $"Cat:\ncode {code};" +
                $"\nprice {price};" +
                $"\nname {name};" +
                $"\nkide {kinde};" +
                $"\nweight {weight};" +
                $"\ncolor {color}."
                );
        }
    }
    class Lizard : Animal
    {
        public void GetFullInfo()
        {
            code = "L-08";
            price = 5000;
            name = "Gaga";
            kinde = "Big Head";
            weight = 0.8;
            color = "Green";
            Console.WriteLine(
                $"Lizard:\ncode {code};" +
                $"\nprice {price};" +
                $"\nname {name};" +
                $"\nkide {kinde};" +
                $"\nweight {weight};" +
                $"\ncolor {color}."
                );
        }
    }
    class Snake : Animal
    {
        bool poison;
        double length;
        public void GetFullInfo()
        {
            code = "S-02";
            price = 8000;
            name = "Shah";
            kinde = "Uzh";
            weight = 1.1;
            color = "Black";
            poison = false;
            length = 2.2;
            Console.WriteLine(
                $"Snake:\ncode {code};" +
                $"\nprice {price};" +
                $"\nname {name};" +
                $"\nkide {kinde};" +
                $"\nweight {weight};" +
                $"\ncolor {color};" +
                $"\npoison {poison};" +
                $"\nlength {length}."
                );
        }
    }
    class Turtle : Animal
    {
        double lifeTime;
        bool predator;
        public void GetFullInfo()
        {
            code = "T-15";
            price = 5000;
            name = "Tartila";
            kinde = "Sea";
            weight = 5.4;
            color = "Yellow";
            lifeTime = 40;
            predator = true;
            Console.WriteLine(
                $"Turtle:" +
                $"\ncode {code};" +
                $"\nprice {price};" +
                $"\nname {name};" +
                $"\nkide {kinde};" +
                $"\nweight {weight};" +
                $"\ncolor {color};" +
                $"\nlife time {lifeTime};" +
                $"\npredator {predator}."
                );
        }
    }
    class Hamster : Animal
    {
        public void GetFullInfo()
        {
            code = "H-5";
            price = 100;
            name = "Hammy";
            kinde = "Volley";
            weight = 0.2;
            color = "Gray";
            Console.WriteLine(
                $"Hamster:" +
                $"\ncode {code};" +
                $"\nprice {price};" +
                $"\nname {name};" +
                $"\nkide {kinde};" +
                $"\nweight {weight};" +
                $"\ncolor {color}."
                );
        }
    }
    abstract class Feed : Goods
    {
        public string kinde;
        public double weight;
        public string name;
    }
    class DryFeed : Feed
    {
        public void GetFullInfo()
        {
            name = "Royal";
            code = "R-25";
            price = 100;
            kinde = "Dry";
            weight = 5;
            Console.WriteLine(
                $"Dry feed:" +
                $"\nname {name};" +
                $"\ncode {code};" +
                $"\nprice {price};" +
                $"\nkinde {kinde};" +
                $"\nweight {weight}."
                );
        }
    }
    class LiquidFeed : Feed
    {
        public void GetFullInfo()
        {
            name = "Wiscas";
            code = "W-85";
            price = 10;
            kinde = "Liquid";
            weight = 0.2;
            Console.WriteLine(
                $"Liquid feed:" +
                $"\nname {name};" +
                $"\ncode {code};" +
                $"\nprice {price};" +
                $"\nkinde {kinde};" +
                $"\nweight {weight}."
                );
        }
    }
    abstract class Toys : Goods
    {
        public double age;
    }
    class Bone : Toys
    {
        public void GetFullInfo()
        {
            price = 10;
            code = "B-11";
            age = 1.3;
            Console.WriteLine(
                $"Bone:" +
                $"\nprice {price};" +
                $"\ncode {code};" +
                $"\nage {age}."
                );
        }
    }
    class Ball : Toys
    {
        public void GetFullInfo()
        {
            price = 30;
            code = "Ba-28";
            age = 0.6;
            Console.WriteLine(
                $"Ball:" +
                $"\nprice {price};" +
                $"\ncode {code};" +
                $"\nage {age}."
                );
        }
    }
    abstract class Workers
    {
        public string name;
        public double salary;
    }
    class Manager : Workers
    {
        public void GetFullInfo()
        {
            name = "Ivan";
            salary = 250000;
            Console.WriteLine(
                $"Manager:" +
                $"\nname {name};" +
                $"\nsalary {salary}."
                );
        }
    }
    class Seller : Workers
    {
        public void GetFullInfo()
        {
            name = "Irina";
            salary = 135000;
            Console.WriteLine(
                $"Seller:" +
                $"\nname {name};" +
                $"\nsalary {salary}."
                );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Dog dog = new Dog();
                Cat cat = new Cat();
                Lizard lizard = new Lizard();
                Snake snake = new Snake();
                Turtle turtle = new Turtle();
                Hamster hamster = new Hamster();
                DryFeed dryFeed = new DryFeed();
                LiquidFeed liquidFeed = new LiquidFeed();
                Bone bone = new Bone();
                Ball ball = new Ball();
                Manager manager = new Manager();
                Seller seller = new Seller();

                Console.WriteLine("\t\tMenu");
                Console.WriteLine("Enter 1  for know about dog;");
                Console.WriteLine("Enter 2  for know about cat;");
                Console.WriteLine("Enter 3  for know about lizard;");
                Console.WriteLine("Enter 4  for know about snake;");
                Console.WriteLine("Enter 5  for know about turtle;");
                Console.WriteLine("Enter 6  for know about humster;");
                Console.WriteLine("Enter 7  for know about dry feed;");
                Console.WriteLine("Enter 8  for know about liquid feed;");
                Console.WriteLine("Enter 9  for know about bone;");
                Console.WriteLine("Enter 10 for know about ball;");
                Console.WriteLine("Enter 11 for know about manager;");
                Console.WriteLine("Enter 12 for know about seller;");
                Console.WriteLine("Enter 13 for EXIT;");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        dog.GetFullInfo();
                        break;
                    case 2:
                        cat.GetFullInfo();
                        break;
                    case 3:
                        lizard.GetFullInfo();
                        break;
                    case 4:
                        snake.GetFullInfo();
                        break;
                    case 5:
                        turtle.GetFullInfo();
                        break;
                    case 6:
                        hamster.GetFullInfo();
                        break;
                    case 7:
                        dryFeed.GetFullInfo();
                        break;
                    case 8:
                        liquidFeed.GetFullInfo();
                        break;
                    case 9:
                        bone.GetFullInfo();
                        break;
                    case 10:
                        ball.GetFullInfo();
                        break;
                    case 11:
                        manager.GetFullInfo();
                        break;
                    case 12:
                        seller.GetFullInfo();
                        break;
                    case 13:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
