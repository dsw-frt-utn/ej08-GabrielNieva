namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Problema 1

            var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(12345, "Camiseta", 19.99m);
            Console.WriteLine("Problema 1: " + etiqueta);
        }
    }
}
