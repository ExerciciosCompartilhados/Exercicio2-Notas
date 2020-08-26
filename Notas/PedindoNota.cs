using System;

namespace Exercicio2___Notas.Notas
{
    public class PedindoNota
    {
        public decimal Nota { get; set; }

        public PedindoNota(decimal nota)
        {
            Nota = nota;
            Validar();
        }

        private void Validar()
        {
            if(Nota < 0 || Nota > 10)
            {
                Nota = 0;    
            }
            
        }
    }
}