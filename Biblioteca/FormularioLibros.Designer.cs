namespace Biblioteca
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
            this.button1 = new System.Windows.Forms.Button();
            this.autor = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.editorial = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.nomenclatura = new System.Windows.Forms.TextBox();
            this.num_pag = new System.Windows.Forms.TextBox();
            this.year_publi = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autor
            // 
            this.autor.Location = new System.Drawing.Point(62, 171);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(188, 22);
            this.autor.TabIndex = 1;
            this.autor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(293, 171);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(188, 22);
            this.nombre.TabIndex = 2;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(534, 171);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(188, 22);
            this.cantidad.TabIndex = 3;
            // 
            // editorial
            // 
            this.editorial.Location = new System.Drawing.Point(62, 249);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(188, 22);
            this.editorial.TabIndex = 4;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(293, 249);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(188, 22);
            this.estado.TabIndex = 5;
            // 
            // nomenclatura
            // 
            this.nomenclatura.Location = new System.Drawing.Point(537, 249);
            this.nomenclatura.Name = "nomenclatura";
            this.nomenclatura.Size = new System.Drawing.Size(188, 22);
            this.nomenclatura.TabIndex = 6;
            // 
            // num_pag
            // 
            this.num_pag.Location = new System.Drawing.Point(62, 326);
            this.num_pag.Name = "num_pag";
            this.num_pag.Size = new System.Drawing.Size(188, 22);
            this.num_pag.TabIndex = 7;
            // 
            // year_publi
            // 
            this.year_publi.Location = new System.Drawing.Point(293, 326);
            this.year_publi.Name = "year_publi";
            this.year_publi.Size = new System.Drawing.Size(188, 22);
            this.year_publi.TabIndex = 8;
            // 
            // genero
            // 
            this.genero.Location = new System.Drawing.Point(537, 326);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(188, 22);
            this.genero.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nomenclatura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Numero Paginas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Año de Publicacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Genero";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label10.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(190, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(407, 47);
            this.label10.TabIndex = 0;
            this.label10.Text = "Registro de Libros";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.year_publi);
            this.Controls.Add(this.num_pag);
            this.Controls.Add(this.nomenclatura);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox autor;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox editorial;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox nomenclatura;
        private System.Windows.Forms.TextBox num_pag;
        private System.Windows.Forms.TextBox year_publi;
        private System.Windows.Forms.TextBox genero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}

