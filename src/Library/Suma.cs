namespace Library;

public class Suma : Operacion{
    private int maxEntradas{get;}
    public Suma(EntradaNumerica ent1, EntradaNumerica ent2, int max){
        this.maxEntradas=max;
        addEntrada(ent1);
        addEntrada(ent2);

    }
    public override double getValue(){
        double value = 0;
        foreach(double num in getEntradas())
        {
            value+=num;
        }
        return value;
    }
}