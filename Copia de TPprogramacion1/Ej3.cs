public class Trabajador
{
    public virtual void RealizarTarea()
    {
        Console.WriteLine("El trabajador hace tareas generales.");
    }
}

public class Programador : Trabajador
{
    public override void RealizarTarea()
    {
        Console.WriteLine("El programador escribe código en C#.");
    }
}