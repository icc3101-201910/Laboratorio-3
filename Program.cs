using System;

namespace Laboratorio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Libreria libreria = new Libreria("Valdivia", "Algún lugar de valdivia");
            int ventasNoConcretadas = 0;

            // Libros fantasía épica
            libreria.AgregarArticulo(new Libro("Juego de tronos", "George R.R Martin", 12000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Choque de reyes", "George R.R Martin", 13000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Tormenta de espadas", "George R.R Martin", 16000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Festín de cuervos", "George R.R Martin", 12000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Danza de dragones", "George R.R Martin", 16000, random.Next(11)));

            // Libros fantasía
            libreria.AgregarArticulo(new Libro("Harry Potter y la piedra filosofal", "J. K. Rowling", 10000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Harry Potter y la cámara secreta", "J. K. Rowling", 10000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Harry Potter y el prisionero de Azkaban", "J. K. Rowling", 10000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Harry Potter y el cáliz de fuego", "J. K. Rowling", 10000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Harry Potter y la orden del fénix", "J. K. Rowling", 10000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Harry Potter y el misterio del príncipe", "J. K. Rowling", 10000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Harry Potter y las reliquias de la muerte", "J. K. Rowling", 10000, random.Next(11)));

            // Libros liderazgo
            libreria.AgregarArticulo(new Libro("La inteligencia emocional", "Daniel Goleman", 11000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Liderazgo. El Poder de la Inteligencia Emocional", "Daniel Goleman", 22020, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Cómo ser un lider", "Daniel Goleman", 10000, random.Next(11)));

            // Libros de programación
            libreria.AgregarArticulo(new Libro("The pragmatic programmer", "Andrew Hunt", 50000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Clean Code", "Robert C. Martin", 56500, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Design Patters", "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", 66690, random.Next(11)));
            libreria.AgregarArticulo(new Libro("Aprendiendo UML en 24 horas", "Joseph Schmuller", 20000, random.Next(11)));
            libreria.AgregarArticulo(new Libro("La Biblia de C#", "Joseph Schmuller", 20000, random.Next(11)));

            // Juegos
            libreria.AgregarArticulo(new Juego("The Last for Us", "PS4", 13000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("Warcraft 3", "PC", 5000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("God Of War", "PS4", 40000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("Spyro: trilogy", "PS4", 45000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("Attack On Titan", "PS4", 40000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("GTA 5", "PC", 13000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("Overcooked", "PC", 25000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("Overcooked 2", "PC", 30000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("Ashen", "XBox", 20000, random.Next(11)));
            libreria.AgregarArticulo(new Juego("QUANTUM BREAK", "XBox", 34000, random.Next(11)));


            Console.WriteLine("========= Simulación =========");

            for (int hora = 9; hora < 20; hora++)
            {

                // No era necesario imprimir el horario, pero así se ve más ordenado
                Console.WriteLine("");
                if (hora == 9)
                {
                    Console.WriteLine("== Horario: 09:00 - 10:00 ==");
                }
                else
                {
                    Console.WriteLine($"== Horario: {hora}:00 - {hora + 1}:00 ==");
                }

                int cantidadVisitantes = random.Next(5, 13);

                for (int numeroDeVisitante = 0; numeroDeVisitante < cantidadVisitantes; numeroDeVisitante++)
                {
                    string rutAleatorio = random.Next(10000000, 20000000) + "-" + random.Next(10);
                    Persona persona = new Persona(rutAleatorio);
                    bool personaCompra = random.Next(0, 101) <= 30;
                    if (personaCompra)
                    {
                        int indiceDeArticulo = random.Next(libreria.ObtenerCantidadDeArticulos());
                        Articulo articulo = libreria.ObtenerArticulo(indiceDeArticulo);
                        bool ventaExitosa = libreria.VenderArticulo(articulo, persona);

                        if (ventaExitosa)
                        {
                            Venta ultimaVenta = libreria.ObtenerUltimaVenta();
                            Console.WriteLine(ultimaVenta.ObtenerDescripcion());
                        }
                        else
                        {
                            Console.WriteLine($"Oh no! No pudimos vender {articulo.ObtenerDescripcion()}"); // No era necesario imprimir esto
                            ventasNoConcretadas += 1;
                        }
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("=== Resultado Simulación ===");
            Console.WriteLine($"Cantidad de ventas: {libreria.ObtenerCantidadDeVentas()}");
            Console.WriteLine($"Ingresos totales: {libreria.ObtenerMontoDeVentas()}");
            Console.WriteLine($"Número de ventas no concretadas por falta de stock: {ventasNoConcretadas}");

        }
    }
}
