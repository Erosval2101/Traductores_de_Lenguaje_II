namespace analizadorLexico
{
    partial class Principal
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
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtResLexico = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtErroresLexico = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSintactico = new System.Windows.Forms.DataGridView();
            this.Pila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintactico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpresion
            // 
            this.txtExpresion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpresion.Location = new System.Drawing.Point(12, 44);
            this.txtExpresion.Multiline = true;
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExpresion.Size = new System.Drawing.Size(721, 330);
            this.txtExpresion.TabIndex = 0;
            this.txtExpresion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpresion_KeyPress);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(12, 17);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(177, 24);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingrese expresión";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.Location = new System.Drawing.Point(757, 124);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(138, 55);
            this.btnAnalizar.TabIndex = 2;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtResLexico
            // 
            this.txtResLexico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResLexico.Location = new System.Drawing.Point(10, 409);
            this.txtResLexico.Multiline = true;
            this.txtResLexico.Name = "txtResLexico";
            this.txtResLexico.ReadOnly = true;
            this.txtResLexico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResLexico.Size = new System.Drawing.Size(266, 201);
            this.txtResLexico.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(757, 206);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 55);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtErroresLexico
            // 
            this.txtErroresLexico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErroresLexico.Location = new System.Drawing.Point(282, 409);
            this.txtErroresLexico.Multiline = true;
            this.txtErroresLexico.Name = "txtErroresLexico";
            this.txtErroresLexico.ReadOnly = true;
            this.txtErroresLexico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErroresLexico.Size = new System.Drawing.Size(264, 201);
            this.txtErroresLexico.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(10, 384);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(159, 22);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Analizador Léxico";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.Location = new System.Drawing.Point(278, 384);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(73, 22);
            this.lblErrores.TabIndex = 8;
            this.lblErrores.Text = "Errores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Analizador Sintáctico";
            // 
            // dgvSintactico
            // 
            this.dgvSintactico.AllowUserToAddRows = false;
            this.dgvSintactico.AllowUserToDeleteRows = false;
            this.dgvSintactico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSintactico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pila,
            this.Salida});
            this.dgvSintactico.Location = new System.Drawing.Point(553, 409);
            this.dgvSintactico.Name = "dgvSintactico";
            this.dgvSintactico.RowHeadersWidth = 50;
            this.dgvSintactico.Size = new System.Drawing.Size(333, 201);
            this.dgvSintactico.TabIndex = 12;
            // 
            // Pila
            // 
            this.Pila.HeaderText = "Pila";
            this.Pila.Name = "Pila";
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 634);
            this.Controls.Add(this.dgvSintactico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtErroresLexico);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResLexico);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.txtExpresion);
            this.Name = "Principal";
            this.Text = "Compilador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintactico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtResLexico;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtErroresLexico;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSintactico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
    }
}

