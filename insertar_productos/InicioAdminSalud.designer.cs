namespace insertar_productos
{
    partial class Inicioadmisalud
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
            this.Agregar_paciente = new System.Windows.Forms.Button();
            this.txt_buscarp = new System.Windows.Forms.TextBox();
            this.btn_buscarp = new System.Windows.Forms.Button();
            this.btn_actualizarp = new System.Windows.Forms.Button();
            this.btn_eliminarp = new System.Windows.Forms.Button();
            this.dtg_visualizarp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizarp)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar_paciente
            // 
            this.Agregar_paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Agregar_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_paciente.Location = new System.Drawing.Point(382, 33);
            this.Agregar_paciente.Name = "Agregar_paciente";
            this.Agregar_paciente.Size = new System.Drawing.Size(102, 28);
            this.Agregar_paciente.TabIndex = 23;
            this.Agregar_paciente.Text = "Agregar";
            this.Agregar_paciente.UseVisualStyleBackColor = false;
            this.Agregar_paciente.Click += new System.EventHandler(this.Agregar_paciente_Click_1);
            // 
            // txt_buscarp
            // 
            this.txt_buscarp.Location = new System.Drawing.Point(108, 37);
            this.txt_buscarp.Name = "txt_buscarp";
            this.txt_buscarp.Size = new System.Drawing.Size(135, 20);
            this.txt_buscarp.TabIndex = 22;
            // 
            // btn_buscarp
            // 
            this.btn_buscarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_buscarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_buscarp.Location = new System.Drawing.Point(266, 35);
            this.btn_buscarp.Name = "btn_buscarp";
            this.btn_buscarp.Size = new System.Drawing.Size(99, 25);
            this.btn_buscarp.TabIndex = 21;
            this.btn_buscarp.Text = "Buscar";
            this.btn_buscarp.UseVisualStyleBackColor = false;
            this.btn_buscarp.Click += new System.EventHandler(this.btn_buscarp_Click_1);
            // 
            // btn_actualizarp
            // 
            this.btn_actualizarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_actualizarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_actualizarp.Location = new System.Drawing.Point(328, 322);
            this.btn_actualizarp.Name = "btn_actualizarp";
            this.btn_actualizarp.Size = new System.Drawing.Size(184, 26);
            this.btn_actualizarp.TabIndex = 20;
            this.btn_actualizarp.Text = "Habilitar o inhabilitar";
            this.btn_actualizarp.UseVisualStyleBackColor = false;
            // 
            // btn_eliminarp
            // 
            this.btn_eliminarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_eliminarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_eliminarp.Location = new System.Drawing.Point(201, 322);
            this.btn_eliminarp.Name = "btn_eliminarp";
            this.btn_eliminarp.Size = new System.Drawing.Size(98, 26);
            this.btn_eliminarp.TabIndex = 19;
            this.btn_eliminarp.Text = "Eliminar";
            this.btn_eliminarp.UseVisualStyleBackColor = false;
            this.btn_eliminarp.Click += new System.EventHandler(this.btn_eliminarp_Click_1);
            // 
            // dtg_visualizarp
            // 
            this.dtg_visualizarp.AllowUserToAddRows = false;
            this.dtg_visualizarp.AllowUserToDeleteRows = false;
            this.dtg_visualizarp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_visualizarp.Location = new System.Drawing.Point(29, 89);
            this.dtg_visualizarp.Name = "dtg_visualizarp";
            this.dtg_visualizarp.ReadOnly = true;
            this.dtg_visualizarp.Size = new System.Drawing.Size(641, 215);
            this.dtg_visualizarp.TabIndex = 18;
            // 
            // Inicioadmisalud
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
            this.Name = "Inicioadmisalud";
            this.Text = "Inicio AdminDe Salud";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizarp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar_paciente;
        private System.Windows.Forms.TextBox txt_buscarp;
        private System.Windows.Forms.Button btn_buscarp;
        private System.Windows.Forms.Button btn_actualizarp;
        private System.Windows.Forms.Button btn_eliminarp;
        private System.Windows.Forms.DataGridView dtg_visualizarp;

    }
}