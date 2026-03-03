using System;

class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "뿌우!") { }

    public void SprayWater() => Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
}