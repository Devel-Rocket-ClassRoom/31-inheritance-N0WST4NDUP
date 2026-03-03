using System;

class Manager : Employee
{
    private int _bonus;

    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary) => _bonus = bonus;

    public new int CalculatePay() => GetBaseSalary() + _bonus;

    public new void PrintInfo()
    {
        Console.WriteLine(
            $"[매니저] {GetName()}" + "\n" +
            $"기본급: {GetBaseSalary():0,000}원" + "\n" +
            $"보너스: {_bonus:0,000}원" + "\n" +
            $"총 급여: {CalculatePay():0,000}원" + "\n"
        );
    }
}