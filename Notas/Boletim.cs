namespace Exercicio2___Notas.Notas
{
    public class Boletim
    {
        public Boletim(decimal pedindonota)
        {
            PedindoNota = new PedindoNota(pedindonota);

        }
        public PedindoNota PedindoNota { get; set; }
    }
}