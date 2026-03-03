using System;

class Developer : Employee
{
    private int _overtimeHours;

    public Developer(string name, int baseSalary, int overtimeHours) : base(name, baseSalary) => _overtimeHours = overtimeHours;

    public new int CalculatePay() => GetBaseSalary() + _overtimeHours * 20000;

    public new void PrintInfo()
    {
        Console.WriteLine(
            $"[개발자] {GetName()}" + "\n" +
            $"기본급: {GetBaseSalary():0,000}원" + "\n" +
            $"초과근무: {_overtimeHours}시간" + "\n" +
            $"총 급여: {CalculatePay():0,000}원" + "\n"
        );
    }
}