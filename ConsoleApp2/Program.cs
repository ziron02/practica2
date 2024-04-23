using System;

/* 1 задание
class Student
{
    public string surname { get; set; }
    public DateTime dateOfBirth { get; set; }
    public string groupNumber { get; set; }
    public int[] grades { get; set; }

    public void ChangedSurname(string newSurname)
    {
        surname = newSurname;
    }

    public void ChangedDateOfBirth(DateTime newDateOfBirth)
    {
        dateOfBirth = newDateOfBirth;
    }

    public void ChangedGroupNumber(string newGroupNumber)
    {
        groupNumber = newGroupNumber;
    }

    public void Print()
    {
        Console.WriteLine("Фамилия: " + surname);
        Console.WriteLine("Дата рождения: " + dateOfBirth.ToShortDateString());
        Console.WriteLine("Номер группы: " + groupNumber);
        Console.WriteLine("Успеваемость: ");
        foreach (var n in grades)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        Student student = new Student();
        student.grades = new [] { 5, 4, 4, 3, 5 };

        Console.WriteLine("Введите фамилию");
        student.surname = Console.ReadLine();

        Console.WriteLine("Введите дату рождения");
        student.dateOfBirth = DateTime.Parse(Console.ReadLine());

        student.groupNumber = "622";
        
        student.Print();

        Console.WriteLine("Введите новую фамилию: ");
        string newSurname = Console.ReadLine();
        student.ChangedSurname(newSurname);

        Console.WriteLine("Введите новую дату рождения: ");
        DateTime newDateOfBirth = DateTime.Parse(Console.ReadLine());
        student.ChangedDateOfBirth(newDateOfBirth);

        Console.WriteLine("Введите новый номер группы: ");
        string newgroupNum = Console.ReadLine();
        student.ChangedGroupNumber(newgroupNum);
        
        student.Print();
    }
}*/

/* 2 задание
class Train
{
    public string Destination { get; set; }
    public int TrainNum { get; set; }
    public DateTime DepartureTime { get; set; }

    public void Print()
    {
        Console.WriteLine($"Поезд {TrainNum} в {Destination} отправляется {DepartureTime}");
    }
}

class Program
{
    static void Main()
    {
        Train train1 = new Train();
        train1.Destination = "Томск";
        train1.TrainNum = 12345;
        train1.DepartureTime = new DateTime(2024, 04, 15, 10, 30, 0);

        Train train2 = new Train();
        train2.Destination = "Новосибирск";
        train2.TrainNum = 54321;
        train2.DepartureTime = new DateTime(2024, 04, 15, 10, 30, 0);

        Console.WriteLine("Введите номер поезда");
        int inputTrainNum = int.Parse(Console.ReadLine());

        if (inputTrainNum == train1.TrainNum)
        {
            train1.Print();
        }
        else if(inputTrainNum == train2.TrainNum)
        {
            train2.Print();
        }
        else
        {
            Console.WriteLine("поезд с таким номером не найден: ");
        }
    }
} */

/* 3 задание
class Numbers
{
    public int num1 { get; set; }
    public int num2 { get; set; }

    public void ChangeNumbers(int newNum1, int newNum2)
    {
        num1 = newNum1;
        num2 = newNum2;
    }
    
    public int SumNum()
    {
        int sum = num1 + num2;
        return sum;
    }
    
    public int MaxValue()
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    public void Print()
    {
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}

class Program
{
    static void Main()
    {
        Numbers nums = new Numbers();

        Console.WriteLine("Введите первое число");
        nums.num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        nums.num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Вывод чисел");
        nums.Print();

        Console.WriteLine("Сумма чисел");
        int sum = nums.SumNum();
        Console.WriteLine(sum);

        Console.WriteLine("Введите новое первое число");
        int newNum1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе новое число");
        int newNum2 = int.Parse(Console.ReadLine());
        
        nums.ChangeNumbers(newNum1,newNum2);

        Console.WriteLine("Наибольшее новое число");
        int max = nums.MaxValue();
        Console.WriteLine(max);
    }
}*/

/*  4 задание
class Counter
{
    private int num { get; set; }

    public Counter(int initialValue)
    {
        num = initialValue;
    }

    public void Raising()
    {
        num++;
    }

    public void Falling()
    {
        num--;
    }

    public int Print()
    {
        return num;
    }
}

class Program
{
    static void Main()
    {
        Counter num1 = new Counter(4);

        Console.WriteLine("Начальное значение первого числа: " + num1.Print());
        num1.Raising();
        num1.Raising();
        Console.WriteLine("Первое число после 2 прибавлений: " + num1.Print());
        
        num1.Falling();
        Console.WriteLine("первое число после убавления: " + num1.Print());

        Console.WriteLine();

        Console.WriteLine("Введите второе число");
        int initialValue = int.Parse(Console.ReadLine());
        Counter num2 = new Counter(initialValue);
        Console.WriteLine("Начальное значение второго числа");
        
        num2.Raising();
        num2.Raising();
        Console.WriteLine("Второе число после 2 прибавлений: " + num2.Print());
        
        num2.Falling();
        Console.WriteLine("Второе число после убавления: " + num2.Print());
    }
}*/

/* 5 задание
Main();
GC.Collect();
static void Main()
{
    MyClass object1 = new MyClass(10, "Привет");
    Console.WriteLine("Значение первого объекта");
    Console.WriteLine("Значение 1: " + object1.value1);
    Console.WriteLine("Значение 2: " + object1.value2);

    object1 = new MyClass();
    Console.WriteLine("\nЗначение объекта (значения по умолчанию)");
    Console.WriteLine("Значение 1: " + object1.value1);
    Console.WriteLine("Значение 2: " + object1.value2);
    /*MyClass object2 = new MyClass();
    Console.WriteLine("\nЗначение второго объекта (значения по умолчанию)");
    Console.WriteLine("Значение 1: " + object2.value1);
    Console.WriteLine("Значение 1: " + object2.value2);*//*
}

class MyClass
{
    public int value1 { get; set; }
    public string value2 { get; set; }

    public MyClass(int value1, string value2)
    {
        this.value1 = value1;
        this.value2 = value2;
    }
    public MyClass()
    {
        value1 = 0;
        value2 = null;
    }

    ~MyClass()
    {
        Console.WriteLine($"{value1} и {value2} были удалены");
    }
}*/