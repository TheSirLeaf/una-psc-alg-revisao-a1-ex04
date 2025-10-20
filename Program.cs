using una_psc_alg_revisao_a1_ex04.Models;
using static una_psc_alg_revisao_a1_ex04.Models.SimuladorTributario;

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        var culturaBr = new CultureInfo("pt-BR");

        double faturamento = 50_000_000.00;

        Console.WriteLine("(Para Faturamento de {0})\n", faturamento.ToString("C", culturaBr));
        Console.WriteLine("=== Análise de Tributação de Fintechs ===\n");
        Console.WriteLine("Faturamento Base: {0}\n", faturamento.ToString("C", culturaBr));

        // Proposta A: 9% -> 15% (usando SimuladorTributario)
        var sistema = new SimuladorTributario();
        double impostoAntigoA = CalcularImpostoAntigo(faturamento, 9);
        double impostoPropostoA = CalcularImpostoProposto(faturamento, 15);
        double aumentoA = CalcularDiferenca(impostoAntigoA, Convert.ToInt32(impostoPropostoA));

        Console.WriteLine("-- Proposta A (9% -> 15%) --");
        Console.WriteLine("Imposto Antigo (9%): {0}", impostoAntigoA.ToString("C", culturaBr));
        Console.WriteLine("Imposto Proposto (15%): {0}", impostoPropostoA.ToString("C", culturaBr));
        Console.WriteLine("Aumento de Imposto: {0}\n", aumentoA.ToString("C", culturaBr));

        // Proposta B: 15% -> 20% (usando SistemaTributario)
        double impostoAntigoB = CalcularImpostoAntigo(faturamento, 15);
        double impostoPropostoB = CalcularImpostoProposto(faturamento, 20);
        double aumentoB = CalcularDiferenca(impostoAntigoB, Convert.ToInt32(impostoPropostoB));

        Console.WriteLine("-- Proposta B (15% -> 20%) --");
        Console.WriteLine("Imposto Antigo (15%): {0}", impostoAntigoB.ToString("C", culturaBr));
        Console.WriteLine("Imposto Proposto (20%): {0}", impostoPropostoB.ToString("C", culturaBr));
        Console.WriteLine("Aumento de Imposto: {0}\n", aumentoB.ToString("C", culturaBr));

        Console.WriteLine("-- Análise de Diálogo --");

        var simulador = new SimuladorTributario();
        simulador.StatusDialogo(true);
        simulador.StatusDialogo(false);
    }
}