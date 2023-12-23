using DesafioPOO.Models;

Console.WriteLine($"Iniciando testes com o celular Nokia:");
Nokia nokia = new Nokia(numero: "4567", modelo: "modelo 1", imei: "1111111111",memoria: 64);
nokia.ModeloCeluar(": Modelo 1");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.Instalando("Whatsapp");
nokia.InstalarAplicativo("");

Console.WriteLine("");


Console.WriteLine("");



Iphone iphone = new Iphone(numero: "2324", modelo: "Modelo 2", imei: "222222222",memoria: 128);
iphone.ModeloCeluar(": modelo 2");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.Instalando("Telegram");
iphone.InstalarAplicativo("");

Console.WriteLine("");




