using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace una_psc_alg_revisao_a1_ex04.Models
{
    public class SimuladorTributario
    {
        /// <summary>
        /// Calcula o valor do imposto de acordo com a alíquota original.
        /// </summary>
        /// <param name="valorFaturamento">Número positivo de faturamento à ser calculada a alíquota.</param>
        /// <param name="aliquotaBase">Taxa em valores inteiros menores ou iguais a 100 e não negativos.</param>
        /// <returns></returns>
        public static double CalcularImpostoAntigo(double valorFaturamento, int aliquotaBase)
        {
            if (valorFaturamento < 0)
                throw new Exception("Valor do faturamento não pode ser negativo.");
            if (aliquotaBase < 0 || aliquotaBase > 100)
                throw new Exception("Valor da alíquota inválido.");
            return valorFaturamento * aliquotaBase / 100;
        }
        /// <summary>
        /// Calcula o valor do imposto de acordo com a alíquota proposta.
        /// </summary>
        /// <param name="valorFaturamento">Número positivo de faturamento à ser calculada a alíquota.</param>
        /// <param name="aliquotaBase">Taxa em valores inteiros menores ou iguais a 100 e não negativos.</param>
        /// <returns></returns>
        public static double CalcularImpostoProposto(double valorFaturamento, int aliquotaProposta)
        {
            if (valorFaturamento < 0)
                throw new Exception("Valor do faturamento não pode ser negativo.");
            if (aliquotaProposta < 0 || aliquotaProposta > 100)
                throw new Exception("Valor da alíquota inválido.");
            return valorFaturamento * aliquotaProposta / 100;
        }
        /// <summary>
        /// Calcula o valor do imposto de acordo com a alíquota proposta.
        /// </summary>
        /// <param name="valorFaturamento">Número positivo de faturamento à ser calculada a alíquota.</param>
        /// <param name="aliquotaBase">Taxa em valores inteiros menores ou iguais a 100 e não negativos.</param>
        /// <returns></returns>
        public static double CalcularDiferenca(double impostoAntigo, int impostoNovo)
        {
            if (impostoAntigo < 0)
                throw new Exception("Valor do imposto antigo deve ser positivo.");
            if (impostoNovo < 0)
                throw new Exception("Valor do imposto novo deve ser positivo.");
            return Math.Abs(impostoAntigo - impostoNovo);
        }
        /// <summary>
        /// Escreve no console o status do diálogo entre as fintechs e o governo
        /// com base na informação de acesso ao governo.
        /// </summary>
        /// <param name="acessoAoGoverno">true se há acesso ao governo; false caso não haja.</param>
        public void StatusDialogo(bool acessoAoGoverno)
        {
            if (acessoAoGoverno == true)
            Console.WriteLine("STATUS: Diálogo aberto. Há espaço para negociação.");
            else if (acessoAoGoverno == false)
            Console.WriteLine("STATUS: Fintechs reclamam de falta de acesso ao governo. Risco de derrota política.");
            else
            throw new Exception("Nem eu sei como você chegou aqui, meu irmão.");
        }
    }
}