using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CodeAlong09._12._24
{
    internal class Start
    {
        public void Run()
        {
            var animal1= new Animal("Cat", "Meow");
            var animal2 = new Animal("Dog", "Woof");
            var animal3 = new Animal("Cow", "Moo");

           Greeting(animal1, animal2, animal3);
           Thread.Sleep(1500);
           Menu(animal1, animal2, animal3);
        }

        public void Greeting(Animal animal1, Animal animal2, Animal animal3)
        {
            Console.WriteLine($"{animal1.returnSound()}");
            Console.WriteLine($"{animal2.returnSound()}"); 
            Console.WriteLine($"{animal3.returnSound()}");
        }

        public void Menu(Animal animal1, Animal animal2, Animal animal3)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("What animal would you like to talk to? \n[1] Cat \n[2] Dog \n[3] Cow \n[4] Exit program");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"{animal1.returnType()} says {animal1.returnSound()}!");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"{animal2.returnType()} says {animal2.returnSound()}!");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"{animal3.returnType()} says {animal3.returnSound()}!");
                        break;
                    case "4":
                        Console.Clear();
                        isRunning = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Not a valid input, try again.");
                        break;
                }
            }
        }
    }
}