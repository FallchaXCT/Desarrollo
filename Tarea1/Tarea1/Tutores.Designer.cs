
namespace Tarea1
{
    partial class Tutores
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
            this.components = new System.ComponentModel.Container();
            this.gridTutor = new System.Windows.Forms.DataGridView();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btagregar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idtutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloAcademicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTutor
            // 
            this.gridTutor.AutoGenerateColumns = false;
            this.gridTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtutorDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.tituloAcademicoDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.gridTutor.DataSource = this.tutorBindingSource;
            this.gridTutor.Location = new System.Drawing.Point(22, 38);
            this.gridTutor.Name = "gridTutor";
            this.gridTutor.Size = new System.Drawing.Size(742, 217);
            this.gridTutor.TabIndex = 0;
            this.gridTutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTutor_CellContentClick);
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Location = new System.Drawing.Point(19, 9);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(51, 13);
            this.lbbuscar.TabIndex = 1;
            this.lbbuscar.Text = "BUSCAR";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(76, 6);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(516, 20);
            this.txtbusqueda.TabIndex = 2;
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(598, 4);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(80, 22);
            this.btbuscar.TabIndex = 3;
            this.btbuscar.Text = "BUSCAR";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btagregar
            // 
            this.btagregar.Location = new System.Drawing.Point(684, 4);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(80, 22);
            this.btagregar.TabIndex = 4;
            this.btagregar.Text = "AGREGAR";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // idtutorDataGridViewTextBoxColumn
            // 
            this.idtutorDataGridViewTextBoxColumn.DataPropertyName = "Id_tutor";
            this.idtutorDataGridViewTextBoxColumn.HeaderText = "Id_tutor";
            this.idtutorDataGridViewTextBoxColumn.Name = "idtutorDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Paterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "Apellido_Paterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Materno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "Apellido_Materno";
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            // 
            // tituloAcademicoDataGridViewTextBoxColumn
            // 
            this.tituloAcademicoDataGridViewTextBoxColumn.DataPropertyName = "Titulo_Academico";
            this.tituloAcademicoDataGridViewTextBoxColumn.HeaderText = "Titulo_Academico";
            this.tituloAcademicoDataGridViewTextBoxColumn.Name = "tituloAcademicoDataGridViewTextBoxColumn";
            // 
            // tutorBindingSource
            // 
            this.tutorBindingSource.DataSource = typeof(Tarea1.Tutor);
            // 
            // Tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 267);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.gridTutor);
            this.Name = "Tutores";
            this.Text = "Tutores";
            this.Load += new System.EventHandler(this.Tutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTutor;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.BindingSource tutorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloAcademicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}

