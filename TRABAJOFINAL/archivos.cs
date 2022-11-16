using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TRABAJOFINAL
{
    class empleadoarchivo
    {
        public static bool agregarfichero(string fichero, string direccion_,string new_dni, string new_nombreapellido, int new_norden, string new_telefono, string new_cantidad,string new_tipo)
        {

            FileStream fs;
            BinaryWriter bw;
            bool band = false;

            try
            {

                fs = new FileStream(fichero, FileMode.Append, FileAccess.Write);
                bw = new BinaryWriter(fs);

                cliente em = new cliente();
                em.Direccion = direccion_;
                em.Dni = new_dni;
                em.Nombresyapelldido = new_nombreapellido;
                em.Numero_de_orden = new_norden;
                em.Telefono = new_telefono;
                em.Cantidad = new_cantidad;
                em.Tipo = new_tipo;
                bw.Write(em.Direccion);
                bw.Write(em.Dni);
                bw.Write(em.Nombresyapelldido);
                bw.Write(em.Numero_de_orden);
                bw.Write(em.Telefono);
                bw.Write(em.Cantidad);
                bw.Write(em.Tipo);

                bw.Close();
                fs.Close();
                band = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return band;
        }

        public static List<cliente> buscar(string fichero, string dni_buscar)
        {

            FileStream fs;
            BinaryReader br;
            List<cliente> lista = new List<cliente>();

            try
            {
                if (File.Exists(fichero) == false)
                {

                    MessageBox.Show("El archivo no existe");
                }
                fs = new FileStream(fichero, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    cliente em = new cliente();
                    em.Direccion = br.ReadString();
                    em.Dni = br.ReadString();
                    em.Nombresyapelldido = br.ReadString();
                    em.Numero_de_orden = br.ReadInt32();
                    em.Telefono = br.ReadString();
                    em.Cantidad = br.ReadString();
                    em.Tipo = br.ReadString();
                    if (dni_buscar.Equals(em.Dni))
                    {
                        lista.Add(em);
                    }
                }
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public static List<cliente> mostrarfichero(string fichero)
        {

            FileStream fs;
            BinaryReader br;
            List<cliente> lista = new List<cliente>();

            try
            {
                if (File.Exists(fichero) == false)
                {

                    MessageBox.Show("El archivo no existe");
                }
                fs = new FileStream(fichero, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    cliente em = new cliente();
                    em.Direccion = br.ReadString();
                    em.Dni = br.ReadString();
                    em.Nombresyapelldido = br.ReadString();
                    em.Numero_de_orden = br.ReadInt32();
                    em.Telefono = br.ReadString();
                    em.Cantidad = br.ReadString();
                    em.Tipo = br.ReadString();

                    lista.Add(em);

                }
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return lista;
        }
        public static bool modificar(string fichero, string direccion_ ,string new_dni, string new_nombreapellido, int new_norden, string new_telefono, string new_cantidad, string new_tipo)
        {
            FileStream fs_empleado = null;
            FileStream fs_temp = null;
            string temporal = "temporal.txt";

            bool booleano = false;


            try
            {
                fs_empleado = new FileStream(fichero, FileMode.Open, FileAccess.Read);
                fs_temp = new FileStream(temporal, FileMode.Create, FileAccess.Write);

                BinaryReader br = new BinaryReader(fs_empleado);
                BinaryWriter bw_temp = new BinaryWriter(fs_temp);

                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    cliente em = new cliente();
                    em.Direccion = br.ReadString();
                    em.Dni = br.ReadString();
                    em.Nombresyapelldido = br.ReadString();
                    em.Numero_de_orden = br.ReadInt32();
                    em.Telefono = br.ReadString();
                    em.Cantidad = br.ReadString();
                    em.Tipo = br.ReadString();

                    if (new_dni.Equals(em.Dni))
                    {
                        em.Direccion = direccion_;
                        em.Nombresyapelldido = new_nombreapellido;
                        em.Numero_de_orden = new_norden;
                        em.Telefono = new_telefono;
                        em.Cantidad= new_cantidad;
                        em.Tipo = new_tipo;

                        bw_temp.Write(em.Direccion);
                        bw_temp.Write(em.Dni);
                        bw_temp.Write(em.Nombresyapelldido);
                        bw_temp.Write(em.Numero_de_orden);
                        bw_temp.Write(em.Telefono);
                        bw_temp.Write(em.Cantidad);
                        bw_temp.Write(em.Tipo);
                        booleano = true;
                    }
                    else
                    {
                        bw_temp.Write(em.Direccion);
                        bw_temp.Write(em.Dni);
                        bw_temp.Write(em.Nombresyapelldido);
                        bw_temp.Write(em.Numero_de_orden);
                        bw_temp.Write(em.Telefono);
                        bw_temp.Write(em.Cantidad);
                        bw_temp.Write(em.Tipo);

                    }
                }
                br.Close();
                bw_temp.Close();
                fs_empleado.Close();
                fs_temp.Close();

                File.Delete(fichero);
                File.Move(temporal, fichero);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return booleano;
        }

        public static bool eliminar(string fichero, string dni_buscar)
        {
            FileStream fs_emple = null;
            FileStream fs_temp = null;
            string temporal = "temporal.txt";

            bool booleano = false;

            try
            {
                fs_emple = new FileStream(fichero, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs_emple);

                fs_temp = new FileStream(temporal, FileMode.Create, FileAccess.Write);
                BinaryWriter bw_temp = new BinaryWriter(fs_temp);


                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    cliente em = new cliente();
                    em.Direccion = br.ReadString();
                    em.Dni = br.ReadString();
                    em.Nombresyapelldido = br.ReadString();
                    em.Numero_de_orden = br.ReadInt32();
                    em.Telefono = br.ReadString();
                    em.Cantidad = br.ReadString();
                    em.Tipo = br.ReadString();

                    if (dni_buscar.Equals(em.Dni))
                    {
                        booleano = true;
                    }
                    else
                    {
                        bw_temp.Write(em.Direccion);
                        bw_temp.Write(em.Dni);
                        bw_temp.Write(em.Nombresyapelldido);
                        bw_temp.Write(em.Numero_de_orden);
                        bw_temp.Write(em.Telefono);
                        bw_temp.Write(em.Cantidad);
                        bw_temp.Write(em.Tipo);

                    }

                }
                br.Close();
                bw_temp.Close();
                fs_emple.Close();
                fs_temp.Close();

                File.Delete(fichero);
                File.Move(temporal, fichero);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return booleano;
        }


    }

}

