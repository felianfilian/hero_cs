internal class Program
{
    private static void Main(string[] args)
    {
        int health = 10;
        Console.WriteLine("Welcome to Hero CS");
        Console.WriteLine($"HP: {health} / 10\n" + "OOOOOOOOOO");
        Console.Write("damage: ");
        int damage = Convert.ToInt32(Console.ReadLine());
        health -= damage;
        Console.WriteLine($"HP: {health} / 10\n" + "OOOOOO____");
    }


}