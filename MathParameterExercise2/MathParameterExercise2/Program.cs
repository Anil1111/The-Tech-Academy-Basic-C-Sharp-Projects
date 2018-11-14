using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParameterExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathCall1 = new MathClass();
            int answer = mathCall1.EasyMath(12);
            Console.WriteLine(answer);
            Console.ReadLine();

            MathClass mathCall2 = new MathClass();
            answer = mathCall2.EasyMath(83.65m);
            Console.WriteLine(answer);
            Console.ReadLine();

            MathClass mathCall3 = new MathClass();
            answer = mathCall3.EasyMath("75");
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
