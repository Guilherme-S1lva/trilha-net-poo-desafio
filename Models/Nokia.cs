using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Nokia: Smartphone
    

        public NOkia (string numero, string modelo, string imei, int memoria)
        {

        }
        

        public override void Instalando(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Nokia.");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("app instalado!")
        }


  
    }
}