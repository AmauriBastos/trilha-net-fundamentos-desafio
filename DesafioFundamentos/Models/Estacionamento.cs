namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // *IMPLEMENTADO !!!*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Esse veículo já está estacionado.");
            }
            else
            {
                veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {
            if (!veiculos.Any())
            {
                Console.WriteLine("Não há veículos estacionados para remover.");
                return;
            }

            Console.WriteLine("Digite a placa do veículo para remover:");

            // *IMPLEMENTADO !!!*
            string placa = Console.ReadLine();
            int horas = 0;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int.TryParse(Console.ReadLine(), out horas);

                if (horas < 0)
                {
                    Console.WriteLine("A quantidade de horas não pode ser negativa.");
                    return;
                }

                // *IMPLEMENTADO !!!*
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                // *IMPLEMENTADO !!!
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // *IMPLEMENTADO !!!*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
