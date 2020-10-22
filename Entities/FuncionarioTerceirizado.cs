namespace ExercicioHeranca.Entities
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHora, double despesaAdicional) : base(nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}