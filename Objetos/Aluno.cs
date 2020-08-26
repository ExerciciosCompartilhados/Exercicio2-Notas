using System.Collections.Generic;

namespace ExercicioNotas.Objetos
{
    public class Aluno
    {
        public decimal MediaGeral { get; set; }
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}