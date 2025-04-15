using bt1;

namespace bt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vd1
            //Student sv1 = new Student("001","ALICE");
            //Student sv2 = new Student("002","KIEU",15,true,"HA1");
            //Console.WriteLine(" nhap so dien thoai 1");
            //string sdt1 = Console.ReadLine();
            //sv1.setSdt(sdt1);
            //sv1.sdt = sdt1;


            //var tmp = sv1.sdt;

            //Student sv2 = new Student("009", "kieu", 14, true, "HA1");
            //ITStudent sv3 = new ITStudent ("0094", "005", "ha", 18, false, " ha3");
            //ITStudent sv3 = (ITStudent) new Student("009", "kieu", 14, true, "HA1");

            //Console.WriteLine($"{sv3.MaLaptop}");
            //sv3 = (ITStudent)sv2;



            //Console.WriteLine();
            //sv3.PrintInfo();
            //sv3.XuongBien();
            //sv3.LenNui();
            int b;
            int a = 0;
            b = a;
            b = 2;
            Console.WriteLine(b);//b=2
            Console.WriteLine(a);// a=2
            ITStudent sv4 =  new ITStudent("008", "004", "ha", 18, false, " ha3");
            ITStudent sv5 = sv4;
            sv5.MaLaptop = "009";
            sv4.PrintInfo();
            sv5.PrintInfo();
            Console.WriteLine();
           // sv4.XuongBien();
            //ITStudent sv5 = (ITStudent)sv4;
            //Console.WriteLine($"{sv5.MaLaptop}");
            //sv5.PrintInfo();

            //sv4.PrintInfo();
            //Console.WriteLine();
            ////sv2.PrintInfo();

            ////IDiAn sv8 = new IDiAn(
            //Student sv1 = new("009", "kieu", 14, true, "HA1");
        }
    }
}