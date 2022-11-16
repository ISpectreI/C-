using System;
using System.Collections.Generic;
using System.Text;

namespace TRABAJOFINAL
{
    class cliente
    {
        string direccion;
        string dni;
        string nombresyapellidos;
        int numero_de_orden;
        string telefono;
        string cantidad;
        string tipo;
        public string Direccion { get=> direccion; set=>direccion=value; }
        public string Dni { get=>dni; set=>dni=value; }
        public string Nombresyapelldido { get=> nombresyapellidos; set=> nombresyapellidos = value; }
        public int Numero_de_orden { get=>numero_de_orden; set=>numero_de_orden=value; }
        //public DateTime fechaNac { get; set; }
        public string Telefono { get=>telefono; set=>telefono=value; }
        public string Cantidad { get=>cantidad; set=>cantidad=value; }
        public string Tipo { get=>tipo; set=>tipo=value; }

        public cliente() { }
       public cliente(string direccion, string dni, string nombresyapellidos, int numero_de_orden, string telefono, string cantidad, string tipo) {

            this.direccion = direccion;
            this.dni = dni;
            this.nombresyapellidos = nombresyapellidos;
            this.numero_de_orden = numero_de_orden;
            this.telefono = telefono;
            this.cantidad = cantidad;
            this.tipo = tipo;
       
        }
        public override string ToString()
        {
            return direccion+";"+dni+";"+ nombresyapellidos + ";"+numero_de_orden+";"+telefono+";"+cantidad+";"+tipo;

        }

    }
}
