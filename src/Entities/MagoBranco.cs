namespace jogo_rpg.src.Entities
{
    public class MagoBranco(string nome, int level) : Mago(nome, level, "Mago Branco")
    {
        public override string Atacar()
        {
            return $"{this.Nome} atacou com seu cajado";
        }

        public string Curar()
        {
            return $"{this.Nome} curou com magia";
        }
    }
}