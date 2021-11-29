using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Example
{
    public abstract class FabricaTransporte
    {
        public abstract ITransporte GetTransporte();

        //public void Entregar()
        //{
        //    ITransporte transporte = GetTransporte();
        //    Console.WriteLine(transporte.entregar());
        //}
    }
}
