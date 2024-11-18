using System;
using System.Collections.Generic;
using System.Linq;
using StudentManagement;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "An", Age = 16 },
                new Student { Id = 2, Name = "Binh", Age = 14 },
                new Student { Id = 3, Name = "Anh", Age = 18 },
                new Student { Id = 4, Name = "Lan", Age = 17 },
                new Student { Id = 5, Name = "Bao", Age = 15 }
            };

            while (true)
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Xem danh sách toàn bộ học sinh");
                Console.WriteLine("2. Xem danh sách học sinh có tuổi từ 15 đến 18");
                Console.WriteLine("3. Tìm học sinh có tên bắt đầu bằng chữ 'A'");
                Console.WriteLine("4. Tính tổng tuổi của tất cả học sinh");
                Console.WriteLine("5. Tìm học sinh có tuổi lớn nhất");
                Console.WriteLine("6. Sắp xếp danh sách học sinh theo tuổi tăng dần");
                Console.WriteLine("7. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nDanh sách toàn bộ học sinh:");
                        students.ForEach(student => Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}"));
                        break;

                    case 2:
                        var age15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
                        Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
                        foreach (var student in age15to18)
                        {
                            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
                        }
                        break;

                    case 3:
                        var startsWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
                        foreach (var student in startsWithA)
                        {
                            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
                        }
                        break;

                    case 4:
                        int totalAge = students.Sum(s => s.Age);
                        Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");
                        break;

                    case 5:
                        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
                        Console.WriteLine($"\nHọc sinh lớn tuổi nhất: {oldestStudent.Id} - {oldestStudent.Name} - {oldestStudent.Age}");
                        break;

                    case 6:
                        var sortedByAge = students.OrderBy(s => s.Age);
                        Console.WriteLine("\nDanh sách học sinh sắp xếp theo tuổi tăng dần:");
                        foreach (var student in sortedByAge)
                        {
                            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                        break;
                }
            }
        }
    }
}
