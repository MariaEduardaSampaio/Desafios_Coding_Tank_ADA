using System.Globalization;

namespace GerenciadorVendas
{
    internal class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static int codigo = 1;

        static void Main(string[] args)
        {
            cadastrarProdutos();
            listarProdutos();
            float valorCompra = comprarProdutos();
            Console.WriteLine($"A compra de todos os produtos ficou no valor de {valorCompra.ToString("C", CultureInfo.CurrentCulture)}");
            Console.ReadKey();
        }

        public static void cadastrarProdutos()
        {
            Console.WriteLine("*****CADASTRO DE PRODUTOS*****");
            try
            {
                string op = "S";
                while (op.ToUpper() == "S")
                {
                    Produto produto = new Produto();

                    Console.WriteLine("Qual o nome do produto?");
                    produto.setNome(Console.ReadLine());
                    verificaNome(produto.Nome);

                    Console.WriteLine("Qual o valor do produto?");
                    produto.setValor(float.Parse(Console.ReadLine()));  
                    verificaValor(produto.Valor);

                    produto.setCodigo(codigo);
                    codigo++;

                    produtos.Add(produto);

                    Console.WriteLine("Quer adicionar mais algum produto? (S/N)"); 
                    op = Console.ReadLine().ToUpper();
                    verificaOpcao(op);

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public static float comprarProdutos()
        {
            try
            {
                float valorCompra = 0.0f;
                string opCompra = "S";

                Console.WriteLine("*****COMPRA DE PRODUTOS*****");
                while (opCompra.ToUpper() == "S")
                {

                    Console.WriteLine("Digite o código do produto que você deseja: ");
                    int codigoProdutoDesejado = int.Parse(Console.ReadLine());
                    verificaCodigoProduto(codigoProdutoDesejado);

                    Produto produtoDesejado = produtos.FirstOrDefault(x => x.Codigo == codigoProdutoDesejado);

                    if (produtoDesejado == null)
                    {
                        throw new Exception("Código de produto não encontrado.");
                    }

                    Console.WriteLine("Qual a quantidade desejada para este produto?\n");
                    int quantidadeDesejada = int.Parse(Console.ReadLine());
                    verificaQuantidade(quantidadeDesejada);

                    float compraProduto = quantidadeDesejada * produtoDesejado.Valor;
                    valorCompra += compraProduto;

                    Console.WriteLine($"\nCompra do produto {produtoDesejado.Nome} " +
                                      $"de valor unitário {produtoDesejado.Valor.ToString("C", CultureInfo.CurrentCulture)} " +
                                      $"deu no total {compraProduto.ToString("C", CultureInfo.CurrentCulture)}");

                    Console.WriteLine("Deseja continuar comprando? (S/N) \n");
                    opCompra = Console.ReadLine().ToUpper();
                    verificaOpcao(opCompra);
                }
                return valorCompra;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void listarProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Código: {produto.Codigo}\n" +
                                  $"Nome: {produto.Nome}\n" +
                                  $"Valor: {produto.Valor.ToString("C", CultureInfo.CurrentCulture)}\n\n"); //adicionar culture.info
            }
        }

        public static void verificaValor(float ? valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de produto não pode ser negativo ou 0.");
            if (valor == null)
                throw new ArgumentNullException("Valor de produto não pode ser nulo.");
        }

        public static void verificaQuantidade(int ? quantidade)
        {
            if (quantidade <= 0)
                throw new ArgumentException("Quantidade de produto não pode ser negativo ou 0.");
            if (quantidade == null)
                throw new ArgumentNullException("Quantidade de produto não pode ser nulo.");
        }

        public static void verificaCodigoProduto(int ? codigoProduto)
        {
            if (codigoProduto <= 0)
            {
                throw new ArgumentException("Código de produto não pode ser negativo ou 0.");
            }
            else if (codigoProduto > codigo)
            {
                throw new ArgumentException("Não há um produto com este código.");
            }
            else if (codigoProduto == null)
            {
                throw new ArgumentNullException("Código de produto não pode ser nulo.");
            }
        }

        public static void verificaOpcao(string opcao)
        {
            if (opcao != "S" && opcao != "N")
            {
                throw new ArgumentException("Opção inválida. Apenas é permitido S/s ou N/n.");
            }
        }

        public static void verificaNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("Nome não pode ser nulo.");
            }
        }
    }
}