using System;

public class Program
{

    public static PowerUp Health;

    PowerUp Ammo;

    public static void Main(String[] args)
    {
        Health.duration = 10;
        Health.RunPowerUp(); //object.functionName To call an object 
        Console.WriteLine(Health.duration);
        //Console.WriteLine(myString);
    }
}