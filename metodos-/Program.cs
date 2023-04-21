using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objeto usando constructor por defecto
            Carro carro1 = new Carro();
            Console.WriteLine("Nombre: " + carro1.Modelocarro());
            Console.WriteLine("Edad: " + carro1.ObtenerColor());

            // Crear objeto usando constructor con parámetros
            Carro carro2 = new Carro("Chevrolet","Gris");
            Console.WriteLine("Nombre: " + carro2.Modelocarro());
            Console.WriteLine("Edad: " + carro2.ObtenerColor());

            // Llamada al método sobrecargado
            Console.WriteLine(carro2.Modelocarro("Hola el  modelo es"));

          
            Console.ReadKey();
        }
    }
    public class Carro
    {
        private string marca;
        private string color;
      
     
        // Constructor por defecto
        public Carro()
        {
            this.marca = "SUZUKI";
            this.color = "NEGRO";
        }

        // Constructor con parámetros
        public Carro(string marcaa, string colorr)
        {
            this.marca = marcaa;
            this.color = colorr;
        }

        // Método que devuelve el MODELO DEL CARRO
        public string Modelocarro()
        {
            return this.marca;
        }

        // Sobrecarga del método 
        public string Modelocarro(string saludo)
        {
            return saludo + " " + this.marca + " " + this.color;
        }

        // Método que devuelve EL COLOR
        public string ObtenerColor()
        {
            return this.color;
        }

        // Destructor
        ~Carro()
        {
            Console.WriteLine("Objeto Persona destruido.");
        }
    }
}

    
