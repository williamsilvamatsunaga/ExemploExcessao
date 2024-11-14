using System;
using System.ComponentModel;

public class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Console.WriteLine("Digite um valor: ");
        //    int valor = int.Parse(Console.ReadLine());

        //    Console.WriteLine(valor / 0);
        //}

        //catch (DivideByZeroException) 
        //{
        //    Console.WriteLine("Erro ao tentar dividir por 0!");
        //}

        //catch (Exception ex)

        //{
        //    Console.WriteLine("Valor informado inválido!" + ex.Message);
        //}

        try
        {
            Excessao c = new Excessao();


            c.SeTSaldo(-60);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}
