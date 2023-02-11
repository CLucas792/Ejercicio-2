namespace Ejercicio_2_CarlosLucas_20191031954
{
    partial class Ejercicio2_CarlosLucasForm
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
            this.components = new System.ComponentModel.Container();
            this.PrimerPtextBox = new System.Windows.Forms.TextBox();
            this.SegundoPtextBox = new System.Windows.Forms.TextBox();
            this.TercerPtextBox = new System.Windows.Forms.TextBox();
            this.CuartoPtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.CalificacionesdataGridView = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrimerPtextBox
            // 
            this.PrimerPtextBox.Location = new System.Drawing.Point(132, 153);
            this.PrimerPtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrimerPtextBox.Name = "PrimerPtextBox";
            this.PrimerPtextBox.Size = new System.Drawing.Size(148, 26);
            this.PrimerPtextBox.TabIndex = 0;
            // 
            // SegundoPtextBox
            // 
            this.SegundoPtextBox.Location = new System.Drawing.Point(431, 153);
            this.SegundoPtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SegundoPtextBox.Name = "SegundoPtextBox";
            this.SegundoPtextBox.Size = new System.Drawing.Size(148, 26);
            this.SegundoPtextBox.TabIndex = 1;
            // 
            // TercerPtextBox
            // 
            this.TercerPtextBox.Location = new System.Drawing.Point(132, 187);
            this.TercerPtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TercerPtextBox.Name = "TercerPtextBox";
            this.TercerPtextBox.Size = new System.Drawing.Size(148, 26);
            this.TercerPtextBox.TabIndex = 2;
            // 
            // CuartoPtextBox
            // 
            this.CuartoPtextBox.Location = new System.Drawing.Point(431, 187);
            this.CuartoPtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CuartoPtextBox.Name = "CuartoPtextBox";
            this.CuartoPtextBox.Size = new System.Drawing.Size(148, 26);
            this.CuartoPtextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculadora de promedio de estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese las calificaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Primer Parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segundo Parcial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tercer Parcial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cuarto Parcial:";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(153, 234);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(345, 33);
            this.Calcularbutton.TabIndex = 10;
            this.Calcularbutton.Text = "Calcular e ingresar";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingrese nombre del estudiante:";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(252, 63);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(288, 26);
            this.NombretextBox.TabIndex = 12;
            // 
            // CalificacionesdataGridView
            // 
            this.CalificacionesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalificacionesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Calificacion1,
            this.Calificacion2,
            this.Calificacion3,
            this.Calificacion4,
            this.Promedio});
            this.CalificacionesdataGridView.Location = new System.Drawing.Point(1, 273);
            this.CalificacionesdataGridView.Name = "CalificacionesdataGridView";
            this.CalificacionesdataGridView.Size = new System.Drawing.Size(593, 173);
            this.CalificacionesdataGridView.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 175;
            // 
            // Calificacion1
            // 
            this.Calificacion1.HeaderText = "Calificacion 1";
            this.Calificacion1.Name = "Calificacion1";
            this.Calificacion1.Width = 75;
            // 
            // Calificacion2
            // 
            this.Calificacion2.HeaderText = "Calificacion 2";
            this.Calificacion2.Name = "Calificacion2";
            this.Calificacion2.Width = 75;
            // 
            // Calificacion3
            // 
            this.Calificacion3.HeaderText = "Calificacion 3";
            this.Calificacion3.Name = "Calificacion3";
            this.Calificacion3.Width = 75;
            // 
            // Calificacion4
            // 
            this.Calificacion4.HeaderText = "Calificacion 4";
            this.Calificacion4.Name = "Calificacion4";
            this.Calificacion4.Width = 75;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.Width = 75;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio2_CarlosLucasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 444);
            this.Controls.Add(this.CalificacionesdataGridView);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuartoPtextBox);
            this.Controls.Add(this.TercerPtextBox);
            this.Controls.Add(this.SegundoPtextBox);
            this.Controls.Add(this.PrimerPtextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejercicio2_CarlosLucasForm";
            this.Text = "Ejercicio2_CarlosLucas";
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrimerPtextBox;
        private System.Windows.Forms.TextBox SegundoPtextBox;
        private System.Windows.Forms.TextBox TercerPtextBox;
        private System.Windows.Forms.TextBox CuartoPtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.DataGridView CalificacionesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

