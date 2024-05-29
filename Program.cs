using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456", "Model 1", "11111111", 64);
Iphone iphone = new Iphone("987654", "Model X", "22222222", 128);

Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
