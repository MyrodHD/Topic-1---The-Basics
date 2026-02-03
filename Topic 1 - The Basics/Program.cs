namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string aFriend = "Bill";
            string firstFriend = "Maria";
            string secondFriend = "Sage";

            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);

            Console.WriteLine($"Hello {aFriend}");

            Console.WriteLine($"My Friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            string greeting = "    Hello World    ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say goodbye, and I say Hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            //Microsoft Challenge Below

            string songLyrics1 = "You say goodbye, and I say Hello";
            Console.WriteLine(songLyrics1.StartsWith("You"));
            Console.WriteLine(songLyrics1.StartsWith("Goodbye"));

            Console.WriteLine(songLyrics1.EndsWith("Hello"));
            Console.WriteLine(songLyrics1.EndsWith("Goodbye"));
        }
    }
}
