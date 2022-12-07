namespace Library;

public class EntradaNumerica : IEntrada{
    public double value {get;}
    public double entrada {get;}
    public EntradaNumerica(double entrada){
        this.entrada=entrada;
    }
    public double getValue(){
        return this.value;
    }
}