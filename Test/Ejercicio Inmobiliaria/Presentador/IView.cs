using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Inmobiliaria.Presentador
{
    public interface IView
    {
        void MostrarResultado(string resultado);

        Dictionary<string, string> GetInputData();
    }
}
