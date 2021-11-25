
namespace Integrador.Windows
{
    partial class FrmPrincipal
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.CantidadRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraHerramientasToolStrip = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.cuadranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BordesToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AscXRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescXRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPáginasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colNombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.BarraHerramientasToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CantidadRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 581);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 11;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreLibro,
            this.colAutor,
            this.colEditorial,
            this.colTema,
            this.colPaginas});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1136, 455);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // CantidadRegistrosLabel
            // 
            this.CantidadRegistrosLabel.AutoSize = true;
            this.CantidadRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRegistrosLabel.Location = new System.Drawing.Point(142, 25);
            this.CantidadRegistrosLabel.Name = "CantidadRegistrosLabel";
            this.CantidadRegistrosLabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadRegistrosLabel.TabIndex = 0;
            this.CantidadRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // BarraHerramientasToolStrip
            // 
            this.BarraHerramientasToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.OrdenarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.BarraHerramientasToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientasToolStrip.Name = "BarraHerramientasToolStrip";
            this.BarraHerramientasToolStrip.Size = new System.Drawing.Size(1136, 58);
            this.BarraHerramientasToolStrip.TabIndex = 10;
            this.BarraHerramientasToolStrip.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::Integrador.Windows.Properties.Resources.add_file_36px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::Integrador.Windows.Properties.Resources.delete_file_36px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::Integrador.Windows.Properties.Resources.create_36px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadranteToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.FiltrarToolStripButton.Image = global::Integrador.Windows.Properties.Resources.conversion_36px;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(50, 55);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cuadranteToolStripMenuItem
            // 
            this.cuadranteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BordesToolStripComboBox});
            this.cuadranteToolStripMenuItem.Name = "cuadranteToolStripMenuItem";
            this.cuadranteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cuadranteToolStripMenuItem.Text = "Editorial";
            // 
            // BordesToolStripComboBox
            // 
            this.BordesToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BordesToolStripComboBox.Name = "BordesToolStripComboBox";
            this.BordesToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AscXRadioToolStripMenuItem,
            this.DescXRadioToolStripMenuItem,
            this.porPáginasToolStripMenuItem});
            this.OrdenarToolStripButton.Image = global::Integrador.Windows.Properties.Resources.up_down_arrow_36px;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AscXRadioToolStripMenuItem
            // 
            this.AscXRadioToolStripMenuItem.Name = "AscXRadioToolStripMenuItem";
            this.AscXRadioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AscXRadioToolStripMenuItem.Text = "Alfabético A-Z";
            // 
            // DescXRadioToolStripMenuItem
            // 
            this.DescXRadioToolStripMenuItem.Name = "DescXRadioToolStripMenuItem";
            this.DescXRadioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.DescXRadioToolStripMenuItem.Text = "Alfabético Z-A";
            // 
            // porPáginasToolStripMenuItem
            // 
            this.porPáginasToolStripMenuItem.Name = "porPáginasToolStripMenuItem";
            this.porPáginasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.porPáginasToolStripMenuItem.Text = "Por Páginas";
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::Integrador.Windows.Properties.Resources.restart_36px;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = global::Integrador.Windows.Properties.Resources.close_pane_36px;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // colNombreLibro
            // 
            this.colNombreLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreLibro.HeaderText = "Nombre Libro";
            this.colNombreLibro.Name = "colNombreLibro";
            this.colNombreLibro.ReadOnly = true;
            this.colNombreLibro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAutor
            // 
            this.colAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            this.colAutor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEditorial
            // 
            this.colEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEditorial.HeaderText = "Editorial";
            this.colEditorial.Name = "colEditorial";
            this.colEditorial.ReadOnly = true;
            this.colEditorial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTema
            // 
            this.colTema.HeaderText = "Tema";
            this.colTema.Name = "colTema";
            this.colTema.ReadOnly = true;
            // 
            // colPaginas
            // 
            this.colPaginas.HeaderText = "Páginas";
            this.colPaginas.Name = "colPaginas";
            this.colPaginas.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BarraHerramientasToolStrip);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Prinicipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.BarraHerramientasToolStrip.ResumeLayout(false);
            this.BarraHerramientasToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Label CantidadRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip BarraHerramientasToolStrip;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem cuadranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox BordesToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem AscXRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescXRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPáginasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaginas;
    }
}

