using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uczelnia UWM = new Uczelnia(DateTime.Parse("2017/11/11"));
            Uczelnia Stamford = new Uczelnia(DateTime.Parse("2018/11/11"));

            Console.WriteLine(UWM.RekrutujStudentow());
            Console.WriteLine(Stamford.RekrutujStudentow());
            Console.ReadLine();
        }
    }
}
