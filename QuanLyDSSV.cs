using System.Text;

namespace QuanLyDSSV
{
    class Student
    {
        public string name { get; set; }
        public string Class { get; set; }
        public double score { get; set; }

        public Student(string name, string Classname, double score) {
            this.name = name;
            this.Class = Classname;
            this.score = score;
        }

        class Program
        {
            static List<Student> students= new List<Student>();

            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                while (true)
                {
                    Console.WriteLine("MENU: ");
                    Console.WriteLine("1. Thêm một học sinh ");
                    Console.WriteLine("2. Hiển thị tất cả sinh viên");
                    Console.WriteLine("3. Tính tổng số điểm");
                    Console.WriteLine("4. Thoát ");
                    Console.WriteLine("Chọn từ 1-4");
                    int option = int.Parse(Console.ReadLine());

                    switch (option){
                        case 1:
                            AddStudent();
                            break;

                        case 2:
                            DisplayStudent();
                            break;

                        case 3:
                            CalculateTotalStore();
                            break;

                        case 4:
                            return;

                        default:
                            Console.WriteLine("Lựa chọn sai, xin mời nhập lại.");
                            break;
                    

                    }
                }
            }


            static void AddStudent()
            {
                Console.WriteLine("Nhập tên sinh viên: ");
                string name = Console.ReadLine();

                Console.WriteLine("Nhập tên lớp học: ");
                string Classname = Console.ReadLine();

                Console.WriteLine("Nhập điểm trung bình của bạn: ");
                double score = double.Parse(Console.ReadLine());

                Student newStudent = new Student(name, Classname, score);
                students.Add(newStudent);
                Console.WriteLine("Thêm học sinh thành công! ");
            }

            static void DisplayStudent()
            {
                Console.OutputEncoding = Encoding.UTF8;
                if (students.Count > 0)
                {
                    Console.WriteLine("Danh sách tất cả học sinh là:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"Name: {student.name}, Class: {student.Class}, Score: {student.score}");
                    }
                }
                else { Console.WriteLine("Chưa có học sinh nào trong danh sách."); }
            }


            static void CalculateTotalStore()
            {
                double totalScore = 0;
                foreach (var student in students)
                {
                    totalScore += student.score;
                }
                Console.WriteLine($"Tổng điểm cảu tất cả học sinh là: {totalScore}");
            }
        }
    }
}
