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
        }
    }
}
