namespace Examen1_Topicos_P23130577
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            CURP = new DataGridViewTextBoxColumn();
            EDAD = new DataGridViewTextBoxColumn();
            SEXO = new DataGridViewTextBoxColumn();
            PROM = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abirToolStripMenuItem = new ToolStripMenuItem();
            oFDCURP = new OpenFileDialog();
            abrirElArchivoAdjuntoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CURP, EDAD, SEXO, PROM });
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(863, 402);
            dataGridView1.TabIndex = 0;
            // 
            // CURP
            // 
            CURP.HeaderText = "CURP";
            CURP.MinimumWidth = 8;
            CURP.Name = "CURP";
            CURP.Width = 350;
            // 
            // EDAD
            // 
            EDAD.HeaderText = "Edad";
            EDAD.MinimumWidth = 8;
            EDAD.Name = "EDAD";
            EDAD.Width = 150;
            // 
            // SEXO
            // 
            SEXO.HeaderText = "Sexo";
            SEXO.MinimumWidth = 8;
            SEXO.Name = "SEXO";
            SEXO.Width = 150;
            // 
            // PROM
            // 
            PROM.HeaderText = "Promedio";
            PROM.MinimumWidth = 8;
            PROM.Name = "PROM";
            PROM.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(887, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abirToolStripMenuItem, abrirElArchivoAdjuntoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abirToolStripMenuItem
            // 
            abirToolStripMenuItem.Name = "abirToolStripMenuItem";
            abirToolStripMenuItem.Size = new Size(305, 34);
            abirToolStripMenuItem.Text = "Abrir";
            abirToolStripMenuItem.Click += abirToolStripMenuItem_Click;
            // 
            // oFDCURP
            // 
            oFDCURP.FileName = "openFileDialog1";
            // 
            // abrirElArchivoAdjuntoToolStripMenuItem
            // 
            abrirElArchivoAdjuntoToolStripMenuItem.Name = "abrirElArchivoAdjuntoToolStripMenuItem";
            abrirElArchivoAdjuntoToolStripMenuItem.Size = new Size(305, 34);
            abrirElArchivoAdjuntoToolStripMenuItem.Text = "Abrir el Archivo Adjunto";
            abrirElArchivoAdjuntoToolStripMenuItem.Click += abrirElArchivoAdjuntoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CURP;
        private DataGridViewTextBoxColumn EDAD;
        private DataGridViewTextBoxColumn SEXO;
        private DataGridViewTextBoxColumn PROM;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abirToolStripMenuItem;
        private OpenFileDialog oFDCURP;
        private ToolStripMenuItem abrirElArchivoAdjuntoToolStripMenuItem;
    }
}
