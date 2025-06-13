namespace jogo_rpg.src.Entities
{
    //Encapsulamento
    public class Ninja(string nome, int level) : Guerreiro(nome, level, "Ninja")
    {
        public override string Atacar()
        {
            return $"{this.Nome} atacou com sua katana";
        }
    }
}