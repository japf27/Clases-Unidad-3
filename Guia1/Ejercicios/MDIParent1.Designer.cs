namespace Ejercicios
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem,
            this.ejercicio2ToolStripMenuItem,
            this.ejercicio3ToolStripMenuItem,
            this.ejercicio4ToolStripMenuItem,
            this.ejercicio5ToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios Guia";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio1ToolStripMenuItem.Text = "Ejercicio1";
            this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio1ToolStripMenuItem_Click);
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio2ToolStripMenuItem.Text = "Ejercicio2";
            this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio2ToolStripMenuItem_Click);
            // 
            // ejercicio3ToolStripMenuItem
            // 
            this.ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
            this.ejercicio3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio3ToolStripMenuItem.Text = "Ejercicio3";
            this.ejercicio3ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio3ToolStripMenuItem_Click);
            // 
            // ejercicio4ToolStripMenuItem
            // 
            this.ejercicio4ToolStripMenuItem.Name = "ejercicio4ToolStripMenuItem";
            this.ejercicio4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio4ToolStripMenuItem.Text = "Ejercicio4";
            this.ejercicio4ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio4ToolStripMenuItem_Click);
            // 
            // ejercicio5ToolStripMenuItem
            // 
            this.ejercicio5ToolStripMenuItem.Name = "ejercicio5ToolStripMenuItem";
            this.ejercicio5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio5ToolStripMenuItem.Text = "Ejercicio5";
            this.ejercicio5ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio5ToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "Guia 1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem;
    }
}



