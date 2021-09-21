using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVistaPresentador_Example.Modelo
{
    class Date
    {
        private DateTime dateInput;
        private DateTime today = DateTime.UtcNow.Date;

        public Date(DateTime dateInput)
        {
            this.dateInput = dateInput;
        }

        public string DateIsPastPresentOrFuture()
        {
            int result = DateTime.Compare(dateInput, today);
            string stringResult = String.Empty;
            if(result < 0)
            {
                stringResult = "La fecha ingresada es del PASADO.";
            }else if(result == 0)
            {
                stringResult = "La fecha ingresada es del PRESENTE.";
            }else if(result > 0)
            {
                stringResult = "La fecha ingresada es del FUTURO.";
            }
 
            return stringResult;
        }
    }
}
