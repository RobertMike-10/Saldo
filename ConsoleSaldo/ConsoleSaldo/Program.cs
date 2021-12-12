using System;

namespace ConsoleSaldo
{
    class Program
    {

        static int[] movimientos = { 1500, -800, 200, 500, -1200,0,0,0,750,-450, -200,0,0,0,2000,3000,
                                      0,0,0,0,-3500,-250,0,320,-400,0,100,-200,0,-1370};
        static void Main(string[] args)
        {
            int saldoInicial = 5000;

            int dia = 7;
            Console.WriteLine($"Saldo día {dia}");
            Console.WriteLine(CalcularSaldoPeriodo(saldoInicial, dia));
            dia = 15;
            Console.WriteLine($"Saldo día {dia}");
            Console.WriteLine(CalcularSaldoPeriodo(saldoInicial, dia));
            dia = 22;
            Console.WriteLine($"Saldo día {dia}");
            Console.WriteLine(CalcularSaldoPeriodo(saldoInicial, dia));
            dia = 30;
            Console.WriteLine($"Saldo día {dia}");
            Console.WriteLine(CalcularSaldoPeriodo(saldoInicial, dia));

            Console.WriteLine($"Saldo Promedio");
            Console.WriteLine(CalcularPromedioDiario(saldoInicial, dia));

        }

        static int CalcularSaldoPeriodo(int saldoAnterior, int dia)
        {
            int saldoDiario = saldoAnterior;
            for (int i = 1; i <= dia; i++)
            {
                saldoDiario = CalcularSaldoDario(saldoDiario, i);
            }
            return saldoDiario;
        }

        static int CalcularSaldoDario(int saldoDiaAnterior, int dia)
        {
            int saldoDiario = saldoDiaAnterior;
            int movimiento = movimientos[dia-1];
            saldoDiario = saldoDiario + movimiento;
            
            return saldoDiario;

        }

        static Decimal CalcularPromedioDiario(int saldoInicial, int finPeriodo)
        {
            int saldoDiario = saldoInicial;
            decimal saldoPromDiario = 0.0M;            
            for (int i=1; i<= finPeriodo;i++)
            {
                saldoDiario = CalcularSaldoDario(saldoDiario, i);
                saldoPromDiario += saldoDiario;
            }
            saldoPromDiario = saldoPromDiario / finPeriodo;
            return saldoPromDiario;

        }
    }
}
