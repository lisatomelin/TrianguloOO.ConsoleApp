namespace TrianguloOO.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Triangulo lados = new Triangulo();

            
            Console.WriteLine("Informe o lado 1: ");
            lados.lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado 2: ");
            lados.lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado 3: ");
            lados.lado3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("É possivel formar um triângulo? " + lados.FormarTriangulo());
            Console.WriteLine("É um triângulo Escaleno? " + lados.FormarEscaleno());
            Console.WriteLine("É um triângulo Isóceles? " + lados.FormarIsoceles());
            Console.WriteLine("É um triângulo Equilátero? " + lados.FormarEquilatero());

            Console.WriteLine();
            

        }
    }
}