using System;

/*1 - 2 задание
class Worker
{
    private string name;
    private string surname;
    private int rate;
    private int date;
    
    public string Name
    {
        get { return name;}
        set { name = value;}
    }

    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public int Rate
    {
        get { return rate; }
        set { rate = value; }
    }

    public int Date
    {
        get { return date; }
        set { date = value; }
    }

     public int GetSalary()
    {
        int salary = Rate * Date;
        return salary;
    }
}

class Program
{
    static void Main()
    {
        Worker worker1 = new Worker();
        worker1.Name = "Игорь";
        worker1.Surname = "Калачёв";
        worker1.Date = 10;
        worker1.Rate= 1500;

        int workersSalaly = worker1.GetSalary();
        Console.WriteLine($"{worker1.Name} {worker1.Surname} получит {workersSalaly} за отработынные смены");
    }
}*/

/* 3 задание
class Calculation
{
    public int calculationLine { get; set; }

    public void SetCalculationLine()
    {
        calculationLine += 12;
    }

    public void SetLastSymbolCalculationLine()
    {
        int lastSymbol = 9;
        calculationLine = (calculationLine * 10) + lastSymbol;
    }

    public void GetCalculationLine()
    {
        Console.WriteLine(calculationLine);
    }

    public void GetLastSymbol()
    {
        calculationLine %= 10;
    }

    public void DeleteLstSymbol()
    {
        calculationLine /= 10;
    }
}

class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation();
        calculation.calculationLine = 123;
        Console.WriteLine("Начальное значение числа:");
        calculation.GetCalculationLine();

        calculation.SetCalculationLine();
        calculation.SetCalculationLine();
        Console.WriteLine("Число после 2 измененний:");
        calculation.GetCalculationLine();
        
        Console.WriteLine("Добавление символа в конец строки:");
        calculation.SetLastSymbolCalculationLine();
        calculation.GetCalculationLine();

        Console.WriteLine("Удаление последнего символа строки:");
        calculation.DeleteLstSymbol();
        calculation.GetCalculationLine();
        
        Console.WriteLine("Последний символ строки:");
        calculation.GetLastSymbol();
        calculation.GetCalculationLine();
    }
}*/