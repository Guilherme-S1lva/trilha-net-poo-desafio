using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
       

        public Smartphone(string numero)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        protected Smartphone(string numero)
        {
            Numero = numero;
        }
        public void ModeloCelular(string modelo)
        {
            Console.WriteLine("Modelo"+ modelo);
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void Instalando(string nomeApp);
        public abstract void InstalarAplicativo(string nomeApp);

    }
}