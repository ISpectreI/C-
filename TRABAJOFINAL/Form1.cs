using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace TRABAJOFINAL
{
    public partial class Form1 : Form
    {
        string accion;
        string archivo = "empleados.txt";
        int cantidadtotal;
        int numerodeorden=1;
        int cantidad_del_cliente;
        List<cliente> list_clientes = new List<cliente>();
        int posicion;

        public Form1(int cantidad)
        {
            
            InitializeComponent();
            //cantidadtotal = int.Parse(lblcantidad.Text);//40 si ingresa 40
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {


            inhabilitar();
            listar();
            quitarselecionDTG();



        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            accion = "Nuevo";
            limpiar();
            habilitar();


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK) {

                    if (File.Exists(saveFileDialog1.FileName))
                    {

                        string txt = saveFileDialog1.FileName;
                        StreamWriter textoguardar = File.CreateText(txt);
                        textoguardar.Close();
                        //  textoguardar.Write();


                        foreach (cliente p in list_clientes) {
                            
                            StreamWriter agregar = File.AppendText(txt);

                            agregar.WriteLine(p.Direccion+" / "+p.Dni+" / "+p.Nombresyapelldido);

                           agregar.Close();

                        }

                    }
                    else {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textoguardar = File.CreateText(txt);
                        //  textoguardar.Write();
                        textoguardar.Close();

                        foreach (cliente p in list_clientes)
                        {

                            StreamWriter agregar = File.AppendText(txt);

                            agregar.WriteLine(p.Direccion + " / " + p.Dni + " / " + p.Nombresyapelldido);

                            agregar.Close();

                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("error al guardar");
            }

        }//ESTE NO SIRVE BUENO SI SIRVE PERO TODAVIA NO
        private void guardardatos() { 
        
        

        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

         }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dtgpedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n_ = e.RowIndex;
            if (n_ != -1)
            {
                darlosvalorescuandodeclick(n_);
            }
            else { MessageBox.Show("Se debe seleccionar una fila"); }
        }

        private void btndeduas_Click(object sender, EventArgs e)
        {

        }
        private void darlosvalorescuandodeclick(int n)
        {
            string direccion = (string)dtgpedidos.Rows[n].Cells[0].Value;
            string dni = (string)dtgpedidos.Rows[n].Cells[1].Value;
            string nombreapellido = (string)dtgpedidos.Rows[n].Cells[2].Value;
            int numero_orden = (int)dtgpedidos.Rows[n].Cells[3].Value;
            string telefonos = (string)dtgpedidos.Rows[n].Cells[4].Value;
            string cant = (string)dtgpedidos.Rows[n].Cells[5].Value;
            string tipo = (string)dtgpedidos.Rows[n].Cells[6].Value;

            textdireccion.Text = direccion;
            textdni.Text = dni;
            textnombreapellido.Text = nombreapellido;
             
            texttelefono.Text = telefonos;
            textcantidad.Text = cant;
            cmbboxtipo.Text = tipo;
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
         
            if (valida())
            {
                if (accion.Equals("Nuevo"))
                {

                    cliente empleado = new cliente();
                    empleado.Direccion = textdireccion.Text;
                    empleado.Dni = textdni.Text;
                    empleado.Nombresyapelldido = textnombreapellido.Text;
                    empleado.Telefono = texttelefono.Text;
                    empleado.Cantidad = textcantidad.Text;
                    empleado.Tipo = cmbboxtipo.Text;

                    if (Convert.ToInt32(lblcantidad.Text) - Convert.ToInt32(textcantidad.Text) > 0)
                    {
                        bool rpta = empleadoarchivo.agregarfichero(archivo, empleado.Direccion,
                                           empleado.Dni, empleado.Nombresyapelldido, 5, empleado.Telefono,
                                           empleado.Cantidad, empleado.Tipo);

                        if (rpta == true)
                        {
                            MessageBox.Show("Datos registrados correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error. No se pudo registrar los datos");
                        }
                       /* int nuevovalor = Convert.ToInt32(lblcantidad.Text);
                        nuevovalor= Convert.ToInt32(lblcantidad.Text) - Convert.ToInt32(textcantidad.Text);
                        lblcantidad.Text = int.Parse(nuevovalor);*/
                    }
                    else { MessageBox.Show("Excede la cantidad de productos"); }
                       
                    

                }
                if (accion.Equals("Modificar"))
                {
                    cliente empleado = new cliente();

                    empleado.Direccion = textdireccion.Text;
                    empleado.Dni = textdni.Text;
                    empleado.Nombresyapelldido = textnombreapellido.Text;
                    empleado.Telefono = texttelefono.Text;
                    empleado.Cantidad = textcantidad.Text;
                    empleado.Tipo = cmbboxtipo.Text;

                    bool rpta = empleadoarchivo.modificar(archivo,empleado.Direccion,
                                                empleado.Dni, empleado.Nombresyapelldido,5, empleado.Telefono,
                                                empleado.Cantidad, empleado.Tipo);
                   

                }
                inhabilitar();
                listar();
                limpiar();
                quitarselecionDTG();
            }
           
        }
        private void limpiar()
        {
            textdireccion.ResetText();
            textdni.ResetText();
            textnombreapellido.ResetText();
            texttelefono.ResetText();
            textcantidad.ResetText();
            cmbboxtipo.ResetText();
        }
        private void inhabilitar()
        {

            btnagregar.Enabled = true;
            btn_guardar.Enabled = false;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            btncancelar.Enabled = false;


            textdni.Enabled = false;
            textnombreapellido.Enabled = false;
            texttelefono.Enabled = false;
            textdireccion.Enabled = false;
            textcantidad.Enabled = false;
         



        }
        private void habilitar()
        {

            btnagregar.Enabled = false;
            btn_guardar.Enabled = true;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btncancelar.Enabled = true;

            textdni.Enabled = true;
            textnombreapellido.Enabled = true;
            texttelefono.Enabled = true;
            textdireccion.Enabled = true;
            textcantidad.Enabled = true;

        }
        private void quitarselecionDTG()
        {

           dtgpedidos.ClearSelection();
           dtgpedidos.CurrentCell = null;
        }
        private void listar()
        {

            list_clientes = empleadoarchivo.mostrarfichero(archivo);
            dtgpedidos.DataSource = null;
            dtgpedidos.DataSource =list_clientes ;
        }  ////////// LISTAARCON BLOC DEN OTAS

        private bool valida() {
            bool booleano = true;
            return booleano;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dtgpedidos.SelectedCells.Count > 0)
            {
                accion = "Modificar";
                habilitar();
                textdni.Enabled = false;
            }
            else {
                MessageBox.Show("¡Seleccione un registro!");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgpedidos.SelectedCells.Count > 0)
            {
                string msg = "¿Estas seguro de Eliminar " + textdni.Text + "?";

                DialogResult r = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (r == DialogResult.OK)
                {
                    bool rpta = empleadoarchivo.eliminar(archivo, textdni.Text);
                    if (rpta == true)
                    {
                        MessageBox.Show("Eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error, no se pudo eliminar");
                    }
                    limpiar();
                    listar();
                    quitarselecionDTG();

                }
            }
        }
    }
}
