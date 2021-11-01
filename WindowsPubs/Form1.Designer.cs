
namespace WindowsPubs
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
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            this.btnTraerAutorPorId = new System.Windows.Forms.Button();
            this.btnTraerTodosAutoresPorCiudad = new System.Windows.Forms.Button();
            this.btnTraerTodosPublicadores = new System.Windows.Forms.Button();
            this.btnTraerPublicadorPorNombre = new System.Windows.Forms.Button();
            this.gridPublicaciones = new System.Windows.Forms.DataGridView();
            this.btnSalesStores = new System.Windows.Forms.Button();
            this.btnEmployeePublisher = new System.Windows.Forms.Button();
            this.btnFiltrarPorPais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(12, 12);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(109, 50);
            this.btnTraerTodosAutores.TabIndex = 0;
            this.btnTraerTodosAutores.Text = " Traer todos los autores";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // btnTraerAutorPorId
            // 
            this.btnTraerAutorPorId.Location = new System.Drawing.Point(427, 12);
            this.btnTraerAutorPorId.Name = "btnTraerAutorPorId";
            this.btnTraerAutorPorId.Size = new System.Drawing.Size(137, 50);
            this.btnTraerAutorPorId.TabIndex = 1;
            this.btnTraerAutorPorId.Text = "Traer un Autor por su Id";
            this.btnTraerAutorPorId.UseVisualStyleBackColor = true;
            this.btnTraerAutorPorId.Click += new System.EventHandler(this.btnTraerAutorPorId_Click);
            // 
            // btnTraerTodosAutoresPorCiudad
            // 
            this.btnTraerTodosAutoresPorCiudad.Location = new System.Drawing.Point(276, 12);
            this.btnTraerTodosAutoresPorCiudad.Name = "btnTraerTodosAutoresPorCiudad";
            this.btnTraerTodosAutoresPorCiudad.Size = new System.Drawing.Size(145, 50);
            this.btnTraerTodosAutoresPorCiudad.TabIndex = 2;
            this.btnTraerTodosAutoresPorCiudad.Text = "Traer todos los autores que viven en la misma ciudad";
            this.btnTraerTodosAutoresPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutoresPorCiudad.Click += new System.EventHandler(this.btnTraerTodosAutoresPorCiudad_Click);
            // 
            // btnTraerTodosPublicadores
            // 
            this.btnTraerTodosPublicadores.Location = new System.Drawing.Point(127, 12);
            this.btnTraerTodosPublicadores.Name = "btnTraerTodosPublicadores";
            this.btnTraerTodosPublicadores.Size = new System.Drawing.Size(143, 50);
            this.btnTraerTodosPublicadores.TabIndex = 3;
            this.btnTraerTodosPublicadores.Text = "Traer todos los publicadores";
            this.btnTraerTodosPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerTodosPublicadores.Click += new System.EventHandler(this.btnTraerTodosPublicadores_Click);
            // 
            // btnTraerPublicadorPorNombre
            // 
            this.btnTraerPublicadorPorNombre.Location = new System.Drawing.Point(570, 11);
            this.btnTraerPublicadorPorNombre.Name = "btnTraerPublicadorPorNombre";
            this.btnTraerPublicadorPorNombre.Size = new System.Drawing.Size(119, 51);
            this.btnTraerPublicadorPorNombre.TabIndex = 4;
            this.btnTraerPublicadorPorNombre.Text = "Traer un Publicador por su Nombre";
            this.btnTraerPublicadorPorNombre.UseVisualStyleBackColor = true;
            this.btnTraerPublicadorPorNombre.Click += new System.EventHandler(this.btnTraerPublicadorPorNombre_Click);
            // 
            // gridPublicaciones
            // 
            this.gridPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublicaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPublicaciones.Location = new System.Drawing.Point(0, 138);
            this.gridPublicaciones.Name = "gridPublicaciones";
            this.gridPublicaciones.Size = new System.Drawing.Size(921, 388);
            this.gridPublicaciones.TabIndex = 5;
            // 
            // btnSalesStores
            // 
            this.btnSalesStores.Location = new System.Drawing.Point(695, 12);
            this.btnSalesStores.Name = "btnSalesStores";
            this.btnSalesStores.Size = new System.Drawing.Size(214, 50);
            this.btnSalesStores.TabIndex = 6;
            this.btnSalesStores.Text = "Mostrar una lista (Id, NombreTienda, Ciudad, NroOrden, fecha, Cantidad y IdTitulo" +
    ") Usar las entidades: sales y stores";
            this.btnSalesStores.UseVisualStyleBackColor = true;
            this.btnSalesStores.Click += new System.EventHandler(this.btnSalesStores_Click);
            // 
            // btnEmployeePublisher
            // 
            this.btnEmployeePublisher.Location = new System.Drawing.Point(12, 68);
            this.btnEmployeePublisher.Name = "btnEmployeePublisher";
            this.btnEmployeePublisher.Size = new System.Drawing.Size(128, 64);
            this.btnEmployeePublisher.TabIndex = 7;
            this.btnEmployeePublisher.Text = "Mostrar una lista(Nombre, apellido, nombre del publicador)";
            this.btnEmployeePublisher.UseVisualStyleBackColor = true;
            this.btnEmployeePublisher.Click += new System.EventHandler(this.btnEmployeePublisher_Click);
            // 
            // btnFiltrarPorPais
            // 
            this.btnFiltrarPorPais.Location = new System.Drawing.Point(146, 68);
            this.btnFiltrarPorPais.Name = "btnFiltrarPorPais";
            this.btnFiltrarPorPais.Size = new System.Drawing.Size(124, 64);
            this.btnFiltrarPorPais.TabIndex = 8;
            this.btnFiltrarPorPais.Text = "Filtrar empleados por país";
            this.btnFiltrarPorPais.UseVisualStyleBackColor = true;
            this.btnFiltrarPorPais.Click += new System.EventHandler(this.btnFiltrarPorPais_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 526);
            this.Controls.Add(this.btnFiltrarPorPais);
            this.Controls.Add(this.btnEmployeePublisher);
            this.Controls.Add(this.btnSalesStores);
            this.Controls.Add(this.gridPublicaciones);
            this.Controls.Add(this.btnTraerPublicadorPorNombre);
            this.Controls.Add(this.btnTraerTodosPublicadores);
            this.Controls.Add(this.btnTraerTodosAutoresPorCiudad);
            this.Controls.Add(this.btnTraerAutorPorId);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosAutores;
        private System.Windows.Forms.Button btnTraerAutorPorId;
        private System.Windows.Forms.Button btnTraerTodosAutoresPorCiudad;
        private System.Windows.Forms.Button btnTraerTodosPublicadores;
        private System.Windows.Forms.Button btnTraerPublicadorPorNombre;
        private System.Windows.Forms.DataGridView gridPublicaciones;
        private System.Windows.Forms.Button btnSalesStores;
        private System.Windows.Forms.Button btnEmployeePublisher;
        private System.Windows.Forms.Button btnFiltrarPorPais;
    }
}

