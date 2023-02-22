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
        Console.WriteLine(e);
    }
    
    // Metodo para remover un elemento
    public static void Pop()
    {
        // Remover un elemento
        stack_1.Pop();
        
        List<int> stack = stack_1.ToList();
        Console.WriteLine("2 El Stack quedo de la siguiente forma:");
        stack.ForEach(Console.WriteLine);
        
    }
}