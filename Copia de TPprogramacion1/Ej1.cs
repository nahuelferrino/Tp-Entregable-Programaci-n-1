public class Vehiculo
{
    public string Marca { get; set; }

    public Vehiculo(string marca)
    {
        Marca = marca;
    }
}

public class Auto : Vehiculo
{
    public int Puertas { get; set; }

    public Auto(string marca, int puertas)
    : base(marca)
    {
        
        Puertas = puertas;
    }
}