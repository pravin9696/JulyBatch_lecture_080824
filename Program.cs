using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsp1
{
    class class1
    {
        public void display()
        { 
        }
    }
}
namespace JulyBatch_lecture_080824
{
    
    class class2
    {
        //method overloading
        public void method1()
        { 
        }
        public void method1(int x)
        { 
        }
    }
    internal class Program
    {
        enum Gender:int
        {
            male=1, 
            female=2, 
            Trans=3
        }
        static void Main(string[] args)
        {
            #region
            ////true or false
            //Boolean b1;
            //bool b2 = false ;
            ////float
            //string s1="";
            //StringBuilder sb;

            //var v1 = s1 ;
            //dynamic d2;
            //var x = "3.14";
            //dynamic dno;

            //Console.WriteLine("Enter value:");
            //dno = Console.ReadLine();

            //Console.WriteLine(Gender.male);//0
            //Console.WriteLine(Gender.female);//1
            //Console.WriteLine((int)Gender.male);//0
            //Console.WriteLine((int)Gender.female);//1
            //Console.WriteLine("Enter 1:Male 2: Female 3: trans\nEnter gender of student");
            //int gn =int.Parse( Console.ReadLine());
            //if (gn==(int)Gender.male)
            //{
            //    Console.WriteLine("Gender is male");
            //}
            //else if (gn==(int)Gender.female)
            //{
            //    Console.WriteLine("Gender is Female");
            //}
            //else
            //{
            //    Console.WriteLine("Gender is Transgender");
            //}
            #endregion
          nsp1.class1 obj = new nsp1.class1();
            obj.display();
            Console.ReadKey();

        }
    }
}
