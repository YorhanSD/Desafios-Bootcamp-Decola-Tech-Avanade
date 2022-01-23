class ValorDeS
{
    public static void Main(string[] args)
    {
        double s = 0, resultado;
        double divisor = 1;

        for (double i = 1; 100 >= divisor; divisor++)
        {
            resultado = i / divisor;
            s = s + resultado;
        }
        var x = Math.Round(s, 2);

        Console.WriteLine($"o s vale: {x}");//Resultado esperado 5,19
    }
}
