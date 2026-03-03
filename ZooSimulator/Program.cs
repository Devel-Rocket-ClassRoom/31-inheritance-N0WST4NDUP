using System;

Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===");
Console.WriteLine();

Animal[] animals = new Animal[3] { new Lion("시바", 5), new Elephant("덤보", 10), new Penguin("뽀로로", 3) };

Console.WriteLine("[동물 정보]");
foreach (Animal animal in animals)
{
    animal.DisplayInfo();
}
Console.WriteLine();

Console.WriteLine("[동물 소리]");
foreach (Animal animal in animals)
{
    animal.MakeSound();
}
Console.WriteLine();

Console.WriteLine("[동물 행동]");
foreach (Animal animal in animals)
{
    animal.Eat();

    if (animal is Lion) ((Lion)animal).Hunt();
    if (animal is Elephant) ((Elephant)animal).SprayWater();
    if (animal is Penguin) ((Penguin)animal).Swim();
}
Console.WriteLine();