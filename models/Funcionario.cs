using Aula02RH.models.Enuns;
namespace Aula02RH.models
{
    public class funcionario
    {//prop tab para criar propriedades
        public int id { get; set; }
        public string Cpf { get; set; } = "";
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public string Nome { get; set; } = "";  
        public TipoFuncionarioEnum TipoFuncionario { get; set; } 

        public void ReajustarSalario()
        {
            Salario= Salario + (Salario * 10/100);
        }     
        public string ExibirPeriododeExperiencia()
        {
            string PeriodoExperiencia=
            string.Format("Períodos de Experiencia: {0} até {1}",DataAdmissao, DataAdmissao.AddMonths(3));
            return PeriodoExperiencia;
        }
        public decimal CalcularDescontoVT(decimal percentual)
        {
            decimal desconto = this.Salario * percentual/100;
            return desconto;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }
        public bool ValidarCpf()
        {if(ContarCaracteres(Cpf) == 11)
            return true;
        else
            return false;
        }













    }
}