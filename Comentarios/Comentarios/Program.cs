using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios
{
    internal class Program
    {
        // Metodo principal
        // Outra linha
        static void Main(string[] args)
        {
            /*
                Esse é 
                um bloco de 
                Comentário
                Posso inserir várias linhas
            */

            #region Primeira Parte
            Console.WriteLine("Primeira parte");
            #endregion

            #region Segunda Parte
            Console.WriteLine("Segunda parte");
            #endregion


            Console.ReadKey();
        }
    }
}
