using System;

namespace SV
{
    internal class Student
    {
        private string MaSV;
        private string HoTen;
        private float DTB;

        public string maSV { get => MaSV; set => MaSV = value; }
        public string hoTen { get => HoTen; set => HoTen = value; }
        public float diemTB { get => DTB; set => DTB = value; }


        public Student()
        {

        }

        public Student(string MaSV, string HoTen, float DTB)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.DTB = DTB;

        }

        public void Input()
        {
            Console.WriteLine("Nhap MSSV: "); MaSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten: "); HoTen = Console.ReadLine();
            Console.WriteLine("Nhap DTB: "); DTB = float.Parse(Console.ReadLine());

        }

        public void Output()
        {
            Console.WriteLine("MSSV: {0}, Ho Ten: {1}, DTB = {2}", this.MaSV, this.HoTen, this.DTB);

        }
    }
}