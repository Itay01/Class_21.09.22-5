using System.Reflection.Metadata;
class ConsoleApp2
{
    public static void Main()
    {
        int num;
        Console.WriteLine("Enter two digits number: ");
        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
            num += 11;
        else
            num -= 11;
        Console.WriteLine("The new number is {0}!", num);
    }
}