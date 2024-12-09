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
            Console.WriteLine($"{animal1.ReturnSound()}");
            Console.WriteLine($"{animal2.ReturnSound()}"); 
            Console.WriteLine($"{animal3.ReturnSound()}");
            Console.WriteLine();
        }

        public void Menu(Animal animal1, Animal animal2, Animal animal3)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("What animal would you like to talk to? \n[1] Cat \n[2] Dog \n[3] Cow \n[4] Exit program \n\n");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"{animal1.ReturnType()} says {animal1.ReturnSound()}!\n");
                        Thread.Sleep(1000);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"{animal2.ReturnType()} says {animal2.ReturnSound()}!\n");
                        Thread.Sleep(1000);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"{animal3.ReturnType()} says {animal3.ReturnSound()}!\n");
                        Thread.Sleep(1000);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("The program will now shut down.");
                        isRunning = false;
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Not a valid input, try again.");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}