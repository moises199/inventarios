using System;
class Casa
{
    public string color(string color){
        Console.WriteLine("El color de la casa es: " + color + "\n");
        return color;
}

    public int numventanas(int numventanas)
    {
        Console.WriteLine("Número de ventanas son: " + numventanas);
        return numventanas;

    }

    

    static void Main(string[] args)
    {
        string colo="verde";
        int cuatro=4;

        Casa casa=new Casa();

        Console.WriteLine("Ingrese el color de la casa");
        colo=Console.ReadLine();
          
        Console.WriteLine("Ingrese el número de ventanas");
        cuatro=int.Parse(Console.ReadLine());
        casa.numventanas(cuatro);
        casa.color(colo);





    }

}