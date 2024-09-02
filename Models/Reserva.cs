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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count){
            if (true)
            {
                Hospedes = hospedes;
            }
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                Exception exception = new Exception();
                Console.WriteLine($"A capacidade da suíte não suporta a quantidade de hospedes {exception.Message}");
                }
        }

        public void CadastrarSuite(Suite suite)
        {
            if(suite != null){
            Suite = suite;
            }else{
                Console.WriteLine("Não foi possível adicionar uma Suíte.");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            var i=0;
            foreach(Pessoa hospedes in Hospedes){
                i++;
            }
            return i;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10){
                if (true)
                {
                    valor = valor * (1-(10m/100)) ;
                }
            }
            return valor;
        }
    }
}