using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Car;
internal class Task2
{
    private static void Main()
    {
        CarCatalog cars = new CarCatalog(new Car("Ford", 1992, 150), new Car("Ford", 1932, 100), new Car("Honda", 1977, 125), new Car("Audi", 2001, 230), new Car("BMW", 2001, 250), new Car("Honda", 1993, 150));
        Console.WriteLine("Введите режим работы:\n1 - вывод всех элементов в прямом порядке\n2 - вывод всех элементов в обратном порядке\n3 - вывод элемента с указанныи годом выпуска\n4 - вывод элемента с указанной максимальной скоростью");
        string type = Console.ReadLine();
        if (type == "3" || type == "4")
        {
            Console.WriteLine("Введите параметр:");
            uint value = Convert.ToUInt32(Console.ReadLine());
            foreach (Car car in CarCatalog.GetEnumerator(type, value))
            {
                Console.WriteLine(car.ToString());
            }
        }
        else if (type == "1" || type == "2") foreach (Car car in CarCatalog.GetEnumerator(type))
            {
                Console.WriteLine(car.ToString());
            }
        else { Console.WriteLine("Ты почти нажал на нужную кнопку. Попробуй снова. Я верю - получится"); Main(); }
    }
}
public class CarCatalog
{
    private static Car[] _cars;
    public CarCatalog(params Car[] cars) { _cars = cars; }
    public static Car[] Cars { get => _cars; }
    public static IEnumerable<Car> GetEnumerator(string type, uint value = 0)
    {
        if (type == "1")
        {
            for (int i = 0; i < Cars.Length; ++i)
            {
                yield return Cars[i];
            }
        }
        if (type == "2")
        {
            for (int i = 0; i < Cars.Length; ++i)
            {
                yield return Cars[Cars.Length - 1 - i];
            }
        }
        if (type == "3")
        {
            for (int i = 0; i < Cars.Length; ++i)
            {
                if (Cars[i].ProductionYear == value) yield return Cars[i];
            }
        }
        if (type == "4")
        {
            for (int i = 0; i < Cars.Length; ++i)
            {
                if (Cars[i].MaxSpeed == value) yield return Cars[i];
            }
        }
    }
}
