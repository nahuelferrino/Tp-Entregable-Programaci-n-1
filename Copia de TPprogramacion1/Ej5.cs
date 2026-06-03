public interface INotificable
{
    void EnviarMensaje(string texto);
    void Resetear();
}

public class CorreoElectronico : INotificable
{
    public void EnviarMensaje(string texto)
    {
        Console.WriteLine($"Enviando mail: {texto}");
    }
    public void Resetear()
    {
        
    }
}