using DesafioPOO.Models;

Console.WriteLine("Sobre o Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123", modelo: "Iphone 13", imei: "2323232", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Uber");

Console.WriteLine("\n");
string texto = new String('#', 54);
Console.WriteLine(texto);
Console.WriteLine("\n");

Console.WriteLine("Sobre o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "456", modelo: "Nokia C01", imei: "2424242", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("LinkedIn");