using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TitkovAA.Sprint1.SprintReview1.V0.Lib
{
    public class DataService : ISprint1Task7V13
    {

        public double Calculate(double x, double y)
        {
            return Math.Round((Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12), 3);
        }
    }
}
