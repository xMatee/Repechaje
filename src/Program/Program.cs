using Library;

class Program {
    static void Main(string[] args) {
        EntradaNumerica ent1 = new(2);
        EntradaNumerica ent2 = new(5);
        EntradaNumerica ent3 = new(1);
        Operacion opMul = new Multiplicacion(ent1, ent2, 5);
        opMul.addEntrada(ent1);
        opMul.addEntrada(ent2);
        opMul.addEntrada(ent3);

        Console.WriteLine(opMul.getValue());
    }
}
