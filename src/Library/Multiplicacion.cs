namespace Library;

public class Multiplicacion : Operacion{
    private int maxEntradas{get;}
    public Multiplicacion(EntradaNumerica ent1, EntradaNumerica ent2, int max){
        this.maxEntradas=max;
        addEntrada(ent1);
        addEntrada(ent2);
    }
    public override double getValue(){
        double value=1;
        foreach(double num in getEntradas())
        {
            value*=num;
        }

        return value;
    }
}