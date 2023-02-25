using Ejercicios_De_Recursividad;
using Ejercicios_De_Recursividad.Queues;

// Escriba una función recursiva que imprima los números desde un número n hasta otro número m descendentemente
//Console.WriteLine(Ejercicios.Imprimir(9));

// Escriba una función recursiva que reciba un número y retorne la cantidad de dígitos de este número
//Console.WriteLine(Ejercicios.Cantidad(1234567890));

// Escriba una función recursiva que sume los dígitos de un número dado
//Console.WriteLine(Ejercicios.Suma_Digitos(123456789));

// Escriba una función recursiva que invierta un string dado
//Console.WriteLine(Ejercicios.Invertir("carlos"));

// Fibonacci
//Console.WriteLine(Ejercicios.Fibonacci(10));

// Busqueda Binaria
//List<int> numeros = new List<int>() {1,2,3,4,5,6,7,8,9};
//Console.WriteLine(Ejercicios.Busqueda_Binaria(numeros,2));

// Listas con MAYUSCULAS y minusculas
//List<string> lista = new List<string>() {"CarloS", "marIo"};
//string lista = "Carlos";
//List<string> mayusculas = new List<string>() { };
//List<string> minusculas = new List<string>() { };
//int index = 0;
//Console.WriteLine(Ejercicios.MAYUS_minus(lista,mayusculas,minusculas,index));

// Stack

//Stacks.Push(1);
//Stacks.Push(2);
//Stacks.Push(3);
//Stacks.Push(4);
//Stacks.Push(5);
//Stacks.Push(6);
//Stacks.Push(7);
//
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//Stacks.Pop();
//
//Stacks.Top();
//
//Console.WriteLine(Stacks.is_empty());
//
//Console.WriteLine(Stacks.len());


// Queue

Queues.enqueue(1);
Queues.enqueue(2);
Queues.enqueue(3);
Queues.enqueue(4);
Queues.enqueue(5);
Queues.enqueue(6);
Queues.enqueue(7);
Queues.enqueue(8);
Queues.enqueue(9);
Queues.enqueue(0);

Queues.dequeue();

Console.WriteLine(Queues.is_empty());

Console.WriteLine(Queues.len());