using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("NOKIA:");
Smartphone nokia = new Nokia("123456", "modelo 2", "121212", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n-------------------\n");

Console.WriteLine("IPHONE:");
Smartphone iphone = new Iphone("654321", "modelo 1", "343434", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Nubank");