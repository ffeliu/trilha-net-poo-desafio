﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("123456789", "Iphone 13", "123456789012345", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");


Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);
nokia.Ligar(); 
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
Console.WriteLine("Testes concluídos.");    


