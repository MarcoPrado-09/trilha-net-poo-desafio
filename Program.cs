using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "99876", modelo: "13", imei: "221221221", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "99845", modelo: "2S", imei: "112112112", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");