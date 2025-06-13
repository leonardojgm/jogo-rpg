namespace jogo_rpg.src.Entities
{
    public class MagoNegro(string nome, int level) : Mago(nome, level, "Mago Negro")
    {
        public string ConjurarMagia(string magia)
        {
            return $"{this.Nome} lançou a magia {magia}";
        }
    }
}