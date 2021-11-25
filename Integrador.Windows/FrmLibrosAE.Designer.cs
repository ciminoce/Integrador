
namespace Integrador.Windows
{
    partial class FrmLibrosAE
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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.TemaComboBox = new System.Windows.Forms.ComboBox();
            this.EditorialComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreLibroTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AutorTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RadioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::Integrador.Windows.Properties.Resources.Cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(534, 214);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(79, 57);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Image = global::Integrador.Windows.Properties.Resources.Guardar;
            this.OkButton.Location = new System.Drawing.Point(63, 214);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(79, 57);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // TemaComboBox
            // 
            this.TemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemaComboBox.FormattingEnabled = true;
            this.TemaComboBox.Location = new System.Drawing.Point(492, 116);
            this.TemaComboBox.Name = "TemaComboBox";
            this.TemaComboBox.Size = new System.Drawing.Size(121, 21);
            this.TemaComboBox.TabIndex = 4;
            // 
            // EditorialComboBox
            // 
            this.EditorialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorialComboBox.FormattingEnabled = true;
            this.EditorialComboBox.Location = new System.Drawing.Point(149, 116);
            this.EditorialComboBox.Name = "EditorialComboBox";
            this.EditorialComboBox.Size = new System.Drawing.Size(162, 21);
            this.EditorialComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tema:";
            // 
            // RadioNumericUpDown
            // 
            this.RadioNumericUpDown.Location = new System.Drawing.Point(149, 153);
            this.RadioNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.RadioNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RadioNumericUpDown.Name = "RadioNumericUpDown";
            this.RadioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RadioNumericUpDown.TabIndex = 5;
            this.RadioNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Editorial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Páginas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ISBN:";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(149, 28);
            this.ISBNTextBox.MaxLength = 13;
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(162, 20);
            this.ISBNTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre Libro:";
            // 
            // NombreLibroTextBox
            // 
            this.NombreLibroTextBox.Location = new System.Drawing.Point(149, 54);
            this.NombreLibroTextBox.MaxLength = 256;
            this.NombreLibroTextBox.Name = "NombreLibroTextBox";
            this.NombreLibroTextBox.Size = new System.Drawing.Size(464, 20);
            this.NombreLibroTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Autor:";
            // 
            // AutorTextBox
            // 
            this.AutorTextBox.Location = new System.Drawing.Point(149, 80);
            this.AutorTextBox.MaxLength = 256;
            this.AutorTextBox.Name = "AutorTextBox";
            this.AutorTextBox.Size = new System.Drawing.Size(464, 20);
            this.AutorTextBox.TabIndex = 2;
            // 
            // FrmLibrosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 288);
            this.ControlBox = false;
            this.Controls.Add(this.AutorTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NombreLibroTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TemaComboBox);
            this.Controls.Add(this.EditorialComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadioNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(682, 327);
            this.MinimumSize = new System.Drawing.Size(682, 327);
            this.Name = "FrmLibrosAE";
            this.Text = "FrmLibrosAE";
            ((System.ComponentModel.ISupportInitialize)(this.RadioNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox TemaComboBox;
        private System.Windows.Forms.ComboBox EditorialComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RadioNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreLibroTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AutorTextBox;
    }
}