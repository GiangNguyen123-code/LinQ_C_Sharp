using System;
namespace LythuyetCS
{
    class Bai15
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần: 225LTC#02");
            Console.WriteLine("Bài 15: Loại bỏ phần tử trùng ");
            Console.WriteLine("---------------------------------------------------------------");
            List<int> ds = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            Console.Write("Danh sách ban đầu: ");
            foreach (int i in ds)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Danh sách sau khi loại bỏ phần tử trùng: ");
            var loaibo = ds.Distinct();
            foreach(int i in loaibo)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        }
    }
}