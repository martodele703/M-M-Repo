using System; // Importa el espacio de nombres System, que contiene clases básicas de .NET

namespace Ucu.Poo.Persons // Define un espacio de nombres llamado Ucu.Poo.Persons
{
    public class Person // Define una clase llamada Person
    {
        // Campo privado que almacena el nombre de la persona
        private string name;

        // Propiedad pública para acceder al campo 'name'
        public string Name
        {
            get { return name; } // Devuelve el valor del campo 'name'
            set { name = value; } // Asigna un valor al campo 'name'
        }

        // Campo privado que almacena la identificación de la persona
        private string id;

        // Propiedad pública para acceder al campo 'id'
        public string Id
        {
            get { return id; } // Devuelve el valor del campo 'id'
            set { id = value; } // Asigna un valor al campo 'id'
        }

        // Constructor que inicializa los valores de 'name' e 'id'
        public Person(string name, string id)
        {
            this.Name = name; // Asigna el valor del parámetro 'name' a la propiedad 'Name'
            this.Id = id; // Asigna el valor del parámetro 'id' a la propiedad 'Id'
        }

        // Método público que imprime en consola una presentación de la persona
        public void IntroduceYourself()
        {
            Console.WriteLine(
                $"Soy {this.Name} y mi cédula es {this.Id}"); // Muestra el nombre y la identificación de la persona
        }
    }

    class Program // Clase principal del programa
    {
        static void Main(string[] args) // Método de entrada del programa
        {
            // Crea dos objetos Person con valores predefinidos
            Person john = new Person("John Doe", "1.234.567-8");
            Person jane = new Person("Jane Doe", "8.765.432-1");

            // Llama al método IntroduceYourself para mostrar la información de cada persona
            john.IntroduceYourself();
            jane.In
