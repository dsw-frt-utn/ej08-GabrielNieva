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

            //Problema 2

            var p2 = new Problema2();
            string resumen = p2.CrearResumenVenta(202, "Pepsi", 3, 500m);
            Console.WriteLine("Problema 2: " + resumen);

            string resumen2 = p2.CrearResumenVenta(303, "Coca-Cola", 0, 450m);
            Console.WriteLine("Problema 2 (con cantidad 0): " + resumen2);
        }
    }
}
