using System.Collections.Generic;

namespace ControleFuncionario
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            int codigo;

            Console.Write("How many employees will be registred?");
            int quantity = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < quantity)
            {

                Console.Write("Código do Funcionário: ");
                codigo = int.Parse(Console.ReadLine());

                Funcionario l = list.Find(x => x.Id.Equals(codigo));

                if (l != null)
                {
                    Console.WriteLine("Código de funcionário repetido");

                }
                else
                {

                    Console.Write("Nome do Funcionário: ");
                    string name = Console.ReadLine() ?? "Name not informed";

                    Console.Write("Salário do Funcionário: ");
                    double salary = double.Parse(Console.ReadLine());

                    Funcionario f = new Funcionario(codigo, name, salary);

                    list.Add(f);

                    i++;
                }
            }

            ImprimirLista(list);

            Console.WriteLine("Digite o código do funciário que receberá o aumento: ");
            codigo = int.Parse(Console.ReadLine());

            Funcionario funcionario = list.Find(x => x.Id.Equals(codigo));
            if (funcionario != null)
            {
                Console.WriteLine("Aumento de salário para " + funcionario.Name);
                Console.WriteLine("Digite a porcentagem de aumento: ");
                funcionario.IncreaseSalary(double.Parse(Console.ReadLine()));

            }
            else
            {
                Console.WriteLine("Funcionário inexistente!");
            }
            ImprimirLista(list);

        }

        public static void ImprimirLista(List<Funcionario> lista)
        {
            foreach (Funcionario l in lista) { Console.WriteLine(l); }
        }
    }
}