using System;

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "으르렁!") { }

    public void Hunt() => Console.WriteLine($"{Name}이(가) 사냥을 합니다.");
}