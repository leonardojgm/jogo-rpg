namespace jogo_rpg.src.Entities
{
    public class Guerreiro(string nome, int level, string tipo = "Guerreiro") : Heroi(nome, level, tipo)
    {
        public override string Atacar()
        {
            return $"{this.Nome} atacou com sua espada";
        }
    }
}