using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{

    // 1 class co the kế thừa nhiều interface cùng lúc
    // 1 class có thể kế thừa 1 abstract và nhiều interface
    // => interface và abstract giống nhau ở chỗ đều bắt buộc class kế thừa phải triển khai các phương thức
    // đã được cài đặt sẵn mà chưa đc triển khai ở lớp cha 
    // 1 hoặc nhiều interface có thể viết chung 1 class với class con
    internal class ITStudent : Student, IDiChoi
    {
        public string MaLaptop;

        public string Place { get; set; }

        public ITStudent(string maLaptop, string studentId, string name,
            int birthYear, bool gender, string stdClass) :
            base(studentId, name, birthYear, gender, stdClass)
        {
            MaLaptop = maLaptop;
        }

        public void LenNui()
        {
            Console.WriteLine(" da lat");
        }

        

        

        public new void PrintInfo()
        {
            Console.WriteLine($"ITStudent's MaLApTop : {MaLaptop}");
            base.PrintInfo();
        }

        public void PrintInfo(string MaLaptop)
        {
            if (MaLaptop == "009")
            {
                Console.WriteLine($"ITStudent's ID : {studentId}");
                Console.WriteLine($"ITStudent's name : {name}");
                Console.WriteLine($"ITStudent's birthYear : {birthYear}");
                Console.WriteLine($"ITStudent's gender : {gender}");
                Console.WriteLine($"ITStudent's stdClass : {stdClass}");
                Console.WriteLine($"ITStudent's sdt : {sdt}");
            }
            else
            {
                Console.WriteLine("ma laptop sai");
            }

        }

        public void EatBBQ()
        {
            throw new NotImplementedException();
        }


        //public override void DiHoc()
        //{ Console.WriteLine("di hoc bang xe oto"); }
    }
}
