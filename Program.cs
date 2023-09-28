namespace Poo_carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concesionario consecionario = new Concesionario(10);

            Carro c1 = new Carro(1,"bmw","1992",56,5892);
            Carro c2 = new Carro(2,"ford","2025",34,5892);
            Carro c3 = new Carro(3,"set","2025",54,5892);
            Carro c4 = new Carro(4,"chev","2302",67,5892);
            Carro c5 = new Carro(5,"peugout","4520",23,5892);


            Console.WriteLine("Añadiendo todos los coches");
            consecionario.anadirCarro(c1);
            consecionario.anadirCarro(c2);
            consecionario.anadirCarro(c3);
            consecionario.anadirCarro(c4);
            consecionario.anadirCarro(c5);
            Console.WriteLine();

            Console.WriteLine("mostrando todos los coches");
            consecionario.mostrarCarro();
            Console.WriteLine();

            Console.WriteLine("elimino dos de  los coches");
            consecionario.eliminarCarro(c5);
            consecionario.eliminarCarro(c1);
            Console.WriteLine();

            Console.WriteLine("muestro nuevamente los coches");
            consecionario.mostrarCarro();
            consecionario.eliminarCarro(c1);
            Console.WriteLine();

            Console.WriteLine("agrego nuevamente dos de  los coches");
            consecionario.anadirCarro(c5);
            consecionario.anadirCarro(c1);
            Console.WriteLine();

            Console.WriteLine("mostrando todos los coches");
            consecionario.mostrarCarro();
            Console.WriteLine();

            Console.WriteLine("vaceo todos los choches");
            consecionario.vaciarCarro();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}