
using System;

class Building
{
    // Статическое поле — хранит последний номер здания
    private static int lastNumber = 0;

    // Закрытые поля класса
    private int number;
    private double height;
    private int floors;
    private int apartments;
    private int entrances;

    // Метод увеличения номера здания
    private static int IncreaseNumber()
    {
        lastNumber++;
        return lastNumber;
    }

    // Конструктор класса
    public Building()
    {
        number = IncreaseNumber();
    }

    // Метод заполнения полей
    public void SetData(double height, int floors,
                        int apartments, int entrances)
    {
        if (height <= 0 || floors <= 0 ||
            apartments <= 0 || entrances <= 0)
        {
            Console.WriteLine("Ошибка: значения должны быть больше нуля!");
            return;
        }

        this.height = height;
        this.floors = floors;
        this.apartments = apartments;
        this.entrances = entrances;
    }

    // Методы получения значений полей
    public int GetNumber()
    {
        return number;
    }

    public double GetHeight()
    {
        return height;
    }

    public int GetFloors()
    {
        return floors;
    }

    public int GetApartments()
    {
        return apartments;
    }

    public int GetEntrances()
    {
        return entrances;
    }

    // Вычисление высоты одного этажа
    public double CalculateFloorHeight()
    {
        return height / floors;
    }

    // Вычисление количества квартир в одном подъезде
    public double CalculateApartmentsPerEntrance()
    {
        return (double)apartments / entrances;
    }

    // Вычисление количества квартир на одном этаже
    public double CalculateApartmentsPerFloor()
    {
        return (double)apartments / floors;
    }

    // Вывод информации о здании
    public void PrintInfo()
    {
        Console.WriteLine("Номер здания: " + GetNumber());
        Console.WriteLine("Высота: " + GetHeight() + " м");
        Console.WriteLine("Количество этажей: " + GetFloors());
        Console.WriteLine("Количество квартир: " + GetApartments());
        Console.WriteLine("Количество подъездов: " + GetEntrances());

        Console.WriteLine("Высота одного этажа: " +
                          CalculateFloorHeight() + " м");

        Console.WriteLine("Квартир в одном подъезде: " +
                          CalculateApartmentsPerEntrance());

        Console.WriteLine("Квартир на одном этаже: " +
                          CalculateApartmentsPerFloor());
    }
}

class Program
{
    static void Main()
    {
        // Создаём первое здание
        Building building1 = new Building();

        building1.SetData(30, 10, 100, 4);

        // Создаём второе здание
        Building building2 = new Building();

        building2.SetData(45, 15, 180, 6);

        // Вывод информации
        Console.WriteLine("ИНФОРМАЦИЯ О ЗДАНИЯХ");

        Console.WriteLine("\nПервое здание:");
        building1.PrintInfo();

        Console.WriteLine("\nВторое здание:");
        building2.PrintInfo();
    }
}
