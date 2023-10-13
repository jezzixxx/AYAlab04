using System;
using System.Collections;
using System.Data;

//internal class Task2
//{
//    private static void Main()
//    {
//        Car[] cars = { new Car("Ford", 1992, 150), new Car("Ford", 1932, 100), new Car("Honda", 1977, 125), new Car("Audi", 2001, 230) };
//        Console.WriteLine("Какой параметр сравнения? 1 - имя; 2 - год выпуска; 3 - максимальная скорость");
//        string enter = Console.ReadLine();
//        try
//        {
//            if (enter != "1" && enter != "2" && enter != "3") throw new ArgumentException();
//            else
//            {
//                Array.Sort(cars, new CarComparer(enter));
//                foreach (Car car in cars) { Console.WriteLine(car.ToString()); }
//            }
//        }
//        catch (ArgumentException) { Console.WriteLine("Было близко. У тебя получится ввести цифру, я верю. Попробуй снова."); Main(); }

//    }
//}
public class CarComparer : IComparer<Car>
{
    private readonly string _type;
    public CarComparer(string type) { _type = type; }
    public string Type { get => _type; }
    public int Compare(Car? x, Car? y)
    {

        if (Type == "1") { return String.Compare(x.Name, y.Name); }
        else if (Type == "2") { if (x.ProductionYear < y.ProductionYear) return -1; else if (y.ProductionYear < x.ProductionYear) return 1; else return 0; }
        else { if (x.MaxSpeed < y.MaxSpeed) return -1; else if (x.MaxSpeed > y.MaxSpeed) return 1; else return 0; }
    }

}
public class Car
{
    private readonly string _name;
    private readonly uint _year, _speed;
    public Car(string name, uint year, uint speed)
    {
        _name = name;
        _year = year;
        _speed = speed;
    }
    public string Name { get => _name; }
    public uint ProductionYear { get => _year; }
    public uint MaxSpeed { get => _speed; }
    public override string ToString()
    {
        return $"{Name} {ProductionYear} {MaxSpeed}";
    }
}
