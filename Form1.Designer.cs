
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreLogging = new System.Windows.Forms.TextBox();
            this.correoLogging = new System.Windows.Forms.TextBox();
            this.irRegistro = new System.Windows.Forms.LinkLabel();
            this.botonInicioSesion = new System.Windows.Forms.Button();
            this.labelNombreLogging = new System.Windows.Forms.Label();
            this.labelPasswordLogging = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreLogging
            // 
            this.nombreLogging.Location = new System.Drawing.Point(282, 98);
            this.nombreLogging.Name = "nombreLogging";
            this.nombreLogging.Size = new System.Drawing.Size(211, 22);
            this.nombreLogging.TabIndex = 0;
            this.nombreLogging.TextChanged += new System.EventHandler(this.nombreLogging_TextChanged);
            // 
            // correoLogging
            // 
            this.correoLogging.Location = new System.Drawing.Point(282, 196);
            this.correoLogging.Name = "correoLogging";
            this.correoLogging.Size = new System.Drawing.Size(211, 22);
            this.correoLogging.TabIndex = 1;
            this.correoLogging.TextChanged += new System.EventHandler(this.correoLogging_TextChanged);
            // 
            // irRegistro
            // 
            this.irRegistro.AutoSize = true;
            this.irRegistro.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irRegistro.Location = new System.Drawing.Point(278, 232);
            this.irRegistro.Name = "irRegistro";
            this.irRegistro.Size = new System.Drawing.Size(112, 24);
            this.irRegistro.TabIndex = 2;
            this.irRegistro.TabStop = true;
            this.irRegistro.Text = "Crear cuenta";
            this.irRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.irRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // botonInicioSesion
            // 
            this.botonInicioSesion.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInicioSesion.Location = new System.Drawing.Point(306, 335);
            this.botonInicioSesion.Name = "botonInicioSesion";
            this.botonInicioSesion.Size = new System.Drawing.Size(161, 37);
            this.botonInicioSesion.TabIndex = 3;
            this.botonInicioSesion.Text = "INICIAR SESIÓN";
            this.botonInicioSesion.UseVisualStyleBackColor = true;
            this.botonInicioSesion.Click += new System.EventHandler(this.botonInicioSesion_Click);
            // 
            // labelNombreLogging
            // 
            this.labelNombreLogging.AutoSize = true;
            this.labelNombreLogging.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreLogging.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombreLogging.Location = new System.Drawing.Point(278, 63);
            this.labelNombreLogging.Name = "labelNombreLogging";
            this.labelNombreLogging.Size = new System.Drawing.Size(147, 21);
            this.labelNombreLogging.TabIndex = 4;
            this.labelNombreLogging.Text = "Nombre de usuario";
            // 
            // labelPasswordLogging
            // 
            this.labelPasswordLogging.AutoSize = true;
            this.labelPasswordLogging.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLogging.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPasswordLogging.Location = new System.Drawing.Point(278, 172);
            this.labelPasswordLogging.Name = "labelPasswordLogging";
            this.labelPasswordLogging.Size = new System.Drawing.Size(88, 21);
            this.labelPasswordLogging.TabIndex = 5;
            this.labelPasswordLogging.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPasswordLogging);
            this.Controls.Add(this.labelNombreLogging);
            this.Controls.Add(this.botonInicioSesion);
            this.Controls.Add(this.irRegistro);
            this.Controls.Add(this.correoLogging);
            this.Controls.Add(this.nombreLogging);
            this.Name = "Form1";
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreLogging;
        private System.Windows.Forms.TextBox correoLogging;
        private System.Windows.Forms.LinkLabel irRegistro;
        private System.Windows.Forms.Button botonInicioSesion;
        private System.Windows.Forms.Label labelNombreLogging;
        private System.Windows.Forms.Label labelPasswordLogging;
    }
}

