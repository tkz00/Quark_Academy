using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Electrodomesticos
{
    abstract class Electrodomestico
    {
        private readonly Dictionary<string, ConsoleColor> coloresValidos = new Dictionary<string, ConsoleColor>() { { "Blanco", ConsoleColor.White }, { "Negro", ConsoleColor.Black }, { "Rojo", ConsoleColor.Red }, { "Azul", ConsoleColor.Blue }, { "Gris", ConsoleColor.Gray } };


        #region Atributos
        private float precioBase;
        private ConsoleColor color;
        private char consumo;
        private int peso;
        #endregion

        #region Propiedades
        public float PrecioBase
        {
            get
            {
                return this.precioBase;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }

        public char Consumo
        {
            get
            {
                return this.consumo;
            }
        }

        public int Peso
        {
            get
            {
                return this.peso;
            }
        }
        #endregion

        #region Constructores
        public Electrodomestico()
        {
            this.precioBase = 100;
            this.color = ConsoleColor.White;
            this.consumo = 'F';
            this.peso = 5;
        }

        public Electrodomestico(float PrecioBase, int Peso) : this()
        {
            if (PrecioBase <= 0)
            {
                throw new ArgumentException("El precio base del electrodomestico no puede ser menor o igual a cero.", nameof(PrecioBase));
            }

            this.precioBase = PrecioBase;

            if (Peso <= 0)
            {
                throw new ArgumentException("El peso del electrodomestico no puede ser menor o igual a cero.", nameof(Peso));
            }

            this.peso = Peso;
        }

        public Electrodomestico(float PrecioBase, ConsoleColor Color, char Consumo, int Peso) : this(PrecioBase, Peso)
        {
            if(this.ColorValido(Color))
            {
                throw new ArgumentException("El color del electrodomestico ingresado no es valido.", nameof(Color));
            }

            this.color = Color;
            this.consumo = Consumo;
        }

        //Tener esta sobrecarga de constructor no es muy efectivo porque hace basicamente lo mismo que el de arriba, pero no pude encontrar una forma de validar el color y convertirlo para invocar desde este constructor al constructor de arriba.
        public Electrodomestico(float PrecioBase, string Color, char Consumo, int Peso) : this(PrecioBase, Peso)
        {
            if (this.ColorValido(Color))
            {
                throw new ArgumentException("El color del electrodomestico ingresado no es valido.", nameof(Color));
            }

            this.color = coloresValidos[Color];

            if (!((Consumo >= 'A' && Consumo <= 'F') || (Consumo >= 'a' && Consumo <= 'f')))
            {
                throw new ArgumentException("El consumo del electrodomestico ingresado no es válido.", nameof(Consumo));
            }

            this.consumo = Consumo;
        }
        #endregion

        private bool ColorValido(string Color)
        {
            if (coloresValidos.ContainsKey(string.Concat(Color[0].ToString().ToUpper(), Color.Substring(1))))
                return true;
            else
                return false;
        }

        private bool ColorValido(ConsoleColor Color)
        {
            if (coloresValidos.ContainsValue(Color))
                return true;
            else
                return false;
        }
    }
}
