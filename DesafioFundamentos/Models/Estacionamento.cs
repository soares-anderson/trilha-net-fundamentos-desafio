namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        decimal ValorPago;
        string formaDePagamento;
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
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine().ToUpper());

        }

        public void RemoverVeiculo()
        {
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover:");

           
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0;


                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt16(Console.ReadLine());
                
                
                valorTotal = (precoInicial + precoPorHora * horas);

                

                //Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.WriteLine($"O veículo {placa.ToUpper()} preço total foi de: R$ {valorTotal}");
                Console.WriteLine("Valor o cliente deu: ");
                ValorPago = Convert.ToDecimal(Console.ReadLine());
                
                Console.WriteLine("Forma de Pagamento:\nCC-Crédito\nCD-Débito\nD-Dinheiro ");
                formaDePagamento = Console.ReadLine().ToUpper();


                

                    switch (formaDePagamento.ToUpper())
                    {
                        case "CC":
                            if (ValorPago > valorTotal)
                            {
                                System.Console.WriteLine("Por favor, confirme novamente o valor a ser pago");
                                System.Console.WriteLine("Erro");
                                return;
                            }
                            else
                            {

                                System.Console.WriteLine($"O veículo {placa.ToUpper()} foi removido");
                                veiculos.Remove(placa.ToUpper());
                                
                            }

                            break;
                        case "D":
                            if (ValorPago > valorTotal)
                            {
                                System.Console.WriteLine($"O Cliente tem troco: {ValorPago - valorTotal}");
                                System.Console.WriteLine($"O veículo {placa.ToUpper()} foi removido");
                                veiculos.Remove(placa.ToUpper());

                            }
                            else
                            {

                                System.Console.WriteLine($"O veículo {placa.ToUpper()} foi removido\nCliente não tem troco");
                                veiculos.Remove(placa.ToUpper());
                                
                            }

                            break;
                        case "CD":
                            if (ValorPago > valorTotal)
                            {
                                System.Console.WriteLine("Por favor, confirme novamente o valor a ser pago");
                                System.Console.WriteLine("Erro!\n Tente novamente");
                                return;
                            }
                            else
                            {

                                System.Console.WriteLine($"O veículo {placa.ToUpper()} foi removido");
                                veiculos.Remove(placa.ToUpper());
                                
                            }

                            break;
                        default:
                            Console.WriteLine("Digite uma forma de Pagamento Válida");
                            System.Console.WriteLine("Erro!\n Tente novamente");
                            break;
                    }
  






            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n\n");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
                foreach(string v in veiculos){
                    System.Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.\n\n");
            }
        }
    }
}
