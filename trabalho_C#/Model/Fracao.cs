using System.Numerics;

namespace Trabalho.Model
{
    public class Fracao
    {
        public int Numerador
        {
            get; set;
        }

        public int Denominador
        {
            get; set;
        }
        public Fracao(int numerador, int denominador)
        {
            ArgumentOutOfRangeException.ThrowIfZero(denominador, nameof(denominador));
            Denominador = denominador;
            Numerador = numerador;
            if (denominador > numerador)
            {
                for (int i = numerador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = denominador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
        }
        public Fracao(int numerador)
        {
            Numerador = numerador;
            Denominador = 1;
        }
        public Fracao(String str)
        {
            string[] numeros = str.Split('/');
            int numerador = int.Parse(numeros[0]);
            int denominador = int.Parse(numeros[1]);
            ArgumentOutOfRangeException.ThrowIfZero(denominador, nameof(denominador));
            Denominador = denominador;
            Numerador = numerador;
            if (denominador > numerador)
            {
                for (int i = numerador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = denominador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
        }

        public Fracao(double num)
        {
            String texto = num.ToString();
            string[] numeros = texto.Split('.');
            int digitos = numeros[0].Length;
            int exponent = (int)Math.Pow(10, digitos);
            int numerador = (int)(num * exponent);
            int denominador = exponent;
            if (denominador > numerador)
            {
                for (int i = numerador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        ArgumentOutOfRangeException.ThrowIfZero(denominador, nameof(denominador));
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = denominador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        ArgumentOutOfRangeException.ThrowIfZero(denominador, nameof(denominador));
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
        }

        public Fracao Somar(int inteiro)
        {
            int numerador = this.Numerador;
            int denominador = this.Denominador;
            int novoDenominador = denominador * 1;
            int novoNumerador = (novoDenominador / denominador) * numerador + (novoDenominador / 1) * inteiro;
            Console.WriteLine($"Current fraction: {novoNumerador}/{novoDenominador}");
            return new Fracao(novoNumerador, novoDenominador);
        }

        public static Fracao operator +(Fracao a, Fracao b)
        {
            int novoNumerador = a.Numerador * b.Denominador + b.Numerador * a.Denominador;
            int novoDenominador = a.Denominador * b.Denominador;
            return new Fracao(novoNumerador, novoDenominador);
        }

        public static Fracao operator +(Fracao a, int b)
        {
            Fracao outra = new Fracao(b, 1);
            return a + outra;
        }

        public static Fracao operator +(int a, Fracao b)
        {
            Fracao outra = new Fracao(a, 1);
            return outra + b;
        }

        public static Fracao operator +(double num, Fracao fracao)
        {
            String texto = num.ToString();
            string[] numeros = texto.Split('.');
            int digitos = numeros[0].Length;
            int exponent = (int)Math.Pow(10, digitos);
            int numerador = (int)(num * exponent);
            int denominador = exponent;
            int Denominador = denominador;
            int Numerador = numerador;
            if (denominador > numerador)
            {
                for (int i = numerador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = denominador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            Fracao outra = new Fracao(Numerador, Denominador);
            return outra + fracao;
        }

        public static Fracao operator +(Fracao fracao, double num)
        {
            String texto = num.ToString();
            string[] numeros = texto.Split('.');
            int digitos = numeros[0].Length;
            int exponent = (int)Math.Pow(10, digitos);
            int numerador = (int)(num * exponent);
            int denominador = exponent;
            int Denominador = denominador;
            int Numerador = numerador;
            if (denominador > numerador)
            {
                for (int i = numerador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = denominador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            Fracao outra = new Fracao(Numerador, Denominador);
            return outra + fracao;
        }

        public static Fracao operator +(Fracao fracao, String str)
        {
            string[] numeros = str.Split('/');
            int numerador = int.Parse(numeros[0]);
            int denominador = int.Parse(numeros[1]);
            int Denominador = denominador;
            int Numerador = numerador;
            if (denominador > numerador)
            {
                for (int i = numerador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = denominador; i > 1; i--)
                {
                    if (denominador % i == 0 && numerador % i == 0)
                    {
                        Denominador = denominador / i;
                        Numerador = numerador / i;
                        denominador = Denominador;
                        numerador = Numerador;
                        i++;
                    }
                }
            }
            Fracao outra = new Fracao(Numerador, Denominador);
            return outra + fracao;
        }

        public static bool operator ==(Fracao a, Fracao b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Numerador * b.Denominador == b.Numerador * a.Denominador;
        }

        public static bool operator !=(Fracao a, Fracao b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (obj is Fracao other)
                return Numerador * other.Denominador == other.Numerador * Denominador;
            return false;
        }
        public override int GetHashCode()
        {
            return Numerador.GetHashCode() ^ Denominador.GetHashCode();
        }

        public static bool operator <(Fracao a, Fracao b)
        {
            if (a is null || b is null) throw new ArgumentNullException();
            return a.Numerador * b.Denominador < b.Numerador * a.Denominador;
        }

        public static bool operator >(Fracao a, Fracao b)
        {
            if (a is null || b is null) throw new ArgumentNullException();
            return a.Numerador * b.Denominador > b.Numerador * a.Denominador;
        }

        public static bool operator <=(Fracao a, Fracao b)
        {
            if (a is null || b is null) throw new ArgumentNullException();
            return a.Numerador * b.Denominador <= b.Numerador * a.Denominador;
        }

        public static bool operator >=(Fracao a, Fracao b)
        {
            if (a is null || b is null) throw new ArgumentNullException();
            return a.Numerador * b.Denominador >= b.Numerador * a.Denominador;
        }
        public bool IsUnitaria => Numerador == 1 && Denominador != 0;

        public bool IsAparente => Numerador % Denominador == 0 && Denominador != 0;

        public bool IsPropria => Math.Abs(Numerador) < Math.Abs(Denominador);

        public bool IsImpropria => Math.Abs(Numerador) > Math.Abs(Denominador);
        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }
}
