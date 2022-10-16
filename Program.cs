using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234567", modelo: "modelo 1", imei: "22222222", memoria: 64 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "2534789", modelo: "modelo 2", imei: "88888888", memoria: 128 );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");