using System;

Console.WriteLine("=== 직원 급여 시스템 ===");
Console.WriteLine();

Manager manager = new("김부장", 5000000, 1000000);
manager.PrintInfo();
Developer developer = new("이개발", 4000000, 10);
developer.PrintInfo();
Intern intern = new("박인턴");
intern.PrintInfo();