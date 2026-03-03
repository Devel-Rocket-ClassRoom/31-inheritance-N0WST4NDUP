using System;

class Intern : Employee
{
    private int _overtimeHours;

    public Intern(string name) : base(name, 1500000) { }

    public new int CalculatePay() => GetBaseSalary() + _overtimeHours * 20000;

    public new void PrintInfo()
    {
        Console.WriteLine(
            $"[매니저] {GetName()}" + "\n" +
            $"기본급: {GetBaseSalary():0,000}원" + "\n" +
            $"총 급여: {CalculatePay():0,000}원" + "\n"
        );
    }
}