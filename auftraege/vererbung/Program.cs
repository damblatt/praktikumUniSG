interface SportsCar
{
    void WhatAreYou();
}

interface GermanCar
{
    void WhatAreYou();
}

abstract class Car
{
    public virtual void WhatAreYou()
    {
        Console.WriteLine("I am a Car");
    }
}

abstract class Golf : GermanCar
{
    public virtual void WhatAreYou()
    {
        Console.WriteLine("I am a Golf");
    }
}

class GolfGTI: Golf, SportsCar
{
    public override void WhatAreYou()
    {
        Console.WriteLine("I am a Golf GTI");
    }
}

abstract class Opel : Car, GermanCar
{
    public override void WhatAreYou()
    {
        Console.WriteLine("I am an Opel");
    }
}

class Manta : Opel, SportsCar
{
    public new void WhatAreYou()
    {
        Console.WriteLine("eeh du, echt cool");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Manta();
        Golf car2 = new GolfGTI();

        ((Opel)car1).WhatAreYou();
        ((GolfGTI)car2).WhatAreYou();
        ((Manta)car1).WhatAreYou();
        ((SportsCar)car1).WhatAreYou();
        car2.WhatAreYou();
        car1.WhatAreYou();
    }
}