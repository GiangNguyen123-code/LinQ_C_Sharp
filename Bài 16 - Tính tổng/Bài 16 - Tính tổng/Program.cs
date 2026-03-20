using System;
namespace LythuyetCS
{
    class Bai16
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần: 225LTC#02");
            Console.WriteLine("Bài 16: Tính tổng");
            Console.WriteLine("---------------------------------------------------------------");
            List<int> ds = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            Console.Write("Danh sách ban đầu: ");
            foreach (int i in ds)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            var tong = ds.Sum();
            Console.WriteLine($"Tổng của các số trong danh sách trên: {tong}");
            Console.ReadLine();
        }
    }
}