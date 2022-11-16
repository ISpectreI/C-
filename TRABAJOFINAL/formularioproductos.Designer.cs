
namespace TRABAJOFINAL
{
    partial class formularioproductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioproductos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxcantidad = new System.Windows.Forms.TextBox();
            this.btnlisto = new System.Windows.Forms.Button();
            this.errorform1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorform1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRABAJOFINAL.Properties.Resources.bidonesagua;
            this.pictureBox1.Location = new System.Drawing.Point(2, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la cantidad de productos hoy";
            // 
            // textboxcantidad
            // 
            this.textboxcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxcantidad.Location = new System.Drawing.Point(265, 99);
            this.textboxcantidad.Name = "textboxcantidad";
            this.textboxcantidad.Size = new System.Drawing.Size(203, 31);
            this.textboxcantidad.TabIndex = 2;
            // 
            // btnlisto
            // 
            this.btnlisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlisto.Location = new System.Drawing.Point(314, 160);
            this.btnlisto.Name = "btnlisto";
            this.btnlisto.Size = new System.Drawing.Size(102, 39);
            this.btnlisto.TabIndex = 3;
            this.btnlisto.Text = "Ok";
            this.btnlisto.UseVisualStyleBackColor = true;
            this.btnlisto.Click += new System.EventHandler(this.btnlisto_Click);
            // 
            // errorform1
            // 
            this.errorform1.ContainerControl = this;
            // 
            // formularioproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 217);
            this.Controls.Add(this.btnlisto);
            this.Controls.Add(this.textboxcantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formularioproductos";
            this.Text = "Cantidad de Hoy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formularioproductos_FormClosing);
            this.Load += new System.EventHandler(this.formularioproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorform1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxcantidad;
        private System.Windows.Forms.Button btnlisto;
        private System.Windows.Forms.ErrorProvider errorform1;
    }
}