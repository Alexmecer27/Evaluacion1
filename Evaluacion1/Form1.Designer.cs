using System;

namespace Evaluacion1
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
            this.panelrecetas = new System.Windows.Forms.Panel();
            this.buttonAgregarReceta = new System.Windows.Forms.Button();
            this.listRecetas = new System.Windows.Forms.ListBox();
            this.labelRecetas = new System.Windows.Forms.Label();
            this.panelIngredientes = new System.Windows.Forms.Panel();
            this.buttonIngredientes = new System.Windows.Forms.Button();
            this.listIngreduentes = new System.Windows.Forms.ListBox();
            this.labelIngredientes = new System.Windows.Forms.Label();
            this.panelrecetas.SuspendLayout();
            this.panelIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelrecetas
            // 
            this.panelrecetas.Controls.Add(this.buttonAgregarReceta);
            this.panelrecetas.Controls.Add(this.listRecetas);
            this.panelrecetas.Controls.Add(this.labelRecetas);
            this.panelrecetas.Location = new System.Drawing.Point(10, 10);
            this.panelrecetas.Name = "panelrecetas";
            this.panelrecetas.Size = new System.Drawing.Size(300, 200);
            this.panelrecetas.TabIndex = 0;
            // 
            // buttonAgregarReceta
            // 
            this.buttonAgregarReceta.Location = new System.Drawing.Point(10, 177);
            this.buttonAgregarReceta.Name = "buttonAgregarReceta";
            this.buttonAgregarReceta.Size = new System.Drawing.Size(142, 23);
            this.buttonAgregarReceta.TabIndex = 1;
            this.buttonAgregarReceta.Text = "Agregar Receta";
            this.buttonAgregarReceta.UseVisualStyleBackColor = true;
            // 
            // listRecetas
            // 
            this.listRecetas.FormattingEnabled = true;
            this.listRecetas.ItemHeight = 16;
            this.listRecetas.Location = new System.Drawing.Point(10, 30);
            this.listRecetas.Name = "listRecetas";
            this.listRecetas.Size = new System.Drawing.Size(280, 148);
            this.listRecetas.TabIndex = 1;
            this.listRecetas.SelectedIndexChanged += new System.EventHandler(this.listBoxRecetas_SelectedIndexChanged);
            // 
            // labelRecetas
            // 
            this.labelRecetas.AutoSize = true;
            this.labelRecetas.Location = new System.Drawing.Point(10, 10);
            this.labelRecetas.Name = "labelRecetas";
            this.labelRecetas.Size = new System.Drawing.Size(58, 16);
            this.labelRecetas.TabIndex = 0;
            this.labelRecetas.Text = "Recetas";
            // 
            // panelIngredientes
            // 
            this.panelIngredientes.Controls.Add(this.buttonIngredientes);
            this.panelIngredientes.Controls.Add(this.listIngreduentes);
            this.panelIngredientes.Controls.Add(this.labelIngredientes);
            this.panelIngredientes.Location = new System.Drawing.Point(320, 10);
            this.panelIngredientes.Name = "panelIngredientes";
            this.panelIngredientes.Size = new System.Drawing.Size(300, 200);
            this.panelIngredientes.TabIndex = 1;
            // 
            // buttonIngredientes
            // 
            this.buttonIngredientes.Location = new System.Drawing.Point(10, 177);
            this.buttonIngredientes.Name = "buttonIngredientes";
            this.buttonIngredientes.Size = new System.Drawing.Size(152, 23);
            this.buttonIngredientes.TabIndex = 2;
            this.buttonIngredientes.Text = "Agregar ingredientes";
            this.buttonIngredientes.UseVisualStyleBackColor = true;
            // 
            // listIngreduentes
            // 
            this.listIngreduentes.FormattingEnabled = true;
            this.listIngreduentes.ItemHeight = 16;
            this.listIngreduentes.Location = new System.Drawing.Point(10, 30);
            this.listIngreduentes.Name = "listIngreduentes";
            this.listIngreduentes.Size = new System.Drawing.Size(280, 148);
            this.listIngreduentes.TabIndex = 1;
            this.listIngreduentes.SelectedIndexChanged += new System.EventHandler(this.listIngreduentes_SelectedIndexChanged);
            // 
            // labelIngredientes
            // 
            this.labelIngredientes.AutoSize = true;
            this.labelIngredientes.Location = new System.Drawing.Point(10, 10);
            this.labelIngredientes.Name = "labelIngredientes";
            this.labelIngredientes.Size = new System.Drawing.Size(81, 16);
            this.labelIngredientes.TabIndex = 0;
            this.labelIngredientes.Text = "Ingredientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 470);
            this.Controls.Add(this.panelrecetas);
            this.Controls.Add(this.panelIngredientes);
            this.Name = "Form1";
            this.Text = "Gestión de Recetas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelrecetas.ResumeLayout(false);
            this.panelrecetas.PerformLayout();
            this.panelIngredientes.ResumeLayout(false);
            this.panelIngredientes.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listIngreduentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listBoxRecetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelrecetas;
        private System.Windows.Forms.Label labelRecetas;
        private System.Windows.Forms.ListBox listRecetas;
        private System.Windows.Forms.Button buttonAgregarReceta;
        private System.Windows.Forms.Panel panelIngredientes;
        private System.Windows.Forms.Label labelIngredientes;
        private System.Windows.Forms.ListBox listIngreduentes;
        private System.Windows.Forms.Button buttonIngredientes;
    }
}
                                                 
