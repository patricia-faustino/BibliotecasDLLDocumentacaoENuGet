using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {       
            ModificadoresTeste testando = new ModificadoresTeste();
            testando.MetodoPublico();
            testando.MetodoInternal();
        }
         
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            // consigo chamar ele nessa classe por ser uma classe derivada da classe que impleta o método
            MetodoProtegido();

        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Vísiviel fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            // Vísiviel apenas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            // Vísiviel apenas na classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInternal()
        {
            // Vísivel apenas para ByteBank.Modelos
        }
    }
}
