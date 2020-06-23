using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    //フィートとメートルの単位変換クラス
    public class FeetConverter
    {
        //private const double ratio = 0.3048;    //定数(constはprivateの時しか使わない)
        public static readonly double ratio = 0.3048;   //定数

        //メートルからフィートを求める（静的メソッドとして定義）
        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        //フィートからメートルを求める（静的メソッドとして定義）
        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }



    }
}