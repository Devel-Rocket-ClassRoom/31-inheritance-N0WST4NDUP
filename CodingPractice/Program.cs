using System;

// 1-1. 기본 상속 문법
// Child child = new Child();
// child.Greet(); 
// child.Study();  

// class Parent
// {
//     public void Greet()
//     {
//         Console.WriteLine("안녕하세요!");
//     }
// }

// class Child : Parent
// {
//     public void Study()
//     {
//         Console.WriteLine("공부합니다.");
//     }
// }

// 1-2. 동물 클래스 상속
// Dog dog = new Dog();
// dog.Name = "초코";
// dog.Eat();  
// dog.Bark();  

// Cat cat = new Cat();
// cat.Name = "나비";
// cat.Eat(); 
// cat.Meow();  

// class Animal
// {
//     public string Name;

//     public void Eat()
//     {
//         Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
//     }
// }

// class Cat : Animal
// {
//     public void Meow()
//     {
//         Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
//     }
// }

// 2. Object 클래스
// Product product = new Product { Name = "키보드", Price = 50000 };
// Console.WriteLine(product.ToString());
// Console.WriteLine(product.GetType());

// class Product
// {
//     public string Name;
//     public int Price;
// }

// 3. 접근 제한자와 상속
// Child child = new Child();
// child.ShowValues();
// // child._protectedValue;  // 오류: 외부에서 protected 접근 불가
// Console.WriteLine(child.PublicValue);

// class Parent
// {
//     private int _privateValue = 1;      // 자식 클래스에서 접근 불가
//     protected int _protectedValue = 2;  // 자식 클래스에서 접근 가능
//     public int PublicValue = 3;         // 어디서든 접근 가능
// }

// class Child : Parent
// {
//     public void ShowValues()
//     {
//         // Console.WriteLine(_privateValue);    // 오류: 접근 불가
//         Console.WriteLine(_protectedValue);     // 가능
//         Console.WriteLine(PublicValue);         // 가능
//     }
// }

// 4. base 키워드
// Manager manager = new Manager();
// manager.ShowInfo();

// class Employee
// {
//     protected string _department = "개발팀";

//     public void ShowDepartment()
// 	    {
//         Console.WriteLine($"부서: {_department}");
//     }
// }

// class Manager : Employee
// {
//     public void ShowInfo()
//     {
//         // base 키워드로 부모 클래스의 protected 멤버 접근
//         Console.WriteLine($"소속 부서: {base._department}");

//         // base 키워드로 부모 클래스의 메서드 호출
//         base.ShowDepartment();
//     }
// }

// 5-1. 부모 생성자 호출 (base)
// Student student = new Student("홍길동", 3);
// Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");

// class Person
// {
//     public string Name;

//     public Person(string name)
//     {
//         Name = name;
//         Console.WriteLine($"Person 생성자 호출: {name}");
//     }
// }

// class Student : Person
// {
//     public int Grade;

//     // base()로 부모 생성자 호출
//     public Student(string name, int grade) : base(name)
//     {
//         Grade = grade;
//         Console.WriteLine($"Student 생성자 호출: {grade}학년");
//     }
// }

// 5-2. 암시적 기본 생성자 호출
// Dog dog = new Dog();

// class Animal
// {
//     public Animal()
//     {
//         Console.WriteLine("Animal 기본 생성자");
//     }
// }

// class Dog : Animal
// {
//     public Dog()  // base() 생략 시 Animal()이 자동 호출됨
//     {
//         Console.WriteLine("Dog 생성자");
//     }
// }

// 6-1. 업캐스팅
// Dog dog = new Dog { Name = "멍멍이" };
// Animal animal = dog;  // 업캐스팅: 암시적 변환

// animal.Eat();    // 가능
// // animal.Bark();  // 오류: Animal 타입에는 Bark 메서드가 없음

// class Animal
// {
//     public string Name;
//     public void Eat() => Console.WriteLine($"{Name}이(가) 먹습니다.");
// }

// class Dog : Animal
// {
//     public void Bark() => Console.WriteLine($"{Name}이(가) 짖습니다.");
// }

// 6-2. 다운캐스팅
// Dog dog = new Dog { Name = "멍멍이" };
// Animal animal = dog;         // 업캐스팅

// Dog dog2 = (Dog)animal;      // 다운캐스팅: 명시적 변환 필요
// dog2.Bark();                 // 이제 Bark() 호출 가능

// 6-3. is 연산자로 타입 검사
// Animal animal = new Dog { Name = "멍멍이" };

// if (animal is Dog)
// {
//     Dog dog = (Dog)animal;
//     dog.Bark();
// }

// 6-4. is 패턴 매칭
// Animal animal = new Dog { Name = "멍멍이" };

// if (animal is Dog dog)  // 검사와 변환을 동시에
// {
//     dog.Bark();
// }

