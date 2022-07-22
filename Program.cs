using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_examen
{
    internal class Persona
    {
        List<Persona> collPersonas = new List<Persona>();
        Persona objPersona;
       
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Sueldo { get; set; }
        public int Hijos { get; set; }
        public void CrearPersonas()
        {
            Random rand = new Random(Environment.TickCount);
            for(int i=0; i<100; i++)
            {
                objPersona = new Persona();
                objPersona.Nombre = "Nombre"+(i+1);
                objPersona.Apellido = "Apellido"+(i+1);
                objPersona.Edad = rand.Next(18, 35);
                objPersona.Sueldo = rand.Next(500, 1501);
                objPersona.Hijos = rand.Next(0, 5);
                collPersonas.Add(objPersona);
            }
        }
        public void MostrarPersonas()
        {
                foreach (var Persona in collPersonas)
                {
                    Console.WriteLine("El nombre es: " + Persona.Nombre);
                    Console.WriteLine("El apellido es: " + Persona.Apellido);
                    Console.WriteLine("La edad es: " + Persona.Edad);
                    Console.WriteLine("El sueldo es: " + Persona.Sueldo);
                    Console.WriteLine("La cantidad de hijos es: " + Persona.Hijos);
                    Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                }       
        }
        public void MayorSueldo()
        {
            double aux=0;
            var ganador=objPersona.Nombre;
            foreach(var persona in collPersonas)
            {

                if (aux == 0)
                {
                    aux = persona.Sueldo;
                }                   
                if (persona.Sueldo > aux)
                {
                    aux = persona.Sueldo;
                    ganador = persona.Nombre;
                }
            }
            Console.WriteLine("La persona que tiene el mayor sueldo es "+ ganador +" con un sueldo de: " + aux);
        }

        public void EdadesPares()
        {
            foreach(var Persona in collPersonas)
            {
                if(Persona.Edad%2==0)
                {
                    Console.WriteLine(Persona.Nombre+" tiene una edad par de "+Persona  .Edad);
                    Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                }
            }
        }

        public void TieneHijos()
        {
            foreach(var persona in collPersonas)
            {
                if(persona.Hijos==0)
                {
                    Console.WriteLine(persona.Nombre+" no tiene hijos");
                    Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                }
            }
        }

        public void Diagrama()
        {
            foreach(var persona in collPersonas)
            {
                Console.Write(persona.Nombre+" ");
                for(int i=0; i<(persona.Sueldo)/100; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Cada $100 representa un asterisco");
        }

        public void Menu()
        {
            int opc;
            Console.WriteLine("1) Mostrar 100 personas");
            Console.WriteLine("2) Conocer que persona tiene el mayor sueldo");
            Console.WriteLine("3) Saber que personas tienen una edad par");
            Console.WriteLine("4) Saber que personas no tienen hijos");
            Console.WriteLine("5) Mostrar diagrama de sueldos a escala");
            opc=int.Parse(Console.ReadLine());
            
            switch(opc)
            {
                case 1:
                    MostrarPersonas();
                    Confirmacion();
                    break;
                case 2:
                    MayorSueldo();
                    Confirmacion();
                    break;
                case 3:
                    EdadesPares();
                    Confirmacion();
                    break;
                case 4:
                    TieneHijos();
                    Confirmacion();
                    break;
                case 5:
                    Diagrama();
                    Confirmacion();
                    break;
                default:
                    break;
            }
        }

        private void Confirmacion()
        {
            string conf;
            Console.WriteLine("Desea realizar otra acción?");
            Console.WriteLine(" s/n ");
            conf=Console.ReadLine();
            if(conf=="s")
            {
                Console.Clear();
                Menu();
            }
        }

        private void EliminarPersona()
        {
            int ind;
            Console.WriteLine("Escriba el indice de la persona que desea eliminar");
            ind=int.Parse(Console.ReadLine());
            foreach(var persona in collPersonas)
            {

            }
        }

        static void Main(string[] args)
        {
            Persona objPersona = new Persona();
            objPersona.CrearPersonas();
            objPersona.Menu();
        }
    }
}