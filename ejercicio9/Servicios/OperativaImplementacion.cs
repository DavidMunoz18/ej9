using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        string frase;
        public void metodoPrincipal()
        {
            solicitarYReemplazar();
            separarFrase();
            vocalesFaltan();
            
        }
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
        private void solicitarYReemplazar()
        {
            Console.WriteLine("Introduzca una frase por consola");
            frase = Console.ReadLine();

            

            for (int i = 0; i <= vocales.Length - 1; i++)
            {
                frase = frase.Replace(vocales[i] , '*');
            }
           

            Console.WriteLine(frase);

            

        }
        private void separarFrase()
        {
            string[] fraseSeparada = frase.Split(" ");


            DateTime fecha = DateTime.Today;

            string ruta = fecha.Date.ToString("dd-MM-yyyy") + ".txt";

            using(StreamWriter sw = new StreamWriter(ruta)) 
            {
                for (int i = 0; i <= fraseSeparada.Length - 1; i++)
                {
                    sw.WriteLine(fraseSeparada[i]);
                }

            }

            String[] leer = File.ReadAllLines(ruta);

           Console.WriteLine("ULTIMAS 2 POSICIONES");
                for (int i = fraseSeparada.Length - 2 ; i < fraseSeparada.Length; i++)
                {
                
                Console.WriteLine(leer[i]);
                }
            


           
        }
        private void vocalesFaltan()
        {
            Console.WriteLine("¿Cuantas vocales faltan?");
            int numVocales = Convert.ToInt32(Console.ReadLine());



            int vocale = 0;

            for (int i = 0;i < frase.Length; i++)
            {
                if (frase[i] == '*'){

                    vocale++;
                }
            }
            Console.WriteLine("FALTAN: " + vocale);

            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            if(numVocales == vocale)
            {
                
                for(int i = 0; i < vocale; i++)
                {
                    Console.WriteLine("Puedes introducir " + vocale + " " + "vocales");
                    Console.WriteLine("Introduzca las vocales que faltan");
                    char vocalesFaltan = Convert.ToChar(Console.ReadLine());                  

                    

                    frase = frase.Replace('*', vocalesFaltan);

                    

                    
                    

                    
                    
                }
                

                Console.WriteLine(frase);

            }
          

        }
       
       
    }
}
