namespace Ejercicios_De_Recursividad.Queues;

public class Queues
{
    private static Queue<int> Queue_1 = new Queue<int>();
    
    public static void enqueue(int nro)
    {
        Queue_1.Enqueue(nro);
    }

    public static void dequeue()
    {
        try
        {
            Console.WriteLine(Queue_1.Dequeue());
        }
        catch (System.InvalidOperationException e)
        {
            Console.WriteLine("No hay elementos que eliminar en la Queue", e);
        }
        
        //Console.WriteLine(Queue_1.Dequeue());
    }
    
    public static void first()
    {
        try
        {
            Console.WriteLine(Queue_1.Peek());
        }
        catch (System.InvalidOperationException e)
        {
            Console.WriteLine("No hay elementos en la Queue para mostrar", e);
        }
        //Console.WriteLine(Queue_1.Peek());
    }

    public static bool is_empty()
    {
        if (Queue_1.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int len()
    {
        return Queue_1.Count();
    }
}