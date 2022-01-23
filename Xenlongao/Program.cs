class Xenlongao
{
    public static void Main(string[] args)
    {
        int resultado = 0;
        int checagens = int.Parse(Console.ReadLine());//Entrada esperada: 1

        for (int i = 0; i < checagens; i++)
        {
            //Kogu precisa reunir 5 esferas que não sejam quadrados perfeitos para invocar xenlongão
            //Pra isso é necessário um programa para verificar quais são essas esferas
            //Já que Kogu não é bom com Matemática

            int esferas = int.Parse(Console.ReadLine());//Entrada espera: 7

            for (int y = 1; y <= esferas; esferas--)
            {
                float raiz = (float)Math.Sqrt(esferas);

                Console.WriteLine($"Esfera Numero: {esferas} Raiz quadrada igual a: {raiz}");

                if (raiz % 2 != 0)resultado++;
                if (raiz % 2 == 0)resultado--;
                
            }
        }
        Console.WriteLine(resultado);//Saida esperada: 5
    }
}
