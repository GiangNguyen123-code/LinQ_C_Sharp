using System;
namespace LythuyetCS
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần 225LTC#02");
            Console.WriteLine("Bài 5: Bình phương các số ");
            Console.WriteLine("---------------------------------------------------------------");
            List<int> number = new List<int> { };
            Console.Write("Nhập số phần tử muốn có trong danh sách số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập số thứ {0}: ", i + 1);
                int s = int.Parse(Console.ReadLine());
                number.Add(s);
            }
            Console.Write("In danh sách các số nguyên ra màn hình: ");
            foreach (int so in number)
            {
                Console.Write("{0} ", so);
            }
            Console.WriteLine();
            Console.Write("Danh sách các số nguyên sau khi bình phương các số: ");
            var binhphuong = number.Select(x => x * x);
            foreach(int so in binhphuong)
            {
                Console.Write("{0} ", so);
            }
            Console.ReadLine();
        }

    }
}