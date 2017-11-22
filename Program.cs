using System;

namespace ExemploDelegate1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data("Olá ");

            // DataCompleta("");
            // Console.WriteLine(DataCompleta("Naila"));

            Cortador vera = new Cortador(Data);
            vera("Olá, eu sou um delegate! :) ");

            Cortador filha = new Cortador(DataCompleta);

                
        }
        static void Data (string texto){
            Console.WriteLine(texto + "hoje é "+ DateTime.Now.ToShortDateString());
        }
        static void DataCompleta(string nome){
            Console.WriteLine("Olá "+nome+ " hoje é " + DateTime.Now.ToLongDateString());
        }
        //exempo de delegate
        public delegate void Cortador(string queijo);
             
    }
}