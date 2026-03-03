using System;

abstract class Animal
{
    public string Name;
    public int Age;
    protected string _sound;

    protected Animal(string name, int age, string sound)
    {
        Name = name;
        Age = age;
        _sound = sound;
    }

    public void Eat() => Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");

    public void MakeSound() => Console.WriteLine($"{Name}: {_sound}");

    public void DisplayInfo() => Console.WriteLine($"이름: {Name}, 나이: {Age}살");
}