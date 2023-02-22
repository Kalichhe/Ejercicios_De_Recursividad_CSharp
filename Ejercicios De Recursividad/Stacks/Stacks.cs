namespace Ejercicios_De_Recursividad;

public class Stacks
{
    // Esto es una variable global
    public static Stack<int> stack_1 = new Stack<int>();
    
    // Metodo para agragar elementos
    public static void Push(int e)
    {
        // Agregar elementos a la Stack
        stack_1.Push(e);
    }
    
    // Metodo para remover un elemento
    public static void Pop()
    {
        // Remover un elemento
        try
        {
            Console.WriteLine("El elemento removido es: " + stack_1.Pop());
        }
        catch (System.InvalidOperationException e)
        {
            Console.WriteLine("El Stack esta vacio, por lo tanto no se puede retornar nada",e);
        }
    }
    
    // Metodo para ver el ultimo elemento agregado 
    public static void Top()
    {
        // Devuelve el ultimo elemento agregado
        try
        {
            Console.WriteLine("El elemento que se encuentra en el top es: " + stack_1.Peek());
        }
        catch (System.InvalidOperationException e)
        {
            Console.WriteLine("No hay elementos en el Stack por mostrar", e);
        }
    }
    
    // Metodo para validar si hay elementos en el Stack
    public static bool is_empty()
    {
        // Devuelve un booleano
        if (stack_1.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    // Metodo para saber el tamaño del Stack
    public static int len()
    {
        // Devuelve el tamaño
        return stack_1.Count;
    }
}