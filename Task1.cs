//using System.Numerics;

//internal class Task1
//{
//    private static void Main()
//    {
//        Console.WriteLine("Введите количество строк для первой матрицы:");
//        uint rows1 = Convert.ToUInt32(Console.ReadLine());
//        Console.WriteLine("Введите количество столбцов для первой матрицы:");
//        uint cols1 = Convert.ToUInt32(Console.ReadLine());
//        Console.WriteLine("Введите количество строк для второй матрицы:");
//        uint rows2 = Convert.ToUInt32(Console.ReadLine());
//        Console.WriteLine("Введите количество столбцов для второй матрицы:");
//        uint cols2 = Convert.ToUInt32(Console.ReadLine());
//        Console.WriteLine("Введите минимальное значение:");
//        int mins = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите максимальное значение:");
//        int maxs = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите множитель:");
//        double mult = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Введите делитель:");
//        double div = Convert.ToDouble(Console.ReadLine());
//        MyMatrix matrix1 = new MyMatrix(rows1, cols1, mins, maxs);
//        MyMatrix matrix2 = new MyMatrix(rows2, cols2, mins, maxs);
//        try
//        {
//            Console.WriteLine(matrix1.ToString());
//            Console.WriteLine(matrix2.ToString());
//            Console.WriteLine((matrix1 + matrix2).ToString());
//            Console.WriteLine((matrix1 - matrix2).ToString());
//            Console.WriteLine((matrix1 * mult).ToString());
//            Console.WriteLine((matrix2 / div).ToString());
//        }
//        catch (ArgumentException) { Console.WriteLine("Нельзя сложить или вычесть матрицы разной размерности. Попробуйте снова."); Main(); }
//        catch (DivideByZeroException) { Console.WriteLine("У Вас почти получилось поделить на ноль. Попробуйте снова."); Main(); }
//    }
//}

//public class MyMatrix
//{
//    private readonly uint _cols, _rows;
//    private double[,] matrix;
//    public MyMatrix(uint rows, uint cols)
//    {
//        _rows = rows;
//        _cols = cols;
//        matrix = new double[rows, cols];
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                matrix[i, j] = 0;
//            }
//        }
//    }
//    public MyMatrix(uint rows, uint cols, int min, int max)
//    {
//        _rows = rows;
//        _cols = cols;
//        matrix = new double[rows, cols];
//        Random rnd = new Random();
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                matrix[i, j] = rnd.Next(min, max);
//            }
//        }
//    }
//    public uint Rows { get => _rows; }
//    public uint Cols { get => _cols; }
//    public double[,] Matrix { get => matrix; }
//    public double this[int index, int index1] { get => Matrix[index, index1]; set => Matrix[index, index1] = value; }
//    public override string ToString()
//    {
//        string str = "";
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Cols; j++)
//            {
//                str += $"{this[i, j]} ";
//            }
//            str += "\n";
//        }
//        return str;
//    }
//    public static MyMatrix operator +(MyMatrix a, MyMatrix b)
//    {
//        MyMatrix Sum = new MyMatrix(a.Rows, a.Cols);
//        if (a.Cols == b.Cols && a.Rows == b.Rows)
//        {
//            for (int i = 0; i < a.Rows; i++)
//            {
//                for (int j = 0; j < a.Cols; j++)
//                {
//                    Sum[i, j] = a[i, j] + b[i, j];
//                }
//            }
//            return Sum;
//        }
//        else throw new ArgumentException("");
//    }
//    public static MyMatrix operator -(MyMatrix a, MyMatrix b)
//    {
//        MyMatrix Sum = new MyMatrix(a.Rows, a.Cols);
//        if (a.Cols == b.Cols && a.Rows == a.Rows)
//        {
//            for (int i = 0; i < a.Rows; i++)
//            {
//                for (int j = 0; j < a.Cols; j++)
//                {
//                    Sum[i, j] = a[i, j] - b[i, j];
//                }
//            }
//            return Sum;
//        }
//        else throw new ArgumentException("");
//    }
//    public static MyMatrix operator *(MyMatrix a, double b)
//    {
//        MyMatrix Sum = a;
//        for (int i = 0; i < a.Rows; i++)
//        {
//            for (int j = 0; j < a.Cols; j++)
//            {
//                Sum[i, j] *= b;
//            }
//        }
//        return Sum;
//    }
//    public static MyMatrix operator /(MyMatrix a, double b)
//    {
//        MyMatrix Sum = a;
//        if (b != 0)
//        {
//            for (int i = 0; i < a.Rows; i++)
//            {
//                for (int j = 0; j < a.Cols; j++)
//                {
//                    Sum[i, j] /= b;
//                }
//            }
//            return Sum;
//        }
//        else throw new DivideByZeroException("");
//    }
//}
