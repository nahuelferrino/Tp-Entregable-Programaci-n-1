public class Termometro
{
    public double Temperatura { get; private set; }

    public Termometro()
    {
        Temperatura = 20.0; // Temperatura inicial por defecto
    }

    public void Actualizar(double lecturaSensor)
    {
        // El método aplica un filtro de seguridad antes de asignar
        if (lecturaSensor >= -50.0 && lecturaSensor <= 100.0)
        {
            Temperatura = lecturaSensor;
        }
        else
        {
            Console.WriteLine("Error: Lectura extrema ignorada.");
        }
    }
}
