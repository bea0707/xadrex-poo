using System;

public abstract class Peca{

    public string cor {get; set}
    public int X {get; set;}
    public int Y {get;set;}

    public Peca (string cor, int x, int y ){
        this.Cor = cor;
        this.X = x;
        this.Y = y;
    }
    public abstract bool VerficarMovimento();
}

public class Peao : Peca{
    public Peao (string cor, int x, int y) : base (cor, x,y) {}
    public override bool VerficarMovimento()
}

            return true;{
           
}
  
 