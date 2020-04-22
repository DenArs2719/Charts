using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts
{
    interface IFunction
    {
        string FunctionName
        {
            get;
        }

        double Value(double x);

        event emptyFunction FunctionChanged; ///definicja zdarzenia(eventa)

    }

    
    public delegate void emptyFunction(); ///tworzenie delegata


}
