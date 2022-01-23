class VaiTerCopa
{
    public static void Main(string[] args)
    {
        string str;
        int c = 1;

        while ((str = Console.ReadLine()) != null)
        {
            if (str == null)//Se o valor for 0
            {
                Console.WriteLine("vai ter copa!");
            }
            else
            {
                c = int.Parse(str);

                if (c >= 1)//Se o valor for diferente de 0
                {
                    Console.WriteLine("vai ter duas!");
                }
                else
                {
                    Console.WriteLine("vai ter copa!");
                }
            }

        }
        
    }

}