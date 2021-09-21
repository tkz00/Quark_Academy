using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVistaPresentador_Example.Presentador
{
    public interface IView
    {
        void DisplayResult(string result);
        string GetInputDate();
    }
}
