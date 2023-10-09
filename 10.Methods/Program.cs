using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //calling a method, this can be done many times,
            //methods and fuction are literally the same in C#,
            //prefarably call them methods
            SayHi();
            //Method with parameters
            SayHiUser("Dinah");

            //Method with more parameters
            SayHiAge("Dineo", 29);
            //freezing the console
            Console.ReadLine();
        }
        //Creating a method, ignore static for now, use capitals as er convention.
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        //Method with one parameter

        static void SayHiUser(String name)

        {
           Console.WriteLine("Hello "+ name);

        }
            //Method with many parameters
            static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello" + name + "you are" + age);

            Console.Read();


        }
    }
}
