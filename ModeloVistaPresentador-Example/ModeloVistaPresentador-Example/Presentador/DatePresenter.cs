using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloVistaPresentador_Example.Presentador
{
    class DatePresenter
    {
        private Modelo.Date dateModel;
        private IView view;

        public DatePresenter(IView view)
        {
            this.view = view;
            string dateInput = view.GetInputDate();
            string result = String.Empty;
            DateTime converted_dateInput;
            dateInput = dateInput.Trim(' ');

            if (dateInput == String.Empty)
            {
                result = "Por favor, ingrese una fecha válida.";
                this.view.DisplayResult(result);
            }else if (DateTime.TryParseExact(
                        dateInput,"dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out converted_dateInput)
                      )
            { // date is correct
                this.dateModel = new Modelo.Date(converted_dateInput);
                result = this.dateModel.DateIsPastPresentOrFuture().ToString();
                this.view.DisplayResult(result);
            }
            else
            {
                result = "La fecha ingresada es inválida";
                this.view.DisplayResult(result);
            }
        }
   
    }
}
