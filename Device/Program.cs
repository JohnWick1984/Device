using System;

class Device
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{Name} издает звук.");
    }

    public void Desc()
    {
        Console.WriteLine($"Описание: {Description}");
    }

    public override string ToString()
    {
        return Name;
    }
}

class Kettle : Device
{
    public Kettle(string name, string temperatureRange)
        : base(name, $"Чайник с рабочим интервалом температур: {temperatureRange}")
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} бурлит.");
    }
}

class Microwave : Device
{
    public Microwave(string name, string power)
        : base(name, $"Микроволновка мощьностью: {power}")
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} гудит.");
    }
}

class Car : Device
{
    public Car(string name, string model)
        : base(name, $"Форма автомобиля: {model}")
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} бибикает.");
    }
}

class Ship : Device
{
    public Ship(string name, string type)
        : base(name, $"Тип корабля: {type}")
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} гудит.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kettle kettle = new Kettle("Электрочайник", "50°C - 100°C");
        Microwave microwave = new Microwave("Микроволновка", "800W");
        Car car = new Car("Автомобиль", "Седан");
        Ship ship = new Ship("Корабль", "Грузовой");

        Device[] devices = { kettle, microwave, car, ship };

        foreach (Device device in devices)
        {
            Console.WriteLine($"Устройство: {device}");
            device.Sound();
            device.Desc();
            Console.WriteLine();
        }
    }
}
