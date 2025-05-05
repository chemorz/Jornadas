using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       
        string filePath = "terminos.txt";

       
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Dispose();
        }

        
        List<KeyValuePair<string, string>> terminos = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("Git", "Sistema de control de versiones distribuido utilizado para el desarrollo de software."),
            new KeyValuePair<string, string>("Ciberseguridad", "Práctica de proteger sistemas informáticos de ataques, accesos no autorizados o daños."),
            new KeyValuePair<string, string>("IA", "Inteligencia Artificial. Rama de la informática que simula la inteligencia humana."),
            new KeyValuePair<string, string>("RPA", "Automatización Robótica de Procesos, tecnología que utiliza robots de software para automatizar tareas repetitivas."),
            new KeyValuePair<string, string>("T-shaped person", "Persona con una gran experiencia en un área específica (la parte vertical de la T) y conocimientos generales en otras áreas (la parte horizontal de la T)."),
            new KeyValuePair<string, string>("JavaScript", "Lenguaje de programación utilizado principalmente para desarrollar páginas web interactivas."),
            new KeyValuePair<string, string>("Triggers", "Instrucciones en bases de datos que automáticamente ejecutan acciones en respuesta a eventos específicos."),
            new KeyValuePair<string, string>("UiPath", "Plataforma de software RPA para automatizar tareas repetitivas en aplicaciones y sistemas."),
            new KeyValuePair<string, string>("Workflow", "Secuencia de tareas automatizadas que son ejecutadas en un proceso de trabajo."),
            new KeyValuePair<string, string>("SQL", "Lenguaje de consulta estructurado utilizado para gestionar bases de datos relacionales."),
            new KeyValuePair<string, string>("NoSQL", "Tipo de base de datos que no utiliza un esquema relacional, ideal para datos no estructurados."),
            new KeyValuePair<string, string>("NewSQL", "Base de datos que combina características de bases de datos SQL y NoSQL."),
            new KeyValuePair<string, string>("Escalado Vertical", "Aumento de recursos de un solo servidor para mejorar su rendimiento."),
            new KeyValuePair<string, string>("Escalado Horizontal", "Aumento de recursos mediante la adición de más servidores a un sistema."),
            new KeyValuePair<string, string>("Teorema Brewer", "Teorema que establece los límites entre consistencia, disponibilidad y tolerancia a particiones en un sistema distribuido."),
            new KeyValuePair<string, string>("Teorema CAP", "Teorema que describe los trade-offs entre Consistencia, Disponibilidad y Tolerancia a Particiones en sistemas distribuidos."),
            new KeyValuePair<string, string>("Google Cloud", "Plataforma de computación en la nube de Google que ofrece infraestructura, almacenamiento, y servicios de análisis."),
            new KeyValuePair<string, string>("Data Analytics", "Proceso de examinar datos con el objetivo de sacar conclusiones sobre la información que contienen."),
            new KeyValuePair<string, string>("LinkedIn", "Red social orientada a profesionales para la creación de redes laborales y el desarrollo de la carrera profesional."),
            new KeyValuePair<string, string>("Ciclos de Vida", "Fases de desarrollo de un producto o sistema, desde su concepción hasta su retiro o actualización.")
        };

        
        SaveTermsToFile(terminos, filePath);

       
        Console.WriteLine("¿Deseas añadir un nuevo término? (s/n)");
        string respuesta = Console.ReadLine().ToLower();

        while (respuesta == "s")
        {
            Console.WriteLine("Introduce el nuevo término:");
            string terminoNuevo = Console.ReadLine();

            Console.WriteLine("Introduce la definición del término:");
            string definicionNueva = Console.ReadLine();

            
            terminos.Add(new KeyValuePair<string, string>(terminoNuevo, definicionNueva));

           
            SaveTermsToFile(terminos, filePath);

            Console.WriteLine("¿Deseas añadir otro término? (s/n)");
            respuesta = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Los términos han sido guardados.");
    }

    
    static void SaveTermsToFile(List<KeyValuePair<string, string>> terminos, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            foreach (var termino in terminos)
            {
                writer.WriteLine($"{termino.Key}: {termino.Value}");
            }
        }
    }
}
