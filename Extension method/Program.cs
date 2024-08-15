using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int percentage = -10;
        if (percentage.IsBetween(0, 100))
            Console.WriteLine("vaied value");
        else
            Console.WriteLine("not valied value");


        Console.WriteLine("--------------------------------");

        Console.WriteLine("enter your value ");
        string input = Console.ReadLine();

        Console.WriteLine(input.Removespaces().Reverse()); //method channing (call method then call anthor method)







    }

}



public static class NumExtensionMethod
{
    public static bool IsBetween(this int value, int min, int max)
    {
        return value >= min && value <= max;
    }
}


public static class StringExtention
{

    public static String Removespaces(this string value)
    {
        return value.Replace(" ", "");

    }

    public static string Reverse(this string value)
    {
        var chararry = value.ToCharArray();
        Array.Reverse(chararry);
        return new string(chararry);
    }

}