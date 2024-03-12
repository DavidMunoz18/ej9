using ejercicio9.Servicios;

namespace ejercicio9.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            OperativaInterfaz oi = new OperativaImplementacion();

            bool cerrarMenu = false;

           
            do
            {

                oi.metodoPrincipal();

            } while (!cerrarMenu);

           

        }
    }
}
