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
                        // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
                        // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
                        // *IMPLEMENTE AQUI*
                        // Validação para não adicionar placa vazia ou nula
            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Placa inválida. O veículo não foi estacionado.");
                return; // Encerra o método aqui
            }
            
                        // Validação para não adicionar placa repetida
            if (veiculos.Any(v => v.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"O veículo com a placa {placa} já está estacionado.");
                return;
            }

            veiculos.Add(placa);
            Console.WriteLine($"Veículo com a placa {placa} estacionado com sucesso!");
        }
        

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

                         // Pedir para o usuário digitar a placa e armazenar na variável placa
            
            string placa = Console.ReadLine();

                          // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                          // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                          // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal  

                          // *IMPLEMENTE AQUI*
                          // int horas = int.Parse(Console.ReadLine());
                          // decimal valorTotal = precoInicial + precoPorHora * horas;
                          // Correção no método RemoverVeiculo
                 int horas = 0;
                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                  Console.WriteLine("Valor inválido. Por favor, digite um número de horas válido (inteiro e não negativo).");
                }
                     decimal valorTotal = precoInicial + precoPorHora * horas;

                           // TODO: Remover a placa digitada da lista de veículos
                           // *IMPLEMENTE AQUI*

                           // Correção no método RemoverVeiculo
                           // Remove a primeira ocorrência da placa, ignorando maiúsculas/minúsculas.
                string placaParaRemover = veiculos.FirstOrDefault(v => v.ToUpper() == placa.ToUpper());
                if (placaParaRemover != null)
                {
                    veiculos.Remove(placaParaRemover);
                 }
                
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:C}");
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string veiculo in veiculos)
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
