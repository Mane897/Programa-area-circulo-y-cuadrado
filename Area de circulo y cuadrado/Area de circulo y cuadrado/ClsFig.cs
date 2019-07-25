using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_circulo_y_cuadrado
{
    public class ClsFig : clsAbs
    {
        public ClsFig()
        {
            Opcion = 0;
            Var1 = 0;
            Var2 = 0;
            Var3 = 0;
            Titulo = string.Empty;
            Texto1 = string.Empty;
            Texto2 = string.Empty;
            Resultado = string.Empty;
            Texto3 = string.Empty;
            Texto4 = string.Empty;
        }
        public ClsFig(int pOpcion, int pVar1, int pVar2,double pVar3, string pTitulo,string pTexto1, string pTexto2, string pResultado, string pTexto3, string pTexto4)
        {
            Opcion = pOpcion;
            Var1 = pVar1;
            Var2 = pVar2;
            Var3 = pVar3;
            Titulo = pTitulo;
            Texto1 = pTexto1;
            Texto2 = pTexto2;
            Resultado = pResultado;
            Texto3 = pTexto3;
            Texto4 = pTexto4;
            
        }

        public override int Opcion { get; set; }
        public override int Var1 { get; set; }
        public override int Var2 { get; set; }
        public override double Var3 { get; set; }
        public override string Titulo { get; set; }
        public override string Texto1 { get; set; }
        public override string Texto2 { get; set; }
        public override string Resultado { get; set; }
        public override string Texto3 { get; set; }
        public override string Texto4 { get; set; }
    }
}
