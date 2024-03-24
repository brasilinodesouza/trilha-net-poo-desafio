using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone




Smartphone n = new Nokia(numero: "47-991373319", modelo:"NOKIA 123", imei: "555", memoria: 64);
n.Apresentar();
n.InstalarAplicativo("WhatsApp");
n.Ligar();
n.ReceberLigacao();
System.Console.WriteLine("\n");
Smartphone i = new Iphone(numero: "47-77777777", modelo:"IPHONE 999", imei: "999", memoria: 128);
i.Apresentar();
i.InstalarAplicativo("Instagran");
i.Ligar();
i.ReceberLigacao();



