using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_circulo_y_cuadrado
{
    public abstract class clsAbs
    {
        public abstract int Opcion { get; set; }
        public abstract int Var1 { get; set; }
        public abstract int Var2 { get; set; }
        public abstract double Var3 { get; set; }
        public abstract string Titulo { get; set; }
        public abstract string Texto1 { get; set; }
        public abstract string Texto2 { get; set; }
        public abstract string Resultado { get; set; }
        public abstract string Texto3 { get; set; }
        public abstract string Texto4 { get; set; }

    }
}
