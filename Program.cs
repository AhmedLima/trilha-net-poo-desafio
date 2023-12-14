using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "520", modelo: "Modelo 5", imei: "3457896532", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");


Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "13", modelo: "Modelo 13", imei: "5983856922", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");



