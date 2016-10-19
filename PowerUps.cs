using System;

public class PowerUp {

    public power = 10;

    public float duration = 2;

    public void RunPowerUp () {
        console.WriteLine("Powerup Ran");
    }

    public void RechargePowerUp (int _power) {
        power += _power;
        Console.WriteLine("Recharged PowerUp to" + power);
    }
}