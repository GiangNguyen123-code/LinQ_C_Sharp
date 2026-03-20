using System;
using System;
namespace LythuyetCS
{
    class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double dToan { get; set;  }
        public double dVan { get; set; }
        public double dAnh { get; set; }
    }
    class Bai17
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần: 225LTC#02");
            Console.WriteLine("Bài 17: Tính trung bình ");
            Console.WriteLine("---------------------------------------------------------------");
            List<Student> sinhvien = new List<Student>
            {
                new Student{Id = 1, Name = "Hoàng", dToan = 8.7, dVan = 7.6, dAnh = 9.0},
                new Student{Id = 2, Name = "Lan", dToan = 5.3, dVan = 1.6, dAnh = 2.0},
                new Student{Id = 3, Name = "Hồng", dToan = 6.9, dVan = 8.0, dAnh = 10.0},
                new Student{Id = 4, Name = "Út", dToan = 4.3, dVan = 9.6, dAnh = 9.0},
                new Student{Id = 5, Name = "Anh", dToan = 8, dVan = 7, dAnh = 9},
                new Student{Id = 6, Name = "Hùng", dToan = 7, dVan = 7.6, dAnh = 5.6}
            };
            foreach(Student sv in sinhvien)
            {
                Console.WriteLine($"Id: {sv.Id}, Tên sinh viên: {sv.Name}, Điểm toán: {sv.dToan}, Điểm Văn: {sv.dVan}, Điểm Anh: {sv.dAnh}");
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Danh sách điểm trung bình của sinh viên: ");
            var ketQua = sinhvien.Select(sv => new {sv.Id, sv.Name,DiemTrungBinh = new[] { sv.dToan, sv.dVan, sv.dAnh }.Average()});
            foreach (var sv in ketQua)
            {   
                Console.WriteLine($"Id: {sv.Id} | Tên sinh viên: {sv.Name} | Điểm trung bình: {sv.DiemTrungBinh:F2}");
            }
            Console.ReadLine();
        }
    }
}