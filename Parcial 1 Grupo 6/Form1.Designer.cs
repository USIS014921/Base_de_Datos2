
namespace Parcial_1_Grupo_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.resistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOfertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOfertasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verOfertasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verOfertasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resistenciasToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.ayudaToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.consultasToolStripMenuItem.Text = "Acerca De";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Electronic Components: Somos lo mejores en distribucion de componentes electronic" +
    "os.";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOfertasToolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 20);
            this.toolStripMenuItem1.Text = "Transistores.";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOfertasToolStripMenuItem2});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 20);
            this.toolStripMenuItem2.Text = "Circuitos Integrados.";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOfertasToolStripMenuItem1});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItem3.Text = "Capacitores.";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // resistenciasToolStripMenuItem
            // 
            this.resistenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOfertasToolStripMenuItem});
            this.resistenciasToolStripMenuItem.Name = "resistenciasToolStripMenuItem";
            this.resistenciasToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.resistenciasToolStripMenuItem.Text = "Resistencias.";
            this.resistenciasToolStripMenuItem.Click += new System.EventHandler(this.resistenciasToolStripMenuItem_Click_1);
            // 
            // verOfertasToolStripMenuItem
            // 
            this.verOfertasToolStripMenuItem.Name = "verOfertasToolStripMenuItem";
            this.verOfertasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verOfertasToolStripMenuItem.Text = "Ver Ofertas";
            this.verOfertasToolStripMenuItem.Click += new System.EventHandler(this.verOfertasToolStripMenuItem_Click);
            // 
            // verOfertasToolStripMenuItem1
            // 
            this.verOfertasToolStripMenuItem1.Name = "verOfertasToolStripMenuItem1";
            this.verOfertasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.verOfertasToolStripMenuItem1.Text = "Ver Ofertas";
            this.verOfertasToolStripMenuItem1.Click += new System.EventHandler(this.verOfertasToolStripMenuItem1_Click);
            // 
            // verOfertasToolStripMenuItem2
            // 
            this.verOfertasToolStripMenuItem2.Name = "verOfertasToolStripMenuItem2";
            this.verOfertasToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.verOfertasToolStripMenuItem2.Text = "Ver Ofertas";
            this.verOfertasToolStripMenuItem2.Click += new System.EventHandler(this.verOfertasToolStripMenuItem2_Click);
            // 
            // verOfertasToolStripMenuItem3
            // 
            this.verOfertasToolStripMenuItem3.Name = "verOfertasToolStripMenuItem3";
            this.verOfertasToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.verOfertasToolStripMenuItem3.Text = "Ver Ofertas";
            this.verOfertasToolStripMenuItem3.Click += new System.EventHandler(this.verOfertasToolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Electronic Components";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem resistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOfertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOfertasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verOfertasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verOfertasToolStripMenuItem3;
    }
}

