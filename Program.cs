using static System.Console;
namespace ULTIMOTESTE_4
{
      class program
      {
            public static void Main (string []args)
            {
                  WriteLine("Informe o valor da compra: ");
                  int ValorCompra = int.Parse(ReadLine());

                  if (ValorCompra >=300 && ValorCompra <=2200)
                  {
                  int Porcento = ValorCompra - 200;
                  int Desconto = Porcento / 100;
                  int DescontoLiquido = (ValorCompra * Desconto)/100;
                  int Total = ValorCompra - DescontoLiquido;

                  WriteLine($"O valor da compra é: {ValorCompra}"+ $"\nPorcentagem de desconto adquirida:  {Desconto}%"+$"\nValor Final: {Total}");
                  }
                  else if (ValorCompra > 2200)
                  {
                        int Resultado = (ValorCompra * 20)/100;
                        Resultado = ValorCompra - Resultado;
                        WriteLine($"O valor da compra é: {ValorCompra}"+ $"\nPorcentagem de desconto adquirida:  20%"+$"\nValor Final: {Resultado}");
                  }
                  else if (ValorCompra <300)
                  {
                        WriteLine("Infelizmente você não adquiriu descontos :(");
                  }


            }     
      }
}