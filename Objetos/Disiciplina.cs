using System.Collections.Generic;

namespace ExercicioNotas.Objetos
{
    public class Disciplina
    {

        public bool podeAdicionarNota = true;
        public List<Nota> Notas { get; private set; }
        public string Nome { get; set; }
        public decimal Media { get; private set; }

        public Disciplina(string nome)
        {
            Nome = nome;
            Notas = new List<Nota>();
            // sempre que for uma lista é necessário instancear antes para poder adicionar itens depois
            // dessa forma, assim que uma nova Disciplina for instanceada 
            // também será instanceada uma nova lista de notas que estará pronta para receber uma nota.
            // caso isso não seja feito pode ocorrer erro de inicialização de listas.
        }


        public void AdicionarNota(Nota nota)
        {
            if (podeAdicionarNota)
            {
                Notas.Add(nota);
            }
            GerarMedia();
            ValidarQuantidadeNotas();
        }

        private void ValidarQuantidadeNotas()
        {
            //criar validação
        }
        private void GerarMedia()
        {
            //criar algoritimo de média
            Media = 0;
        }
        public override string ToString()
        {
            return $"A média na disciplina {Nome} é {Media}";
        }
    }
}