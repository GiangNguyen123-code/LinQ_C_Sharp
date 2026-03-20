using System;
namespace LythuyetCS
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    class Bai13
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần: 225LTC#02");
            Console.WriteLine("Bài 13: Lấy sinh viên đầu tiên có điểm > 7 ");
            Console.WriteLine("---------------------------------------------------------------");
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "An", Score = 8 },
                new Student { Id = 2, Name = "Binh", Score = 6 },
                new Student { Id = 3, Name = "Chi", Score = 9 },
                new Student { Id = 4, Name = "Dung", Score = 7 }
            };
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (Student st in students)
            {
                Console.WriteLine($"Id sinh viên: {st.Id}, Tên sinh viên: {st.Name}, Điểm số: {st.Score}");
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Sinh viên đầu tiên có điểm > 7: ");
            var sv = students.FirstOrDefault(i => i.Score > 7);
            
            Console.WriteLine($"Id sinh viên: {sv.Id}, Tên sinh viên: {sv.Name}, Điểm số: {sv.Score}");
            
            Console.ReadLine();
        }
    }
}