using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas 
        { 
            Minimo, 
            Media, 
            Maxima
        }

        struct Pessoa
        {
           public string nome;
           public int idade;
           public double altura;
        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            ///*
            // A diferença entre o tipo de Integral assinado e integral não assiado é que o integral assinado suporte valores com números negativos
            //já a integral não assinado não suporte esses numeros negativos
            // */
            ////Integral assinado 
            //sbyte num1 = 10; // 8 bits 
            //short num2 = 20; // 16 bits
            //int num3 = 30;// 32 bits
            //long num4 = 40L; // 64 bits

            //// Integral sem sinal
            //byte num5 = 10;
            //ushort num6 = 20;
            //uint num7 = 30;
            //ulong num8 = 40L;

            //sbyte numero;
            //numero = num1;
            #endregion


            #region Numeros Reais

            //float real1 = 100.75F; // 32 bits itervalo bem grande kkkk
            //double real2 = 500.754; // 64 bits, N necessita de letra 
            //decimal real3 = 75333.457M; // 128 bits Necessita de uma letra auxiliar qunado é atribuido um valor literar


            //double valor;
            //valor = 500; //Atribuindo da forma literal

            //valor = real1; //Atribuindo da forma  por referencia

            #endregion

            #region Char
            //char letra = 'a'; // Aceita somenta um caractere e tem que ser escrito em aspas simples;
            //char letra2 = '\u0041';
            //char escape = '\\';
            #endregion

            #region Boolean
            //bool verificar = false;
            #endregion

            #region Strings
            // Iniciando com @ ele transforma tudo em string
            //string texto = @"Lucas de Freitas \n Gonçalves";
            //string messagem = null;
            #endregion

            #region Var
            // Ao utilizar var pra criar uma variavel ela não defini o valor na inicialização
            // Somente depois de atribuir o valor
            // A variavel vai com o tipo até o final do programa
            //var valor = "Gabriel";
            #endregion

            #region Object

            object obj = false;
            obj = true;
            obj = 200;

            #endregion

            #region Constantes
            //Toda constante tende a ter o valor definido na sua criação
            const double pi = 3.1415;
            const string nome = "Lucas de Freitas Gonçalves";

            #endregion


            #region Enum
            Notas notasAlunos = Notas.Minimo;
            #endregion

            #region Structs


            Pessoa p1 = new Pessoa
            {
                nome = "Lucas",
                idade = 26,
                altura = 1.76
            };

        #endregion
        Console.WriteLine($"Nome: {p1.nome} \n idade: {p1.idade} \n altura: {p1.altura}");
        Console.ReadLine();
        }
    }
}
