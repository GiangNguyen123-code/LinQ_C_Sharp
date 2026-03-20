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
            Console.WriteLine("Bài 19: Tìm số xuất hiện nhiều nhất");
            Console.WriteLine("---------------------------------------------------------------");
            List<int> ds = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            Console.Write("Danh sách ban đầu: ");
            foreach (int i in ds)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            int maxCount = ds.GroupBy(n => n).Max(g => g.Count()); 
            var nhungSoNhieuNhat = ds.GroupBy(n => n).Where(g => g.Count() == maxCount);
            Console.WriteLine($"Số lần xuất hiện nhiều nhất là: {maxCount} lần");
            Console.Write("Các số xuất hiện nhiều nhất là: ");
            foreach (var nhom in nhungSoNhieuNhat)
            {
                Console.Write($"{nhom.Key} "); 
            }
            Console.ReadLine();
        }
    }
}