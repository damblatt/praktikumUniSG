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
        Console.WriteLine("I am a car");
    }
}

abstract class Golf : GermanCar
{
    public virtual void WhatAreYou()
    {
        Console.WriteLine("I am a Golf");
    }
}

class GolfGTI : Golf, SportsCar
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
