using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {

        static void Main(string[] args)

        {

            if (args.Length >= 1 && args[0] == "-tom")

            {

                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(5, 50);
            }
            else
            {
                PrintMeterToFeetList(10, 100);
            }


        }



        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, feet * 0.3048);

            }
        }





        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {

                Console.WriteLine("{0} m = {1:0.0000} ft", meter, meter / 0.3048);

            }



        }
    }    
}
            

                
                   

                
            
           
         