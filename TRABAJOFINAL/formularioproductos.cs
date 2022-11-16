using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRABAJOFINAL
{
    public partial class formularioproductos : Form
    {
        int cantidad;

       

      
        public formularioproductos()
        {


            InitializeComponent();
          //  ventana1 = ventana;

           
        }

        private void btnlisto_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1(int.Parse(textboxcantidad.Text));

            if (textboxcantidad.Text=="")
            {


            }
            else
            {
                if (textboxcantidad.Text.Trim() == "")
                {
                    errorform1.SetError(textboxcantidad, "No deje campos en blanco");
                    textboxcantidad.Focus();
                    return;
                }
                errorform1.SetError(textboxcantidad, "");

                int cantidad_;
                if (!int.TryParse(textboxcantidad.Text, out cantidad_))
                {
                    errorform1.SetError(textboxcantidad, "Ingrese solo numeros enteros");
                    textboxcantidad.Focus();
                    return;
                }
                errorform1.SetError(textboxcantidad, "");

                

                ventana1.lblcantidad.Text = textboxcantidad.Text;

                ventana1.Show();
                this.Hide();

            }

           

        }

        private void formularioproductos_Load(object sender, EventArgs e)
        {

            
        }

        private void formularioproductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
