using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_logica_programacao1
{
    public class Service
    {
        public int Meses { get; set; }
        public int Dias = 30;

        public void CalcularDias()
        {
            Console.WriteLine("Digite o numero de meses: ");
            Meses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O total de dias dentro de {Meses} meses é: {Meses * Dias}")
;       }
    }
}
