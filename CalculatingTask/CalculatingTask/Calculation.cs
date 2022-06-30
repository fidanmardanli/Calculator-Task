using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTask
{
    public class Calculating : ICalculation 
    {
        public void Calculation(int num, int num2, string marking)
        {
            int a = num + num2;
            int b = num - num2;
            int c = num * num2;
            int d = num / num2;

            {
                if (marking == "+")
                {
                    Console.WriteLine(a);
                }
                else if (marking == "-")
                {
                    Console.WriteLine(b);
                }
                else if (marking == "*")
                {
                    Console.WriteLine(c);
                }
                else if (marking == "/")
                {
                    Console.WriteLine(d);
                }
            }
 }   }   } 
 
