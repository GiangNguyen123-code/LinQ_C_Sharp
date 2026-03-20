using System;
namespace LythuyetCS
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần 225LTC#02");
	    Console.WriteLine("Bài 1: Lọc số chẵn");
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.Write("In danh sách các số nguyên ra màn hình: ");
            foreach(int i in number)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            Console.Write("Các số chẵn trong list là: ");
            var sochan = number.Where(p => p % 2 == 0);
            foreach (var s in sochan)
            {
                Console.Write("{0} ",s);
            }
            Console.ReadLine();
        }

    }
}