using jogo_rpg.src.Entities;

//Orientação a objeto
Heroi arus = new Guerreiro("Arus", 42);
Guerreiro wedge = new Ninja("Wedge", 20);
MagoBranco jennica = new("Jennica", 23);
MagoNegro topapa = new("Topapa", 23);

Console.WriteLine(arus);
Console.WriteLine(wedge);
Console.WriteLine(jennica);
Console.WriteLine(topapa);
Console.WriteLine(arus.Atacar());
Console.WriteLine(wedge.Atacar());
Console.WriteLine(jennica.Atacar());
Console.WriteLine(jennica.Atacar(5));
Console.WriteLine(jennica.Atacar(7));
Console.WriteLine(jennica.Curar());
Console.WriteLine(topapa.Atacar());
Console.WriteLine(topapa.Atacar(6));
Console.WriteLine(topapa.ConjurarMagia("Bola de fogo"));