using System;

namespace Mad_Lib
{
    class Program
    {
        //Getting User Input
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Mad Lib!");
            Console.WriteLine("Write down an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.WriteLine("Enter down another adjective: ");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("Enter down a type of bird: ");
            string birdName = Console.ReadLine();

            Console.WriteLine("Enter a name of a room: ");
            string roomName = Console.ReadLine();

            Console.WriteLine("Enter a verb in the past tense: ");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb2 = Console.ReadLine();

            Console.WriteLine("Enter a name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Enter a type of liquid: ");
            string liquidType1 = Console.ReadLine();

            Console.WriteLine("Enter a verb ending in 'ing': ");
            string ingVerb1 = Console.ReadLine();

            Console.WriteLine("Enter a body part (plural): ");
            string bodyPart = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter another verb ending in 'ing': ");
            string ingVerb2 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            string noun3 = Console.ReadLine();

            Console.WriteLine("Awesome! Let's see what you have created!");
            Console.WriteLine("It was a " + adjective1 + ", cold November day!");
            Console.WriteLine("I woke up to the " + adjective2 + " smell of " + birdName + " roasting in the " + roomName + " downstairs.");
            Console.WriteLine("I " + verb1 + " downstairs to see if I could help " + verb2 + " with dinner");
            Console.WriteLine("My mom said \"See if " + name1 + " needs a fresh " + noun1 + " \".");
            Console.WriteLine("So I carried the tray of glasses full of " + liquidType1 + " into the " + ingVerb1 + " room.");
            Console.WriteLine("When I got there I could'nt belive my " + bodyPart + "!");
            Console.WriteLine("There were " + noun2 + " " + ingVerb2 + " on the " + noun3 + "!");
        }
    }
}
