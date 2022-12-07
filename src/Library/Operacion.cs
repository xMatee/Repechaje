namespace Library;
public abstract class Operacion : IEntrada
{
    private int maxEntradas {get; set;}
    public static List<double> entradasTotal = new();
    public void addEntrada(EntradaNumerica e){
        entradasTotal.Add(e.entrada);
    }
    public static List<Double> getEntradas(){
        return entradasTotal;
    }

    public abstract double getValue();
}
