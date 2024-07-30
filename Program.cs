using System;

namespace Generico_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjeto archivo = new AlmacenObjeto(4);
            Empleado miEmpleado1 = new(300.4);

            Animal miAnimal = new("Hamel", "Perro", 3);

            archivo.agregar("Hola");
            archivo.agregar(miEmpleado1);
            archivo.agregar(miAnimal);
            archivo.agregar(6);

            String nombrePersona = (String)archivo.GetElemento(0);

            Console.WriteLine(nombrePersona);

            Empleado empleado1 = (Empleado)archivo.GetElemento(1);

            Console.WriteLine(empleado1.GetSalario());

            Animal miAnimal1 = (Animal)archivo.GetElemento(2);

            Console.WriteLine(miAnimal1.GetDatos());

        }
    }
    class AlmacenObjeto
    {
        private int i = 0;
        public AlmacenObjeto(int z) 
        {
            datosElemento = new Object[z];
        }

        public void agregar(Object Obj)
        {
            datosElemento[i] = Obj;
            i++;
        }

        public Object GetElemento(int i)
        {
            return datosElemento[i];
        }

        private Object[] datosElemento;
        
    }

    class Empleado
    {
        private double salario;
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Animal
    {
        private String nombre;
        private String raza;
        private int edad;
        public Animal(string nombre, string raza, int edad)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
        }

        public String GetDatos()
        {
            return " " + this.nombre + " " + this.raza + " " + this.edad;
        }
    }
}
