using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MaslennikovVA.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            return Math.Round(3.1415 * (r * r) * h, 3);
        }
    }
}
