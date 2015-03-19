namespace insertar_productos
{
    partial class Iniciomedico
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
            this.leer_Tarjetamed = new System.Windows.Forms.Button();
            this.txt_buscarp = new System.Windows.Forms.TextBox();
            this.btn_buscarp = new System.Windows.Forms.Button();
            this.btn_actualizarp = new System.Windows.Forms.Button();
            this.btn_eliminarp = new System.Windows.Forms.Button();
            this.dtg_visualizarp = new System.Windows.Forms.DataGridView();
            this.Agregar_paciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizarp)).BeginInit();
            this.SuspendLayout();
            // 
            // leer_Tarjetamed
            // 
            this.leer_Tarjetamed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.leer_Tarjetamed.FlatAppearance.BorderSize = 0;
            this.leer_Tarjetamed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.leer_Tarjetamed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leer_Tarjetamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leer_Tarjetamed.Location = new System.Drawing.Point(12, 12);
            this.leer_Tarjetamed.Name = "leer_Tarjetamed";
            this.leer_Tarjetamed.Size = new System.Drawing.Size(89, 22);
            this.leer_Tarjetamed.TabIndex = 0;
            this.leer_Tarjetamed.Text = "Leer tarjeta";
            this.leer_Tarjetamed.UseVisualStyleBackColor = false;
            // 
            // txt_buscarp
            // 
            this.txt_buscarp.Location = new System.Drawing.Point(40, 57);
            this.txt_buscarp.Name = "txt_buscarp";
            this.txt_buscarp.Size = new System.Drawing.Size(135, 20);
            this.txt_buscarp.TabIndex = 10;
            // 
            // btn_buscarp
            // 
            this.btn_buscarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_buscarp.FlatAppearance.BorderSize = 0;
            this.btn_buscarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buscarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarp.Location = new System.Drawing.Point(198, 55);
            this.btn_buscarp.Name = "btn_buscarp";
            this.btn_buscarp.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarp.TabIndex = 9;
            this.btn_buscarp.Text = "Buscar";
            this.btn_buscarp.UseVisualStyleBackColor = false;
            this.btn_buscarp.Click += new System.EventHandler(this.btn_buscarp_Click);
            // 
            // btn_actualizarp
            // 
            this.btn_actualizarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_actualizarp.FlatAppearance.BorderSize = 0;
            this.btn_actualizarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_actualizarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarp.Location = new System.Drawing.Point(367, 329);
            this.btn_actualizarp.Name = "btn_actualizarp";
            this.btn_actualizarp.Size = new System.Drawing.Size(174, 23);
            this.btn_actualizarp.TabIndex = 8;
            this.btn_actualizarp.Text = "Habilitar o Inhabilitar";
            this.btn_actualizarp.UseVisualStyleBackColor = false;
            // 
            // btn_eliminarp
            // 
            this.btn_eliminarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_eliminarp.FlatAppearance.BorderSize = 0;
            this.btn_eliminarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_eliminarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarp.Location = new System.Drawing.Point(212, 329);
            this.btn_eliminarp.Name = "btn_eliminarp";
            this.btn_eliminarp.Size = new System.Drawing.Size(111, 23);
            this.btn_eliminarp.TabIndex = 7;
            this.btn_eliminarp.Text = "Eliminar";
            this.btn_eliminarp.UseVisualStyleBackColor = false;
            this.btn_eliminarp.Click += new System.EventHandler(this.btn_eliminarp_Click);
            // 
            // dtg_visualizarp
            // 
            this.dtg_visualizarp.AllowUserToAddRows = false;
            this.dtg_visualizarp.AllowUserToDeleteRows = false;
            this.dtg_visualizarp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_visualizarp.Location = new System.Drawing.Point(21, 107);
            this.dtg_visualizarp.Name = "dtg_visualizarp";
            this.dtg_visualizarp.ReadOnly = true;
            this.dtg_visualizarp.Size = new System.Drawing.Size(641, 215);
            this.dtg_visualizarp.TabIndex = 6;
            this.dtg_visualizarp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_visualizarp_CellClick);
            // 
            // Agregar_paciente
            // 
            this.Agregar_paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Agregar_paciente.FlatAppearance.BorderSize = 0;
            this.Agregar_paciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Agregar_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_paciente.Location = new System.Drawing.Point(523, 22);
            this.Agregar_paciente.Name = "Agregar_paciente";
            this.Agregar_paciente.Size = new System.Drawing.Size(127, 27);
            this.Agregar_paciente.TabIndex = 11;
            this.Agregar_paciente.Text = "Agregar Paciente";
            this.Agregar_paciente.UseVisualStyleBackColor = false;
            this.Agregar_paciente.Click += new System.EventHandler(this.Agregar_paciente_Click);
            // 
            // Iniciomedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(682, 364);
            this.Controls.Add(this.Agregar_paciente);
            this.Controls.Add(this.txt_buscarp);
            this.Controls.Add(this.btn_buscarp);
            this.Controls.Add(this.btn_actualizarp);
            this.Controls.Add(this.btn_eliminarp);
            this.Controls.Add(this.dtg_visualizarp);
            this.Controls.Add(this.leer_Tarjetamed);
            this.Name = "Iniciomedico";
            this.Text = "Iniciomedico";
            this.Load += new System.EventHandler(this.Iniciomedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizarp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leer_Tarjetamed;
        private System.Windows.Forms.TextBox txt_buscarp;
        private System.Windows.Forms.Button btn_buscarp;
        private System.Windows.Forms.Button btn_actualizarp;
        private System.Windows.Forms.Button btn_eliminarp;
        private System.Windows.Forms.DataGridView dtg_visualizarp;
        private System.Windows.Forms.Button Agregar_paciente;
    }
}