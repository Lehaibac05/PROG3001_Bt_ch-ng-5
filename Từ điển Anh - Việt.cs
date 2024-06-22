using System.Text;
using System.Threading.Channels;

namespace Từ_điển_Anh___Việt
{
    internal class Program
    {

        static Dictionary<string, string> dictionary = new Dictionary<string, string>() ;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("MENU: ");
                Console.WriteLine("1. Thêm một từ mới.");
                Console.WriteLine("2. Tìm một từ trong từ điển.");
                Console.WriteLine("3. Thoát.");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddWord();
                        break;
                    case 2:
                        Lookupword(); 
                        break;
                    case 3:
                        return;

                    default:
                        Console.WriteLine("Không hợp lệ, mời bạn nhập lại.");
                        break;
                }
            }
        }

        static void AddWord() {
            Console.WriteLine("Nhập một từ tiếng Anh: ");
            string Englishword = Console.ReadLine();
            Console.WriteLine("Nhập nghĩa TV của từ đó: ");
            string VietnameseMeaning = Console.ReadLine();

            if (dictionary.ContainsKey(Englishword))
            {
                Console.WriteLine("Từ này đã có trong từ điển.");
            } else {
                dictionary.Add(VietnameseMeaning, Englishword);
                Console.WriteLine("Thêm từ mới thành công.");
            }
        }


        static void Lookupword()
        {
            Console.WriteLine("NHập từ tiếng Anh bạn muốn tìm: ");
            string Englishword = Console.ReadLine();

            if (dictionary.TryGetValue(Englishword, out string VietnameseMeaning))
            {
                Console.WriteLine($"Nghĩa Tiếng Viết của từ '{Englishword}' là: {VietnameseMeaning}");
            }
            else
            {
                Console.WriteLine("Từ này không có trong từ điển.");
            }
        }


    }
}
