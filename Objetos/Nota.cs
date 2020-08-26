namespace ExercicioNotas.Objetos
{
    public class Nota
    {
        private bool valido = false;
        public decimal Valor { get; private set; }
        public Nota(decimal valor)
        {
            Valor = valor;
            Validar();
        }

        private void Validar()
        {
            valido = true;

            if (Valor < 0 || Valor > 10)
            {
                valido = false;
            }
        }

        public override string ToString()
        {
            if (valido)
            {
                return Valor.ToString();
            }

            return "Nota inválida";
        }

    }
}