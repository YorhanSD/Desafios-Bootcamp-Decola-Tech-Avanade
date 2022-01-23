class ImparPar
{
    public static void Main(string[] args)
    {
        int y = int.Parse(Console.ReadLine());

        if (y % 2 == 0) //Se for Par
        {
            y = y + 2;
            Console.WriteLine(y);
        }
        else //Se for Impar
        {
            y = y + 1;
            Console.WriteLine(y);
        }
    }

}
