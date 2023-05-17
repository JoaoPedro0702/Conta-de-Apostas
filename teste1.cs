using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            ApostaEsportivas aposta = new ApostaEsportivas();

            System.Console.Write("Digite seu numero de Conta: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            System.Console.Write("Qual quantia deseja fazer o deposito?: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aposta.Deposito(quantia);

            System.Console.Write("Existe outra pessoa que voce divide esta conta?(s/n): ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')  {
                System.Console.WriteLine("Digite o nome da outra pessoa: ");
                string familiar = Console.ReadLine();
                aposta = new ApostaEsportivas(numero, nome, quantia, familiar);
            }
            else {
                aposta = new ApostaEsportivas(numero, nome, quantia);
            }

            System.Console.WriteLine("Dados da Conta: ");
            System.Console.WriteLine(aposta);

            System.Console.Write("Ganhou dinheiro com a aposta?(s/n): ");
            char resp2 = char.Parse(Console.ReadLine());
            if (resp2 == 's' || resp2 == 'S')  {
                System.Console.Write("Quanto ganhou?: ");
                double ganho = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aposta.GanhouAposta(ganho);
            }    
            else {
                System.Console.Write("Quanto perdeu?: ");
                double perda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aposta.PerdeuAposta(perda);
            }

            System.Console.WriteLine("Dados da Conta atualizados: ");
            System.Console.WriteLine(aposta);

            System.Console.WriteLine("Deseja realizar o saque?(s/n): ");
            char resp3 = char.Parse(Console.ReadLine());
            if (resp3 == 's' || resp3 == 'S')  {
                System.Console.Write("Quanto deseja sacar?: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aposta.Saque(saque);
                System.Console.Write(aposta);
            }
            else {
                System.Console.Write(aposta);
            }
        }
    }
}

            



