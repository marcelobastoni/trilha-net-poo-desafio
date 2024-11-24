using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("99999-9999","12","11111",128);

Console.WriteLine("Testando Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp ");

Iphone iphone = new Iphone("88888-8888","16","99999",256);

Console.WriteLine("Testando Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp ");