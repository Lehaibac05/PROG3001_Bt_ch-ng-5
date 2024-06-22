using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Find_the_max_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("Tìm giá trị lớn nhất.");
                Console.WriteLine("1.Kiểm tra với số nguyên.");
                Console.WriteLine("2.Kiểm tra với số thực.");
                Console.WriteLine("3.Kiểm tra với chuỗi.");
                Console.WriteLine("4.Thoát.");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Giá trị bạn nhập không đún" +
                        "g, xin mời nhập lại.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        TestWithINT();
                        break;
                    case 2:
                        TestWithFLOAT();
                        break;
                    case 3:
                        TestWithSTRING();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Giá trị bạn nhập không đúng, xin mời nhập lại.");
                        break;
                }
                Console.WriteLine();
            }
        
           

        }
        public static T Max<T>(T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) > 0 ? value1 : value2;
        }

        public static void TestWithINT()
        {
            Console.Write("Nhập số nguyên thứ nhất: ");
            int int1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên thứ hai: ");
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giá trị lớn nhất là: {Max(int1, int2)}");
        }

        public static void TestWithFLOAT()
        {
            Console.Write("Nhập số thực thứ nhất: ");
            double double1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực thứ hai: ");
            double double2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Giá trị lớn nhất là: {Max(double1, double2)}");
        }

        public static void TestWithSTRING()
        {
            Console.Write("Nhập chuỗi thứ nhất: ");
            string string1 = Console.ReadLine();
            Console.Write("Nhập chuỗi thứ hai: ");
            string string2 = Console.ReadLine();
            Console.WriteLine($"Giá trị lớn nhất là: {Max(string1, string2)}");
        }

    }
}
