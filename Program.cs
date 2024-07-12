using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BasicStatsCommandLine_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=Convert.ToInt32(args[0]);
            int num2=Convert.ToInt32(args[1]);
            int num3=Convert.ToInt32(args[2]);
            int num4=Convert.ToInt32(args[3]);
            int num5=Convert.ToInt32(args[4]);

            int[] myArr = {num1,num2,num3,num4,num5};
            int count=myArr.Length;
            int sum = 0;
            int avg;
            int max = int.MinValue;
            int min = int.MaxValue;
         
            for (int i = 0; i < myArr.Length; i++)
            {
               sum+= myArr[i];
                if(myArr[i] < min)
                {
                    min = myArr[i];
                }
                if (myArr[i] > max)
                {
                    max = myArr[i];
                }
            }
            avg=sum/myArr.Length;

            Console.WriteLine("The value of min and max are : "+min+" and "+max+" respectively");
            Console.WriteLine("The value of count is : " + count);
            Console.WriteLine("The value of sum and avg are : " + sum + " and " + avg + " respectively");
        }
    }
}
