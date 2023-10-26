namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado!!!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("A quantidade de hospedes não pode exceder a capacidade da suíte");
            }
        }


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado!!!
            return Hospedes.Count;
        }

        public int CalcularValorDiaria()
        {
            // Implementado!!!
            int valor = (int)(DiasReservados * Suite.ValorDiaria); // 300 reais

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // Implementado!!!
            if (DiasReservados >= 10)
            {
                double totalDesconto = valor * 0.1;
                valor -= (int)totalDesconto;
            }

            return (int)valor;
        }
    }
}