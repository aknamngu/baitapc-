using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    interface IDiAn
    {
        public void EatBBQ();
    }
    interface IDiChoi 
    {
        //public string name;
        //public string GetName()
        //{
        //    return this.name;
        //}
        //public void SetName(string newName)
        //{
        //    this.name = newName;
        //}

        
        public string Place { get; set; }

        public void XuongBien() 
        { 
            Console.WriteLine("abc"); 
        }

        public void LenNui();
    }
    public abstract class Student
    {
        
        //public abstract void DiHoc();
        

        //atributes
        internal string studentId;
        public string name;
        public int birthYear;
        public bool gender;
        public  string stdClass;

        public string sdt;

        

        //constructor
        public Student(string studentId, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentId = studentId;
            this.name = name;
            this.birthYear = birthYear;
            this.gender = gender;
            this.stdClass = stdClass;
        }

        public Student(string studentId, string name)
        {
            this.studentId = studentId;
            this.name = name;
        }


        //propeties
        public void setSdt(string sdt) { this.sdt = sdt; }
        public string GetStudentId()
        {
            return this.studentId;
        }
        public void SetStudentId(string newId)
        {
            this.studentId = newId;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string newName)
        {
            this.name = newName;
        }
        public int GetBirthYear()
        {
            return this.birthYear;
        }
        public void SetBirthYear(int newBirthYear)
        {
            int curYear = DateTime.Now.Year;
            if (newBirthYear >= 1900 && newBirthYear <= curYear)
            {
                this.birthYear = newBirthYear;
            }
            else
            {
                Console.WriteLine("nhap nam sinh khong hop le");
                this.birthYear = 1900;
            }
        }
        public bool GetGender()
        {
            return this.gender;
        }
        public void SetGenDer(bool newGenDer)
        {
            this.gender = newGenDer;
        }
        public string GetStdClass()
        {
            return this.stdClass;
        }
        public void GetStdClass(string newStdClass)
        {
            this.stdClass = newStdClass;
        }

        public void Input()
        {
            Console.Write("nhap ma sv:");
            studentId = Console.ReadLine();
            Console.Write("nhap ten sv:");
            name = Console.ReadLine();
            Console.Write("nhap nam sinh cua sv:");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("nhap gioi tinh sv:");
            gender = bool.Parse(Console.ReadLine());
            Console.Write("nhap ma lop cua sv:");
            studentId = Console.ReadLine();
        }

        public int GetAge()
        {
            return DateTime.Now.Year;
        }

        internal virtual void PrintInfo()
        {
            
            Console.WriteLine($"Student's ID : {studentId}");
            Console.WriteLine($"Student's name : {name}");
            Console.WriteLine($"Student's birthYear : {birthYear}");
            Console.WriteLine($"Student's gender : {gender}");
            Console.WriteLine($"Student's stdClass : {stdClass}");
            Console.WriteLine($"Student's sdt : {sdt}");
        }
        

    }
}
