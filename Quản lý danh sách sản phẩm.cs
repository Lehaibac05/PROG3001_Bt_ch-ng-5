using System.Collections;
using System.Text;

namespace Quản_lý_danh_sách_sản_phẩm
{

    class Product
    {
        public string name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }

        public Product (string name,string Description, double price)
        {
            this.name = name;
            this.Description = Description;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Tên: {name}, Mô tả: {Description}, Giá: {price}";
        }



        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8 ;

                ArrayList productlist = new ArrayList();
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Quản lý danh sách sản phẩm");
                    Console.WriteLine("1.Thêm sản phẩm mới.");
                    Console.WriteLine("2.Hiển thị danh sách sản phẩm.");
                    Console.WriteLine("3.Tìm kiếm sản phẩm theo tên.");
                    Console.WriteLine("4.Thoát.");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice) {
                        case 1:
                            AddProduct(productlist);
                            break;
                        case 2:
                            DisplayProduct(productlist);
                            break;
                        case 3:
                            SearchProduct(productlist);
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Giá trị không hợp lệ, xin mời bạn nhập lại.");
                                break;
                    }

                    static void AddProduct(ArrayList productlist)
                    {
                        Console.Write("Nhập tên sản phẩm: ");
                        string name = Console.ReadLine();
                        Console.Write("Mô tả sản phẩm: ");
                        string description = Console.ReadLine();
                        Console.Write("Giá của sản phẩm: ");
                        double price = double.Parse(Console.ReadLine());

                        Product newProduct = new Product(name, description, price);
                        productlist.Add(newProduct);
                        Console.WriteLine("Thêm sản phẩm mới thành công!");
                    }

                    static void DisplayProduct(ArrayList productlist)
                    {
                        if (productlist.Count > 0)
                        {
                            Console.WriteLine("Danh sách sản phẩm: ");
                            foreach (Product product in productlist)
                            {
                                Console.WriteLine(product);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Không có sản phẩm nào trong danh sách.");
                        }
                    }

                    static void SearchProduct(ArrayList productList)
                    {
                        Console.Write("Nhập tên sản phẩm cần tìm: ");
                        string name = Console.ReadLine();
                        bool found = false;

                        foreach (Product product in productList)
                        {
                            if (product.name.ToLower().Contains(name.ToLower()))
                            {
                                Console.WriteLine(product);
                                found = true;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Không tìm thấy sản phẩm nào có tên như vậy.\n");
                        }
                    }
                }
            }
        }
    }
}
