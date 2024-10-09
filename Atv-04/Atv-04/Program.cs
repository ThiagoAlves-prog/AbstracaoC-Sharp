Carro c1 = new Carro("Mazda", "RX-7", 255, 3.5, 2.7);
Carro c2 = new Carro("Fiat", "Uno Mille", 223, 8.9, 7.6);
Carro c3 = new Carro("Honda", "Civic", 183, 10.6, 8.9);


Console.WriteLine("O carro " + c1.Marca + " modelo: " + c1.Modelo + " velocidade máxima: " + c1.Velocidade + "Km/h");
c1.acelerar();
c1.desacelerar();



Console.WriteLine("\n O carro " + c2.Marca + " modelo: " + c2.Modelo + " velocidade máxima: " + c2.Velocidade + "Km/h");
c2.acelerar();
c2.desacelerar();


Console.WriteLine("\n O carro " + c3.Marca + " modelo: " + c3.Modelo + " velocidade máxima: " + c3.Velocidade + "Km/h");
c3.acelerar();
c3.desacelerar();

Console.ReadKey();