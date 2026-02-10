using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Santiago_Githun_Calculator_Sample
{
    internal class Multiplication
    {
       public double Multiply(double num1, double num2) // return type is double, method name is Multiply, and it takes two double parameters num1 and num2
        {
            return num1 * num2; // The method multiplies num1 and num2 and returns the result as a double.         
        }
    }
}
