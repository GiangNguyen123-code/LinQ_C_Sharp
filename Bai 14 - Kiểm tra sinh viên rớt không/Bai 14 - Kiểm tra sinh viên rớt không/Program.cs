using System;
namespace LythuyetCS
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    class Bai14
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên sinh viên: Nguyễn Đỗ Hữu Giang");
            Console.WriteLine("Mã sinh viên: 2415053122312");
            Console.WriteLine("Lớp học phần: 225LTC#02");
            Console.WriteLine("Bài 14: Kiểm tra sinh viên rớt không ");
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
            Console.WriteLine("Kiểm tra trong danh sách sinh viên có sinh viên nào rớt không (Điểm < 5): ");
            var sv = students.Any(p=>p.Score < 5) ;
            if(sv == true)
            {
                Console.WriteLine("Có sinh viên rớt ");
                var ktra = students.Where(p => p.Score < 5) ;
                foreach(Student student in ktra)
                {
                    Console.WriteLine($"Id sinh viên: {student.Id}, tên sinh viên: {student.Name}, Điểm: {student.Score} ");
                }
            }
            else
            {
                Console.WriteLine("Không có sinh viên rớt ");
            }

            Console.ReadLine();
        }
    }
}