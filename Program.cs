using System;

public class Program
{

    public static PowerUp Health = new PowerUp();
    public static PowerUp Ammo = new PowerUp();
    public static void Main(String[] args)
    {
        Health.duration = 10;
        Health.RunPowerUp(); //object.functionName To call an object 
        Console.WriteLine(Health.duration);
        Ammo.RunPowerUp();
        //Console.WriteLine(myString);

        Health.RechargePowerUp(20);
        Ammo.RechargePowerUp(300);
    }
}