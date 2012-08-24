namespace MyProject
{
    partial class Principal1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal1));
            this.Recibo = new System.Windows.Forms.Button();
            this.Transmitidos = new System.Windows.Forms.Button();
            this.entramite = new System.Windows.Forms.Button();
            this.Procesados = new System.Windows.Forms.Button();
            this.enviarrecibir = new System.Windows.Forms.Button();
            this.cambiarOP = new System.Windows.Forms.Button();
            this.busqueda = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeMensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorMMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarMMCComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diccionarioDeErToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmrx = new System.Windows.Forms.Button();
            this.mmtx = new System.Windows.Forms.Button();
            this.borradores = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Recibo
            // 
            this.Recibo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Recibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recibo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Recibo.Location = new System.Drawing.Point(11, 48);
            this.Recibo.Name = "Recibo";
            this.Recibo.Size = new System.Drawing.Size(100, 24);
            this.Recibo.TabIndex = 0;
            this.Recibo.Text = "Recibidos";
            this.Recibo.UseVisualStyleBackColor = false;
            this.Recibo.Click += new System.EventHandler(this.Recibo_Click);
            // 
            // Transmitidos
            // 
            this.Transmitidos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Transmitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transmitidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Transmitidos.Location = new System.Drawing.Point(117, 48);
            this.Transmitidos.Name = "Transmitidos";
            this.Transmitidos.Size = new System.Drawing.Size(100, 24);
            this.Transmitidos.TabIndex = 1;
            this.Transmitidos.Text = "Transmitidos";
            this.Transmitidos.UseVisualStyleBackColor = false;
            // 
            // entramite
            // 
            this.entramite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.entramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entramite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entramite.Location = new System.Drawing.Point(223, 48);
            this.entramite.Name = "entramite";
            this.entramite.Size = new System.Drawing.Size(100, 24);
            this.entramite.TabIndex = 2;
            this.entramite.Text = "En Tramite";
            this.entramite.UseVisualStyleBackColor = false;
            // 
            // Procesados
            // 
            this.Procesados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Procesados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Procesados.Location = new System.Drawing.Point(329, 48);
            this.Procesados.Name = "Procesados";
            this.Procesados.Size = new System.Drawing.Size(100, 24);
            this.Procesados.TabIndex = 3;
            this.Procesados.Text = "Procesados";
            this.Procesados.UseVisualStyleBackColor = false;
            // 
            // enviarrecibir
            // 
            this.enviarrecibir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.enviarrecibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarrecibir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enviarrecibir.Location = new System.Drawing.Point(435, 48);
            this.enviarrecibir.Name = "enviarrecibir";
            this.enviarrecibir.Size = new System.Drawing.Size(100, 24);
            this.enviarrecibir.TabIndex = 4;
            this.enviarrecibir.Text = "Enviar/Recibir";
            this.enviarrecibir.UseVisualStyleBackColor = false;
            this.enviarrecibir.Click += new System.EventHandler(this.enviarrecibir_Click);
            // 
            // cambiarOP
            // 
            this.cambiarOP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cambiarOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarOP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cambiarOP.Location = new System.Drawing.Point(541, 48);
            this.cambiarOP.Name = "cambiarOP";
            this.cambiarOP.Size = new System.Drawing.Size(100, 24);
            this.cambiarOP.TabIndex = 5;
            this.cambiarOP.Text = "Cambiar OP";
            this.cambiarOP.UseVisualStyleBackColor = false;
            this.cambiarOP.Click += new System.EventHandler(this.cambiarOP_Click);
            // 
            // busqueda
            // 
            this.busqueda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busqueda.Location = new System.Drawing.Point(647, 48);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(100, 24);
            this.busqueda.TabIndex = 6;
            this.busqueda.Text = "Busqueda";
            this.busqueda.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensajesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mensajesToolStripMenuItem
            // 
            this.mensajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorDeMensajesToolStripMenuItem,
            this.editorMMCToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mensajesToolStripMenuItem.Name = "mensajesToolStripMenuItem";
            this.mensajesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.mensajesToolStripMenuItem.Text = "Mensajes";
            // 
            // administradorDeMensajesToolStripMenuItem
            // 
            this.administradorDeMensajesToolStripMenuItem.Name = "administradorDeMensajesToolStripMenuItem";
            this.administradorDeMensajesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.administradorDeMensajesToolStripMenuItem.Text = "Administrador de Mensajes";
            this.administradorDeMensajesToolStripMenuItem.Click += new System.EventHandler(this.administradorDeMensajesToolStripMenuItem_Click);
            // 
            // editorMMCToolStripMenuItem
            // 
            this.editorMMCToolStripMenuItem.Name = "editorMMCToolStripMenuItem";
            this.editorMMCToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.editorMMCToolStripMenuItem.Text = "Editor MMC";
            this.editorMMCToolStripMenuItem.Click += new System.EventHandler(this.editorMMCToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // enviarToolStripMenuItem
            // 
            this.enviarToolStripMenuItem.Name = "enviarToolStripMenuItem";
            this.enviarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.enviarToolStripMenuItem.Text = "Enviar y Recibir";
            this.enviarToolStripMenuItem.Click += new System.EventHandler(this.enviarToolStripMenuItem_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarTurnoToolStripMenuItem});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // cambiarTurnoToolStripMenuItem
            // 
            this.cambiarTurnoToolStripMenuItem.Name = "cambiarTurnoToolStripMenuItem";
            this.cambiarTurnoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cambiarTurnoToolStripMenuItem.Text = "Cambiar Turno";
            this.cambiarTurnoToolStripMenuItem.Click += new System.EventHandler(this.cambiarTurnoToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarMMCComoToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // guardarMMCComoToolStripMenuItem
            // 
            this.guardarMMCComoToolStripMenuItem.Name = "guardarMMCComoToolStripMenuItem";
            this.guardarMMCComoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.guardarMMCComoToolStripMenuItem.Text = "Guardar MMC como...";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteTécnicoToolStripMenuItem,
            this.diccionarioDeErToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte Técnico";
            this.soporteTécnicoToolStripMenuItem.Click += new System.EventHandler(this.soporteTécnicoToolStripMenuItem_Click);
            // 
            // diccionarioDeErToolStripMenuItem
            // 
            this.diccionarioDeErToolStripMenuItem.Name = "diccionarioDeErToolStripMenuItem";
            this.diccionarioDeErToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.diccionarioDeErToolStripMenuItem.Text = "Diccionario de Errores";
            // 
            // mmrx
            // 
            this.mmrx.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mmrx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmrx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mmrx.Location = new System.Drawing.Point(10, 88);
            this.mmrx.Name = "mmrx";
            this.mmrx.Size = new System.Drawing.Size(109, 24);
            this.mmrx.TabIndex = 8;
            this.mmrx.Text = "MM RX";
            this.mmrx.UseVisualStyleBackColor = false;
            // 
            // mmtx
            // 
            this.mmtx.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mmtx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmtx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mmtx.Location = new System.Drawing.Point(10, 118);
            this.mmtx.Name = "mmtx";
            this.mmtx.Size = new System.Drawing.Size(109, 24);
            this.mmtx.TabIndex = 9;
            this.mmtx.Text = "MM TX";
            this.mmtx.UseVisualStyleBackColor = false;
            // 
            // borradores
            // 
            this.borradores.BackColor = System.Drawing.SystemColors.HotTrack;
            this.borradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borradores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borradores.Location = new System.Drawing.Point(10, 148);
            this.borradores.Name = "borradores";
            this.borradores.Size = new System.Drawing.Size(109, 24);
            this.borradores.TabIndex = 10;
            this.borradores.Text = "BORRADORES";
            this.borradores.UseVisualStyleBackColor = false;
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editor.Location = new System.Drawing.Point(10, 178);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(109, 24);
            this.editor.TabIndex = 11;
            this.editor.Text = "EDITOR MMC";
            this.editor.UseVisualStyleBackColor = false;
            this.editor.Click += new System.EventHandler(this.editor_Click);
            // 
            // archivo
            // 
            this.archivo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archivo.Location = new System.Drawing.Point(10, 208);
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(109, 24);
            this.archivo.TabIndex = 12;
            this.archivo.Text = "ARCHIVO";
            this.archivo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Principal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.Controls.Add(this.archivo);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.borradores);
            this.Controls.Add(this.mmtx);
            this.Controls.Add(this.mmrx);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.cambiarOP);
            this.Controls.Add(this.enviarrecibir);
            this.Controls.Add(this.Procesados);
            this.Controls.Add(this.entramite);
            this.Controls.Add(this.Transmitidos);
            this.Controls.Add(this.Recibo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Informatico de Transmision de Mensajes v2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Recibo;
        private System.Windows.Forms.Button Transmitidos;
        private System.Windows.Forms.Button entramite;
        private System.Windows.Forms.Button Procesados;
        private System.Windows.Forms.Button enviarrecibir;
        private System.Windows.Forms.Button cambiarOP;
        private System.Windows.Forms.Button busqueda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mensajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button mmrx;
        private System.Windows.Forms.Button mmtx;
        private System.Windows.Forms.Button borradores;
        private System.Windows.Forms.Button editor;
        private System.Windows.Forms.Button archivo;
        private System.Windows.Forms.ToolStripMenuItem editorMMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarMMCComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diccionarioDeErToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem administradorDeMensajesToolStripMenuItem;
    }
}