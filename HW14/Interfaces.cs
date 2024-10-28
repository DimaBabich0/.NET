using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    public interface IOutput
    {
        void ShowEven();
        void ShowOdd();
    }
    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
