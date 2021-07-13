
namespace Tarea1
{
    partial class Tutor_detalles
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
            this.lbid_tutor = new System.Windows.Forms.Label();
            this.lbnombres = new System.Windows.Forms.Label();
            this.lbapellido_paterno = new System.Windows.Forms.Label();
            this.lbapellido_materno = new System.Windows.Forms.Label();
            this.lbtitulo_academico = new System.Windows.Forms.Label();
            this.txtId_tutor = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellido_Paterno = new System.Windows.Forms.TextBox();
            this.txtApellido_Materno = new System.Windows.Forms.TextBox();
            this.txtTitulo_Academico = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbid_tutor
            // 
            this.lbid_tutor.AutoSize = true;
            this.lbid_tutor.Location = new System.Drawing.Point(16, 11);
            this.lbid_tutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbid_tutor.Name = "lbid_tutor";
            this.lbid_tutor.Size = new System.Drawing.Size(56, 17);
            this.lbid_tutor.TabIndex = 0;
            this.lbid_tutor.Text = "Id_tutor";
            // 
            // lbnombres
            // 
            this.lbnombres.AutoSize = true;
            this.lbnombres.Location = new System.Drawing.Point(16, 42);
            this.lbnombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombres.Name = "lbnombres";
            this.lbnombres.Size = new System.Drawing.Size(65, 17);
            this.lbnombres.TabIndex = 1;
            this.lbnombres.Text = "Nombres";
            this.lbnombres.Click += new System.EventHandler(this.lbnombres_Click);
            // 
            // lbapellido_paterno
            // 
            this.lbapellido_paterno.AutoSize = true;
            this.lbapellido_paterno.Location = new System.Drawing.Point(16, 78);
            this.lbapellido_paterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbapellido_paterno.Name = "lbapellido_paterno";
            this.lbapellido_paterno.Size = new System.Drawing.Size(112, 17);
            this.lbapellido_paterno.TabIndex = 2;
            this.lbapellido_paterno.Text = "Apellido Paterno";
            // 
            // lbapellido_materno
            // 
            this.lbapellido_materno.AutoSize = true;
            this.lbapellido_materno.Location = new System.Drawing.Point(16, 114);
            this.lbapellido_materno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbapellido_materno.Name = "lbapellido_materno";
            this.lbapellido_materno.Size = new System.Drawing.Size(114, 17);
            this.lbapellido_materno.TabIndex = 3;
            this.lbapellido_materno.Text = "Apellido Materno";
            // 
            // lbtitulo_academico
            // 
            this.lbtitulo_academico.AutoSize = true;
            this.lbtitulo_academico.Location = new System.Drawing.Point(16, 154);
            this.lbtitulo_academico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtitulo_academico.Name = "lbtitulo_academico";
            this.lbtitulo_academico.Size = new System.Drawing.Size(116, 17);
            this.lbtitulo_academico.TabIndex = 4;
            this.lbtitulo_academico.Text = "Titulo Academico";
            // 
            // txtId_tutor
            // 
            this.txtId_tutor.Location = new System.Drawing.Point(140, 7);
            this.txtId_tutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId_tutor.Name = "txtId_tutor";
            this.txtId_tutor.Size = new System.Drawing.Size(345, 22);
            this.txtId_tutor.TabIndex = 5;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(140, 38);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(345, 22);
            this.txtNombres.TabIndex = 6;
            // 
            // txtApellido_Paterno
            // 
            this.txtApellido_Paterno.Location = new System.Drawing.Point(140, 74);
            this.txtApellido_Paterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido_Paterno.Name = "txtApellido_Paterno";
            this.txtApellido_Paterno.Size = new System.Drawing.Size(345, 22);
            this.txtApellido_Paterno.TabIndex = 7;
            // 
            // txtApellido_Materno
            // 
            this.txtApellido_Materno.Location = new System.Drawing.Point(140, 111);
            this.txtApellido_Materno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido_Materno.Name = "txtApellido_Materno";
            this.txtApellido_Materno.Size = new System.Drawing.Size(345, 22);
            this.txtApellido_Materno.TabIndex = 8;
            // 
            // txtTitulo_Academico
            // 
            this.txtTitulo_Academico.Location = new System.Drawing.Point(140, 150);
            this.txtTitulo_Academico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo_Academico.Name = "txtTitulo_Academico";
            this.txtTitulo_Academico.Size = new System.Drawing.Size(345, 22);
            this.txtTitulo_Academico.TabIndex = 9;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(97, 182);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(93, 38);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(313, 182);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 38);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "CANCELA";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // Tutor_detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 235);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtTitulo_Academico);
            this.Controls.Add(this.txtApellido_Materno);
            this.Controls.Add(this.txtApellido_Paterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtId_tutor);
            this.Controls.Add(this.lbtitulo_academico);
            this.Controls.Add(this.lbapellido_materno);
            this.Controls.Add(this.lbapellido_paterno);
            this.Controls.Add(this.lbnombres);
            this.Controls.Add(this.lbid_tutor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tutor_detalles";
            this.Text = "Tutor_detalles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbid_tutor;
        private System.Windows.Forms.Label lbnombres;
        private System.Windows.Forms.Label lbapellido_paterno;
        private System.Windows.Forms.Label lbapellido_materno;
        private System.Windows.Forms.Label lbtitulo_academico;
        private System.Windows.Forms.TextBox txtId_tutor;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellido_Paterno;
        private System.Windows.Forms.TextBox txtApellido_Materno;
        private System.Windows.Forms.TextBox txtTitulo_Academico;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCancelar;
    }
}