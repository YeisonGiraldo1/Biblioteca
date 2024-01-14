namespace Biblioteca
{
    partial class PanelLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelLibros));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_listadolibros = new System.Windows.Forms.Button();
            this.btn_registrolibros = new System.Windows.Forms.Button();
            this.btn_libros = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.PanelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoPrincipal)).BeginInit();
            this.PanelFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Controls.Add(this.btn_libros);
            this.PanelPrincipal.Controls.Add(this.PanelLogo);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(230, 748);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_listadolibros);
            this.panel1.Controls.Add(this.btn_registrolibros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 145);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_listadolibros
            // 
            this.btn_listadolibros.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btn_listadolibros.AllowDrop = true;
            this.btn_listadolibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_listadolibros.FlatAppearance.BorderSize = 0;
            this.btn_listadolibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listadolibros.ForeColor = System.Drawing.Color.White;
            this.btn_listadolibros.Location = new System.Drawing.Point(0, 50);
            this.btn_listadolibros.Name = "btn_listadolibros";
            this.btn_listadolibros.Size = new System.Drawing.Size(230, 50);
            this.btn_listadolibros.TabIndex = 1;
            this.btn_listadolibros.Text = "Listado de Libros";
            this.btn_listadolibros.UseVisualStyleBackColor = true;
            this.btn_listadolibros.Click += new System.EventHandler(this.btn_listadolibros_Click);
            // 
            // btn_registrolibros
            // 
            this.btn_registrolibros.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btn_registrolibros.AllowDrop = true;
            this.btn_registrolibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registrolibros.FlatAppearance.BorderSize = 0;
            this.btn_registrolibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrolibros.ForeColor = System.Drawing.Color.White;
            this.btn_registrolibros.Location = new System.Drawing.Point(0, 0);
            this.btn_registrolibros.Name = "btn_registrolibros";
            this.btn_registrolibros.Size = new System.Drawing.Size(230, 50);
            this.btn_registrolibros.TabIndex = 0;
            this.btn_registrolibros.Text = "Registro de Libros";
            this.btn_registrolibros.UseVisualStyleBackColor = true;
            this.btn_registrolibros.Click += new System.EventHandler(this.btn_registrolibros_Click);
            // 
            // btn_libros
            // 
            this.btn_libros.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btn_libros.AllowDrop = true;
            this.btn_libros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_libros.FlatAppearance.BorderSize = 0;
            this.btn_libros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_libros.ForeColor = System.Drawing.Color.White;
            this.btn_libros.Location = new System.Drawing.Point(0, 120);
            this.btn_libros.Name = "btn_libros";
            this.btn_libros.Size = new System.Drawing.Size(230, 50);
            this.btn_libros.TabIndex = 1;
            this.btn_libros.Text = "Gestión de Libros";
            this.btn_libros.UseVisualStyleBackColor = true;
            this.btn_libros.Click += new System.EventHandler(this.btn_libros_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(230, 120);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PictureLogoPrincipal
            // 
            this.PictureLogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogoPrincipal.Image")));
            this.PictureLogoPrincipal.Location = new System.Drawing.Point(253, 143);
            this.PictureLogoPrincipal.Name = "PictureLogoPrincipal";
            this.PictureLogoPrincipal.Size = new System.Drawing.Size(398, 322);
            this.PictureLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogoPrincipal.TabIndex = 0;
            this.PictureLogoPrincipal.TabStop = false;
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.Controls.Add(this.PictureLogoPrincipal);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(230, 0);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(956, 748);
            this.PanelFormularios.TabIndex = 1;
            // 
            // PanelLibros
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 748);
            this.Controls.Add(this.PanelFormularios);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "PanelLibros";
            this.Text = "MenuPirincipal";
            this.PanelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoPrincipal)).EndInit();
            this.PanelFormularios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox PictureLogoPrincipal;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button btn_libros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_registrolibros;
        private System.Windows.Forms.Button btn_listadolibros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelFormularios;
    }
}