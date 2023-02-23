using Microsoft.VisualBasic;

class Weapon
{
    enum Calibr {small, medium, large }
    string model;
    float range;
    Calibr calibr;
    int number;
    int maxnumber;
    bool isPowerON;

    public void Initializer (string m, float r, int v)
    {
        model = m;
        range = 0;
        number = 0;
        maxnumber = 0;
        isPowerON = false;
        calibr = Calibr.small;

    }
    public void ShowinfoGun()
    {
        Console.WriteLine($"Model: {model} range {range} number {number} maxnumber {maxnumber}\n" +
            $"Power status {(isPowerON == true? "ON" : "OFF")}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        
        Weapon my = new Weapon();
        my.Initializer("Stugna", 7,62);
        Weapon your = new Weapon();
        my.ShowinfoGun();
        
    }
}