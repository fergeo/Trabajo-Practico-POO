using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace TrabajoPracticoIntegrador1
{
    public class Cliente
    {

        private string nombre;
        private string apellido;
        private int dni;
        private string mail;
        private string periodoAlta; //Dependiendo si es mensual es un socio, o si es diario es un invitado
        private string fechaAlta;

        //GETTER Y SETTER NOMBRE
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        //GETTER Y SETTER APELLIDO
        public void setApellido(string apellido)
        {
           this.apellido = apellido;
        }
        public string getApellido()
        {
            return this.apellido;
        }

        //GETTER Y STTER DNI

        //GETTER Y STTER MAIL

        //GETTER Y STTER PERIODO ALTA

        //GETTER Y STTER FECHA ALTA

        private int dni;
        private string mail;
        private string periodoAlta;
        private string fechaAlta;



        public Cliente(string apellido, int dni, string mail, string periodoPago, string fechaAlta) 
        { 
                       
        }
    }

    public class Soccio : Cliente
    {
        Cliente cliente = new Cliente();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
