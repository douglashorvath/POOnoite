using System;
using System.Collections.Generic;

namespace TrabalhoVendaFinal
{
    public class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static List<Venda> vendas = new List<Venda>();
        static List<Pagamento> pagamentos = new List<Pagamento>();



        static void Main()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Registrar Venda");
                Console.WriteLine("4. Listar Vendas");
                Console.WriteLine("5. Listar Pagamentos");
                Console.WriteLine("6. Sair");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AdicionarProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        RegistrarVenda();
                        break;
                    case "4":
                        ListarVendas();
                        break;
                    case "5":
                        ListarPagamentos();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarProduto()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Adicionar Produto");
            Console.Write("Código: ");
            long codigo = long.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            produtos.Add(new Produto(codigo, nome, preco, estoque));
            Console.WriteLine("Produto adicionado com sucesso!");
            Console.WriteLine("--------------------------------------------------");
        }

        static void ListarProdutos()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Produtos:");
            foreach (var produto in produtos)
            {
                produto.exibirProduto();
            }
            Console.WriteLine("--------------------------------------------------");
        }

        static void RegistrarVenda()
        {
            Venda venda = new Venda(DateTime.Now);
            while (true)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Digite o código do produto (ou 0 para finalizar a venda): ");
                long codigo = long.Parse(Console.ReadLine());
                if (codigo == 0) break;

                Produto produto = produtos.Find(p => p.Codigo == codigo);
                if (produto == null)
                {
                    Console.WriteLine("Produto não encontrado. Tente novamente.");
                    continue;
                }

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade > produto.Estoque)
                {
                    Console.WriteLine("Quantidade em estoque insuficiente. Tente novamente.");
                    continue;
                }

                ItemVenda item = new ItemVenda(produto, quantidade);
                venda.AdicionarItem(item);
                produto.removeEstoque(quantidade);

                Console.WriteLine("Item adicionado à venda.");
            }

            if (venda.ItensVenda.Count > 0)
            {
                vendas.Add(venda);
                Console.WriteLine($"Venda registrada com sucesso! Total a Pagar: {venda.Total}");

                Console.WriteLine("Escolha o método de pagamento:");
                Console.WriteLine("1. Espécie");
                Console.WriteLine("2. Cartão");
                Console.WriteLine("3. Cheque");
                string opcaoPagamento = Console.ReadLine();

                Pagamento pagamento = null;
                switch (opcaoPagamento)
                {
                    case "1":
                        Console.Write("Quantia recebida: ");
                        double quantia = 0;
                        while (quantia < venda.Total)
                        {
                            quantia = double.Parse(Console.ReadLine());
                            if (quantia < venda.Total)
                            {
                                Console.WriteLine("Quantia insuficiente. Tente novamente.");
                                Console.Write("Quantia recebida: ");
                            }
                        }
                        pagamento = new Especie(quantia, venda);
                        pagamentos.Add(pagamento);
                        break;
                    case "2":
                        Console.Write("Dados da Transação: ");
                        string dadosTransacao = Console.ReadLine();
                        Console.Write("Resultado da Transação: ");
                        int resultadoTransacao = int.Parse(Console.ReadLine());
                        pagamento = new Cartao(dadosTransacao, resultadoTransacao, venda);
                        pagamentos.Add(pagamento);
                        break;
                    case "3":
                        Console.Write("Número do Cheque: ");
                        long numeroCheque = long.Parse(Console.ReadLine());
                        bool validaData = false;
                        DateTime dataDeposito = DateTime.Now;
                        while (!validaData)
                        {
                            try
                            {
                                Console.Write("Data de Depósito (dd/MM/yyyy): ");
                                dataDeposito = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                                validaData = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Data inválida. Tente novamente.");
                            }
                        }

                        Console.Write("Situação: ");
                        int situacao = int.Parse(Console.ReadLine());
                        pagamento = new Cheque(numeroCheque, dataDeposito, situacao, venda);
                        pagamentos.Add(pagamento);
                        break;
                    default:
                        Console.WriteLine("Opção de pagamento inválida.");
                        break;
                }

                if (pagamento != null)
                {
                    Console.WriteLine($"Pagamento registrado com sucesso! Total pago: {pagamento.Total}");
                }
                Console.WriteLine("--------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Nenhum item foi adicionado à venda.");
                Console.WriteLine("--------------------------------------------------");
            }
        }

        static void ListarVendas()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Vendas:");
            foreach (Venda venda in vendas)
            {
                venda.exibirVenda();
                Console.WriteLine("--------------------------------------------------");
            }
        }

        static void ListarPagamentos()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Pagamentos:");
            foreach (Pagamento pagto in pagamentos)
            {
                pagto.exibirPagamento();
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
