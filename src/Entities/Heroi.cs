namespace jogo_rpg.src.Entities
{
    //Abstração
    public abstract class Heroi(string nome, int level, string tipo = "Aprendiz")
    {
        //Atributos
        public string Nome = nome;
        public int Level = level;
        public string Tipo = tipo;
        public int Vida = 100;
        public int Mana = 100;

        //Métodos
        public override string ToString()
        {
            return $"{this.Nome} {this.Level} {this.Tipo} Vida: {this.Vida} Vida: {this.Mana}";
        }

        public virtual string Atacar()
        {
            return $"{this.Nome} atacou com sua espada";
        }
    }
}