using System.Globalization;

namespace Course {
    
        class ApostaEsportivas {

                public int Numero { get; private set; }

                public string Nome { get; set; }

                public double Saldo {get; private set; }

                public string Familiar {get; private set; }

                public ApostaEsportivas() {

                }

                public ApostaEsportivas(int numero, string nome, double saldo) {
                        Numero = numero;
                        Nome = nome;
                        Saldo = saldo;
                }

                public ApostaEsportivas(int numero, string nome, double saldo, string familiar) : this(numero, nome, saldo) {
                       Familiar = familiar;
                }

                public void Deposito(double quantia) {
                        Saldo += quantia;
                }

                public void GanhouAposta(double ganho) {
                        Saldo += ganho;
                }

                public void PerdeuAposta(double perda) {
                        Saldo -= perda;
                }

                public void Saque(double quantia) {
                        Saldo -= quantia;
                }

                public override string ToString() {
                        return "Conta: " 
                               + Numero 
                               + " , Titular: " 
                               + Nome 
                               + " , Familiar Conjunto: " 
                               + Familiar 
                               + ", Saldo: " 
                               + Saldo.ToString("F2", CultureInfo.InvariantCulture);
                }



        }
}

    

    