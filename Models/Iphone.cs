using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
      
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void Instalando(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Iphone.);
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"app instalado!");
        }


  
    }
}

  
  