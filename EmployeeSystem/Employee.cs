class Employee
{
    protected string _name;
    protected int _baseSalary;

    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }

    public string GetName() => _name;

    public int GetBaseSalary() => _baseSalary;

    public int CalculatePay() => _baseSalary;

    public void PrintInfo() { }
}