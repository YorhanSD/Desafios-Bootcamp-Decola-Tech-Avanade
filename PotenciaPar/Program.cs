class PotenciaPar
{
    public static void Main(string[] args)
    {
        double x = 2;
        double resultado;
        double n = double.Parse(Console.ReadLine());

        for (int i = 2; x <= n; x = x + 2)
        {
            resultado = Math.Pow(x, i);
            Console.WriteLine($"{x}^{i} = {resultado}");
        }
    }
}
