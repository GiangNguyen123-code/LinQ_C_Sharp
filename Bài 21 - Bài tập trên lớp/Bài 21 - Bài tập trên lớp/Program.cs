using System;
using System.Security.Cryptography.X509Certificates;
namespace LythuyetCS
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Khoa {  get; set; }
        public double namhoc { get; set; }
        public double Score {  get; set; }
    }
    class Bai21
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần 225LTC#02");
            Console.WriteLine("Bài 21: Bài tập trên lớp ");
            Console.WriteLine("---------------------------------------------------------------");
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "An",Age = 20, Khoa = "CNS", namhoc = 2, Score = 8 },
                new Student { Id = 2, Name = "Bình",Age = 22, Khoa = "Hoá", namhoc = 4, Score = 8.6 },
                new Student { Id = 3, Name = "Toàn",Age = 21, Khoa = "Cơ", namhoc = 3, Score = 7.8 },
                new Student { Id = 4, Name = "Khang",Age = 22, Khoa = "Điện", namhoc = 4, Score = 9.0 },
                new Student { Id = 5, Name = "Hoàng",Age = 19, Khoa = "CNS", namhoc = 1, Score = 6.8 },
                new Student { Id = 6, Name = "Chi", Age = 20, Khoa = "CNS", namhoc = 2, Score = 9.2 },
                new Student { Id = 7, Name = "Dũng", Age = 21, Khoa = "Điện", namhoc = 3, Score = 7.5 },
                new Student { Id = 8, Name = "Hạnh", Age = 18, Khoa = "CNS", namhoc = 1, Score = 8.1 },
                new Student { Id = 9, Name = "Linh", Age = 23, Khoa = "Cơ", namhoc = 5, Score = 6.5 },
                new Student { Id = 10, Name = "Nam", Age = 20, Khoa = "Hoá", namhoc = 2, Score = 8.9 },
                new Student { Id = 11, Name = "Mai", Age = 22, Khoa = "CNS", namhoc = 4, Score = 9.5 },
                new Student { Id = 12, Name = "Tuấn", Age = 21, Khoa = "Điện", namhoc = 3, Score = 8.3 },
                new Student { Id = 13, Name = "Hương", Age = 19, Khoa = "CNS", namhoc = 1, Score = 7.9 },
                new Student { Id = 14, Name = "Quốc", Age = 22, Khoa = "Cơ", namhoc = 4, Score = 8.7 },
                new Student { Id = 15, Name = "Lan", Age = 20, Khoa = "CNS", namhoc = 2, Score = 8.4 }
            };
            Console.WriteLine("Danh sách sinh viên ban đầu: ");
            foreach (Student st in students)
            {
                Console.WriteLine($"Id sinh viên: {st.Id}, Tên sinh viên: {st.Name}, Tuổi: {st.Age}, Khoa: {st.Khoa}, Năm học: {st.namhoc},Điểm số: {st.Score}");
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Lấy sinh viên tuổi lớn nhất và sinh viên tuổi nhỏ nhất: ");
            int maxAge = students.Max(s => s.Age);
            int minAge = students.Min(s => s.Age);
            Console.WriteLine($"- Tuổi lớn nhất: {maxAge}, Tuổi nhỏ nhất: {minAge}");
            Console.WriteLine("Kiểm tra có sinh viên nào thuộc khoa CNS: ");
            bool coCNS = students.Any(s => s.Khoa == "CNS");
            Console.WriteLine($"- Có sinh viên khoa CNS không: {(coCNS ? "Có" : "Không")}");
            Console.WriteLine("Lấy 10 sinh viên có điểm trung bình cao nhất khoa ");
            var top10 = students.OrderByDescending(s => s.Score).Take(10);
            foreach (var s in top10)
                Console.WriteLine($"  + {s.Name}: {s.Score}");
            Console.WriteLine("Lấy danh sách sinh viên (bỏ qua năm cuối): ");
            var sinhVienChuaRaTruong = students.Where(s => s.namhoc < 4);
            foreach (var s in sinhVienChuaRaTruong)
                Console.WriteLine($"  + {s.Name} (Năm {s.namhoc})");
            Console.ReadLine();
        }
    }
}