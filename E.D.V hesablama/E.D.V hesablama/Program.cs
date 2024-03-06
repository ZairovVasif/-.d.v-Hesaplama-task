using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        string reqem;
        Console.Write("Reqem daxil edin!: ");
        reqem = Console.ReadLine();
        double kdv = 0.16;

        Console.WriteLine("Girdiğiniz sayının %16 EDV'si: " + (Convert.ToDouble(reqem) * kdv));
        Console.ReadKey();
    }
}