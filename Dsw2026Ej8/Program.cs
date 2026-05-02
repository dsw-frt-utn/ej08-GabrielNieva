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

            //Problema 3

            var p3 = new Problema3();
            var miProducto = new Product("Producto original");
            string res3 = p3.ComprarCopias(5, miProducto);
            Console.WriteLine("Problema 3: " + res3);

            //Problema 4

            var p4 = new Problema4();
            Console.WriteLine("Problema 4 (7,8,9): " + p4.CalcularPromedio(7, 8, 9));
            Console.WriteLine("Problema 4 (5,null,9): " + p4.CalcularPromedio(5, null, 9));
            Console.WriteLine("Problema 4 (null,null,null): " + p4.CalcularPromedio(null, null, null));
            Console.WriteLine("Problema 4 (5,15,9): " + p4.CalcularPromedio(5, 15, 9));

            //Problema 5
            var p5 = new Problema5();
            Sale minorista = new RetailSale(1000m);
            Sale mayorista = new WholesaleSale(1000m);
            Console.WriteLine("Importe Final Minorista: " + p5.ObtenerImporteFinal(minorista));
            Console.WriteLine("Importe Final Mayorista (10% desc): " + p5.ObtenerImporteFinal(mayorista));

        }
    }
}
