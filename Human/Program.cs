using System;

public abstract class Human
{
    protected string firstName;
    protected string lastName;
    protected DateTime birthDate;

    public Human()
    { }

    public Human(string fName, string lName)
    {
        firstName = fName;
        lastName = lName;
    }

    public Human(string fName, string lName, DateTime date) : this(fName, lName)
    {
        birthDate = date;
    }

    public override string ToString()
    {
        return $"Фамилия: {lastName}\n" +
            $"Имя: {firstName}\n" +
            $"Дата рождения: {birthDate.ToShortDateString()}\n";
    }
}

public abstract class Employee : Human
{
    double _salary;

    public Employee(string fName, string lName) : base(fName, lName) { }

    public Employee(string fName, string lName, double salary) : base(fName, lName)
    {
        _salary = salary;
    }

    public Employee(string fName, string lName, DateTime date, double salary)
        : base(fName, lName, date)
    {
        _salary = salary;
    }

    public override string ToString()
    {
        return base.ToString() + $"Зарплата: {_salary} руб.\n";
    }
}
public class Builder : Employee
{
    string specialty;

    public Builder(string fName, string lName, double salary, string specialty, DateTime date)
        : base(fName, lName, date, salary)
    {
        this.specialty = specialty;
    }

    public void Build(string buildingName)
    {
        Console.WriteLine($"Строитель {firstName} {lastName}  по специальности {specialty} укладывает кирпичи в {buildingName}.");
    }
}

public class Sailor : Employee
{
    string shipName;

    public Sailor(string fName, string lName, double salary, string shipName, DateTime date)
        : base(fName, lName, date, salary)
    {
        this.shipName = shipName;
    }

    public void Sail()
    {
        Console.WriteLine($"Капитан {firstName} {lastName} управляет кораблем '{shipName}'.");
    }
}

public class Pilot : Employee
{
    string aircraftName;

    public Pilot(string fName, string lName, double salary, string aircraftName, DateTime date)
        : base(fName, lName, date, salary)
    {
        this.aircraftName = aircraftName;
    }

    public void Fly()
    {
        Console.WriteLine($"Пилот {firstName} {lastName} управляет самолетом '{aircraftName}'.");
    }
}

class Program
{
    static void Main()
    {
        Builder builder = new Builder("Вася", "Пупкин", 50000, "каменщик", new DateTime(1990, 5, 15));
        builder.Build("больнице");
        Console.WriteLine(builder.ToString());

        Sailor sailor = new Sailor("Джек", "Воробей", 45000, "Черная Жемчужина", new DateTime(1985, 10, 20));
        sailor.Sail();
        Console.WriteLine(sailor.ToString());

        Pilot pilot = new Pilot("Олег", "Ползунов", 75000, "Боинг 737", new DateTime(1988, 3, 8));
        pilot.Fly();
        Console.WriteLine(pilot.ToString());
    }
}
