public class Carro
{

    public string Marca { get; set; }

    public string Modelo { get; set; }

    public double Velocidade { get; set; }

    public double Acelera { get; set; }

    public double Desacelera { get; set; }

    public Carro(string marca, string modelo, double velocidade, double acelera, double desacelera)
    {
        Marca = marca;
        Modelo = modelo;
        Velocidade = velocidade;
        Acelera = acelera;
        Desacelera = desacelera;
    }

    public void acelerar()
    {
        Console.WriteLine($"O carro {Marca} faz um 0 a 100 Km/h de {Acelera} segundos");
    }

    public void desacelerar()
    {
        Console.WriteLine($"O carro {Marca} desacelera {Desacelera} de 0 a 100 Km/h");

    }
}