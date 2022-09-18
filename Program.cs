using DesafioPOO.Models;

Iphone iphone = new Iphone("1234-5678", "111", 256);
Nokia nokia = new Nokia("2345-6789", "222", 64);

iphone.Ligar();
iphone.ReceberLigacao();

nokia.Ligar();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("dio.me");
nokia.InstalarAplicativo("dio.me");