public class Motor
{
    public void Encender()
    {
        Console.WriteLine("Encendido!");
    }
}
public class Coche
{
    public Coche()
    {
        MotorDelCoche = new Motor();
    }
    public Motor MotorDelCoche {get; set;}

    public void Arrancar()
    {
        MotorDelCoche.Encender();
    }
}