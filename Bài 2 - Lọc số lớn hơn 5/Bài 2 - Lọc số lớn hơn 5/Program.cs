using System;
namespace LythuyetCS
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần 225LTC#02");
            Console.WriteLine("Bài 2: Lọc số lớn hơn 5");
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.Write("In danh sách các số nguyên ra màn hình: ");
            foreach (int i in number)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.Write("Các số lớn hơn 5 là: ");
            var sohon5 = number.Where(p => p > 5);
            foreach(int i in sohon5)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        }

    }
}