
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.nombreRegistro = new System.Windows.Forms.TextBox();
            this.contrasenaRegistro = new System.Windows.Forms.TextBox();
            this.correoRegistro = new System.Windows.Forms.TextBox();
            this.confirmarContrasena = new System.Windows.Forms.TextBox();
            this.botonRegistro = new System.Windows.Forms.Button();
            this.labelNombreRegistro = new System.Windows.Forms.Label();
            this.labelCorreoRegistro = new System.Windows.Forms.Label();
            this.labelContrasenaRegistro = new System.Windows.Forms.Label();
            this.labelConfirmarRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreRegistro
            // 
            this.nombreRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreRegistro.Location = new System.Drawing.Point(280, 77);
            this.nombreRegistro.Name = "nombreRegistro";
            this.nombreRegistro.Size = new System.Drawing.Size(226, 22);
            this.nombreRegistro.TabIndex = 0;
            // 
            // contrasenaRegistro
            // 
            this.contrasenaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contrasenaRegistro.Location = new System.Drawing.Point(280, 218);
            this.contrasenaRegistro.Name = "contrasenaRegistro";
            this.contrasenaRegistro.Size = new System.Drawing.Size(226, 22);
            this.contrasenaRegistro.TabIndex = 1;
            // 
            // correoRegistro
            // 
            this.correoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.correoRegistro.Location = new System.Drawing.Point(280, 145);
            this.correoRegistro.Name = "correoRegistro";
            this.correoRegistro.Size = new System.Drawing.Size(226, 22);
            this.correoRegistro.TabIndex = 2;
            // 
            // confirmarContrasena
            // 
            this.confirmarContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmarContrasena.Location = new System.Drawing.Point(280, 293);
            this.confirmarContrasena.Name = "confirmarContrasena";
            this.confirmarContrasena.Size = new System.Drawing.Size(226, 22);
            this.confirmarContrasena.TabIndex = 3;
            // 
            // botonRegistro
            // 
            this.botonRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRegistro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistro.Location = new System.Drawing.Point(328, 350);
            this.botonRegistro.Name = "botonRegistro";
            this.botonRegistro.Size = new System.Drawing.Size(127, 46);
            this.botonRegistro.TabIndex = 4;
            this.botonRegistro.Text = "REGISTRARSE";
            this.botonRegistro.UseVisualStyleBackColor = true;
            this.botonRegistro.Click += new System.EventHandler(this.botonRegistro_Click);
            // 
            // labelNombreRegistro
            // 
            this.labelNombreRegistro.AutoSize = true;
            this.labelNombreRegistro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombreRegistro.Location = new System.Drawing.Point(280, 54);
            this.labelNombreRegistro.Name = "labelNombreRegistro";
            this.labelNombreRegistro.Size = new System.Drawing.Size(147, 21);
            this.labelNombreRegistro.TabIndex = 5;
            this.labelNombreRegistro.Text = "Nombre de usuario";
            this.labelNombreRegistro.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCorreoRegistro
            // 
            this.labelCorreoRegistro.AutoSize = true;
            this.labelCorreoRegistro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCorreoRegistro.Location = new System.Drawing.Point(280, 121);
            this.labelCorreoRegistro.Name = "labelCorreoRegistro";
            this.labelCorreoRegistro.Size = new System.Drawing.Size(57, 21);
            this.labelCorreoRegistro.TabIndex = 6;
            this.labelCorreoRegistro.Text = "Correo";
            // 
            // labelContrasenaRegistro
            // 
            this.labelContrasenaRegistro.AutoSize = true;
            this.labelContrasenaRegistro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenaRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelContrasenaRegistro.Location = new System.Drawing.Point(280, 194);
            this.labelContrasenaRegistro.Name = "labelContrasenaRegistro";
            this.labelContrasenaRegistro.Size = new System.Drawing.Size(88, 21);
            this.labelContrasenaRegistro.TabIndex = 7;
            this.labelContrasenaRegistro.Text = "Contraseña";
            // 
            // labelConfirmarRegistro
            // 
            this.labelConfirmarRegistro.AutoSize = true;
            this.labelConfirmarRegistro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelConfirmarRegistro.Location = new System.Drawing.Point(280, 269);
            this.labelConfirmarRegistro.Name = "labelConfirmarRegistro";
            this.labelConfirmarRegistro.Size = new System.Drawing.Size(165, 21);
            this.labelConfirmarRegistro.TabIndex = 8;
            this.labelConfirmarRegistro.Text = "Confirmar contraseña";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelConfirmarRegistro);
            this.Controls.Add(this.labelContrasenaRegistro);
            this.Controls.Add(this.labelCorreoRegistro);
            this.Controls.Add(this.labelNombreRegistro);
            this.Controls.Add(this.botonRegistro);
            this.Controls.Add(this.confirmarContrasena);
            this.Controls.Add(this.correoRegistro);
            this.Controls.Add(this.contrasenaRegistro);
            this.Controls.Add(this.nombreRegistro);
            this.Name = "Form2";
            this.Text = "Registro de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreRegistro;
        private System.Windows.Forms.TextBox contrasenaRegistro;
        private System.Windows.Forms.TextBox correoRegistro;
        private System.Windows.Forms.TextBox confirmarContrasena;
        private System.Windows.Forms.Button botonRegistro;
        private System.Windows.Forms.Label labelNombreRegistro;
        private System.Windows.Forms.Label labelCorreoRegistro;
        private System.Windows.Forms.Label labelContrasenaRegistro;
        private System.Windows.Forms.Label labelConfirmarRegistro;
    }
}