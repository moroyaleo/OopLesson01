using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {
        //-tom フィートからメートルへの対応表
        //-tof メートルからフィートへの対応表
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(5, 50);

            }
            else
            {
                //メートルからフィートへの対応表
                PrintMetertoFeetList(10, 10);
            }
        }

        //フィートからメートルへの対応表を出力
        //引数：start 最初の値
        //　　：stop　最後の値
        static void PrintFeetToMeterList(int start, int stop)
        {
            //FeetConverter converter = new FeetConverter(); //クラスの分離　for文の外に書く
            for (int i = start; i <= stop; i++)
            {
                double meter = FeetConverter.ToMeter(i); //クラスの分離
                Console.WriteLine("{0} ft = {1:0.0000}m", i, meter);
            }


        }

        //メートルからフィートへの対応表を出力
        static void PrintMetertoFeetList(int start, int stop)
        {
            //FeetConverter converter = new FeetConverter();
            for (int i = start; i <= stop; i++)
            {
                double feet = FeetConverter.ToMeter(i);
                Console.WriteLine("{0} m = {1:0.0000}ft", i, feet);
            }
        }
    }
}
