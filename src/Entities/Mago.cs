namespace jogo_rpg.src.Entities
{
    //Herança
    public class Mago(string nome, int level, string tipo = "Mago") : Heroi(nome, level, tipo)
    {
        public override string Atacar()
        {
            return $"{this.Nome} atacou com seu cajado";
        }

        //Polimorfismo
        public string Atacar(int bonus)
        {
            if (bonus > 6) return $"{this.Nome} atacou com seu cajado de forma super efetiva";

            return $"{this.Nome} lançou com seu cajado de forma fraca";
        }
    }
}