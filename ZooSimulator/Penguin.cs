using System;

class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age, "꽥꽥!") { }

    public void Swim() => Console.WriteLine($"{Name}이(가) 수영을 합니다.");
}