// 6-5. as 연산자로 안전한 캐스팅
// Animal animal = new Cat { Name = "야옹이" };

// Dog dog = animal as Dog;  // 캐스팅 실패 시 null
// if (dog != null)
// {
//     dog.Bark();
// }
// else
// {
//     Console.WriteLine("Dog 타입이 아닙니다.");
// }

// 7. 다형성
// Asset[] assets = new Asset[3];
// assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
// assets[1] = new House { Name = "아파트", Mortgage = 300000000 };
// assets[2] = new Stock { Name = "SK하이닉스", Shares = 50 };

// // 모든 자산의 이름 출력
// foreach (Asset asset in assets)
// {
//     Console.WriteLine(asset.Name);
// }

// class Asset
// {
//     public string Name;
// }

// class Stock : Asset
// {
//     public int Shares;
// }

// class House : Asset
// {
//     public decimal Mortgage;
// }

// 8-1. 추상 클래스 기본
// Rectangle rect = new Rectangle { Name = "사각형", Width = 10, Height = 5 };
// Circle circle = new Circle { Name = "원", Radius = 3 };

// Console.WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
// Console.WriteLine($"{circle.Name} 넓이: {circle.GetArea():F2}");

// // 추상 클래스
// abstract class Shape
// {
//     public string Name;

//     // 추상 메서드: 구현 없이 선언만 함
//     public abstract double GetArea();
// }

// // 추상 클래스를 상속받는 클래스
// class Rectangle : Shape
// {
//     public double Width;
//     public double Height;

//     // 추상 메서드 구현 필수

//     public override double GetArea()
//     {
//         return Width * Height;
//     }
// }

// class Circle : Shape
// {
//     public double Radius;

//     public override double GetArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }

// 8-2. 추상 메서드
// Car car = new Car();
// car.Start();
// car.Stop();

// abstract class Vehicle
// {
//     public abstract void Start();   // 추상 메서드: 구현 없음
//     public void Stop()              // 일반 메서드: 구현 있음
//     {
//         Console.WriteLine("정지합니다.");
//     }
// }

// class Car : Vehicle
// {
//     public override void Start()  // 반드시 구현해야 함
//     {
//         Console.WriteLine("자동차 시동을 켭니다.");
//     }
// }

// 9. 봉인 클래스
// FinalClass obj = new FinalClass();
// obj.Display();

// sealed class FinalClass
// {
//     public void Display()
//     {
//         Console.WriteLine("이 클래스는 상속할 수 없습니다.");
//     }
// }

// 10. 멤버 숨기기 (new 키워드)
// Child child = new Child();
// Parent parent = child;

// Console.WriteLine($"child.Value: {child.Value}");   // 자식의 Value
// Console.WriteLine($"parent.Value: {parent.Value}"); // 부모의 Value
// child.Show();   // 자식의 Show()
// parent.Show();  // 부모의 Show()

// class Parent
// {
//     public int Value = 10;

//     public void Show()
//     {
//         Console.WriteLine("Parent.Show()");
//     }
// }

// class Child : Parent
// {
//     public new int Value = 20;  // 부모의 Value를 숨김

//     public new void Show()      // 부모의 Show()를 숨김
//     {
//         Console.WriteLine("Child.Show()");
//     }
// }

// 11. is-a 관계
// Dog dog = new Dog();

// Console.WriteLine(dog is Animal);  // True: 개는 동물이다
// Console.WriteLine(dog is Dog);     // True: 개는 개다
// Console.WriteLine(dog is Cat);     // False: 개는 고양이가 아니다

// class Animal { }
// class Dog : Animal { }
// class Cat : Animal { }

// 12. 종합 예제: 게임 캐릭터 시스템
// 캐릭터 배열 (다형성 활용)
GameCharacter[] characters = new GameCharacter[]
{
    new Warrior("아서", 25),
    new Mage("멀린", 40),
    new Warrior("란슬롯", 30)
};

// 모든 캐릭터의 상태와 공격 출력
foreach (GameCharacter character in characters)
{
    character.ShowStatus();
    character.Attack();
    Console.WriteLine();
}

// 기반 클래스
abstract class GameCharacter
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }

    protected GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack();

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] 체력: {Health}");
    }
}

// 전사 클래스
class Warrior : GameCharacter
{
    public int Strength { get; private set; }

    public Warrior(string name, int strength) : base(name, 150)
    {
        Strength = strength;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 검으로 {Strength} 데미지를 입힙니다!");
    }
}

// 마법사 클래스
class Mage : GameCharacter
{
    public int MagicPower { get; private set; }

    public Mage(string name, int magicPower) : base(name, 80)
    {
        MagicPower = magicPower;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 마법으로 {MagicPower} 데미지를 입힙니다!");
    }
}
