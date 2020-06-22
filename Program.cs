using System;
using System.Collections.Generic;
namespace List_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nFuncionário #{i + 1}");

                Console.Write("Digite o Id: ");
                int id = int.Parse(Console.ReadLine());
                                                                      
                Console.Write("Digite o Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Salario: ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(id, nome, salario));

            }



            Console.Write("\nId do funcionário que receberá o aumento: ");
            int idfunc = int.Parse(Console.ReadLine());
            Funcionario func = list.Find(z => z.Id == idfunc);
           
            if (func != null)
            {
                Console.Write("Porcentagem de aumento: ");
                double percent = double.Parse(Console.ReadLine());
                func.Aumento(percent);
            }

            else
            {
                Console.WriteLine("Funcionário não existe");
            }


            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
