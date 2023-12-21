using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smatrphone iPhone:");
Smartphone iPhone = new Iphone(numero: "F2LZAJXNUZ08W", modelo: "iPhone 11 Pro Max", imei: "01010101", memoria: 64);
iPhone.Ligar();
iPhone.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smatrphone Nokia:");
Smartphone nokia = new Nokia(numero: "DB1029882892920", modelo: "C21 plus", imei: "110101001", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.ReadLine();