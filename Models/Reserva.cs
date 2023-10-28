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

        public void CadastrarHospedes(List<Pessoa> hospedes) // Implementei aqui
        {
                      
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte não é suficiente para acomodar todos os hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() // Implementei aqui
        {
                        
            int quantidade =  Hospedes.Count;
            return quantidade;

        }

        public decimal CalcularValorDiaria() // Implementei aqui
        {
            
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10 ){

                decimal desconto = valor * 0.10M;
                valor -= desconto;
            }

            return valor;
        }
    }
}