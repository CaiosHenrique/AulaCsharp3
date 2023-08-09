using System;
using Aula02RH.models;
using Aula02RH.models.Enuns;


namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args)
        {      
            funcionario func = new funcionario ();

            /*func.id = 10;
            func.Nome = "neymar";
            func.Cpf = "12345678910";
            func.DataAdmissao = DateTime.Parse("01/01/2000");
            func.Salario = 10000.00M;
            func.TipoFuncionario=models.Enuns.TipoFuncionarioEnum.Clt;
            string mensagem = func.ExibirPeriododeExperiencia();
            Console.WriteLine("================;========");
            Console.WriteLine(mensagem);
            Console.WriteLine("================;========");*/

            Console.WriteLine("digite o CPF:");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de funcionário (1 - CLT / 2 - Aprendiz: )");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.Clt : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("========================");
            Console.WriteLine($"O salario reajustado eh {func.Salario}.\n");
            Console.WriteLine($"O desconto do VT eh {valorDescontoVT}.\n");
            Console.WriteLine("========================");

    }
    }
}

// See https://aka.ms/new-console-template for more information

