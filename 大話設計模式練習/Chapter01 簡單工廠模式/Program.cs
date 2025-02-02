using OperationDemo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.createOperate("/");
            oper.NumberA = 1;
            oper.NumberB = 0;
            double result = oper.GetResult();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
