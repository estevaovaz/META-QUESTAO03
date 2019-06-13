using System;


namespace META_QUESTAO03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region META QUESTAO03
            int num1, num2, num3, num4, lucro, precoCompra, precoVenda;
            Console.WriteLine("Entre com 4 numeros para um array: " + "Ex = 2 5 6 7");
            string[] linha = Console.ReadLine().Split(' ');
            num1 = int.Parse(linha[0]);
            num2 = int.Parse(linha[1]);
            num3 = int.Parse(linha[2]);
            num4 = int.Parse(linha[3]);
         
            Console.WriteLine("Dia 1: " + num1);
            Console.WriteLine("Dia 2: " + num2);
            Console.WriteLine("Dia 3: " + num3);
            Console.WriteLine("Dia 4: " + num4);
      
            Console.Write("Escolha um dia para comprar uma ação: ");
            int diaCompra = int.Parse(Console.ReadLine());

            Console.Write("Escolha um dia para vender uma ação: ");
            int diaVenda = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num1 == 0 && num2 == 0 && num3 == 0 && num4 == 0)
            {
                Console.WriteLine("Nesse caso nenhuma transação deve ser feita, lucro máximo igual a 0");
            }
            else if(diaCompra == num1 || diaCompra == num2 || diaCompra == num3 || diaCompra == num4)
            {
                if(diaVenda == num1 || diaVenda == num2 || diaVenda == num3 || diaVenda == num4)
                {
                    precoCompra = diaCompra;
                    precoVenda = diaVenda;
                    lucro = precoVenda - precoCompra;
                    Console.WriteLine(lucro);
                }            

            }

 
            #endregion
        }
    }
}
