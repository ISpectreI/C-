
namespace TRABAJOFINAL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textusuario = new System.Windows.Forms.TextBox();
            this.textcontraseña = new System.Windows.Forms.TextBox();
            this.btninicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(148, 100);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(100, 20);
            this.textusuario.TabIndex = 0;
            // 
            // textcontraseña
            // 
            this.textcontraseña.Location = new System.Drawing.Point(148, 149);
            this.textcontraseña.Name = "textcontraseña";
            this.textcontraseña.PasswordChar = '*';
            this.textcontraseña.Size = new System.Drawing.Size(100, 20);
            this.textcontraseña.TabIndex = 1;
            this.textcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcontraseña_KeyPress);
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(129, 195);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(133, 23);
            this.btninicio.TabIndex = 2;
            this.btninicio.Text = "Iniciar Sesión";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.button1_Click);
            this.btninicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btninicio_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRABAJOFINAL.Properties.Resources.login_1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 249);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.textcontraseña);
            this.Controls.Add(this.textusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textcontraseña;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}