Console.WriteLine($"El factorial de 5 es: {Functions.FactorialFor(5)}");
Console.WriteLine($"El factorial de 5 es: {Functions.FactorialWhile(5)}");

// Implementa en esta clase la función que corresponda

public static class Functions
{
    public static int FactorialFor(int number)
    {
        int aux = 1;
        for (int i = 1; i <= number; i++)
        {
            aux = i * aux;
        }
        return aux;
    }

    public static int FactorialWhile(int number)
    {
        int i = 1;
        int aux = 1;
        while (i <= number)
        {
            aux = i * aux;
            i++;
        }
        return aux;
    }
}

