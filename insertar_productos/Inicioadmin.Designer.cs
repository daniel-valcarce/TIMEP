namespace insertar_productos
{
    partial class Inicioadmin
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
            this.dtg_visualizaru = new System.Windows.Forms.DataGridView();
            this.btn_eliminaru = new System.Windows.Forms.Button();
            this.btn_actualizaru = new System.Windows.Forms.Button();
            this.Agregar_Usuario = new System.Windows.Forms.Button();
            this.btn_buscaru = new System.Windows.Forms.Button();
            this.txt_buscaru = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizaru)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_visualizaru
            // 
            this.dtg_visualizaru.AllowUserToAddRows = false;
            this.dtg_visualizaru.AllowUserToDeleteRows = false;
            this.dtg_visualizaru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_visualizaru.Location = new System.Drawing.Point(60, 78);
            this.dtg_visualizaru.Name = "dtg_visualizaru";
            this.dtg_visualizaru.ReadOnly = true;
            this.dtg_visualizaru.Size = new System.Drawing.Size(641, 215);
            this.dtg_visualizaru.TabIndex = 0;
            this.dtg_visualizaru.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_visualizaru_CellContentClick);
            // 
            // btn_eliminaru
            // 
            this.btn_eliminaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_eliminaru.FlatAppearance.BorderSize = 0;
            this.btn_eliminaru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_eliminaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminaru.Location = new System.Drawing.Point(241, 300);
            this.btn_eliminaru.Name = "btn_eliminaru";
            this.btn_eliminaru.Size = new System.Drawing.Size(98, 26);
            this.btn_eliminaru.TabIndex = 1;
            this.btn_eliminaru.Text = "Eliminar";
            this.btn_eliminaru.UseVisualStyleBackColor = false;
            this.btn_eliminaru.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizaru
            // 
            this.btn_actualizaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_actualizaru.FlatAppearance.BorderSize = 0;
            this.btn_actualizaru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_actualizaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizaru.Location = new System.Drawing.Point(371, 300);
            this.btn_actualizaru.Name = "btn_actualizaru";
            this.btn_actualizaru.Size = new System.Drawing.Size(184, 26);
            this.btn_actualizaru.TabIndex = 2;
            this.btn_actualizaru.Text = "Habilitar o inhabilitar";
            this.btn_actualizaru.UseVisualStyleBackColor = false;
            // 
            // Agregar_Usuario
            // 
            this.Agregar_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Agregar_Usuario.FlatAppearance.BorderSize = 0;
            this.Agregar_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Agregar_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_Usuario.Location = new System.Drawing.Point(399, 28);
            this.Agregar_Usuario.Name = "Agregar_Usuario";
            this.Agregar_Usuario.Size = new System.Drawing.Size(102, 28);
            this.Agregar_Usuario.TabIndex = 3;
            this.Agregar_Usuario.Text = "agregar nuevo";
            this.Agregar_Usuario.UseVisualStyleBackColor = false;
            this.Agregar_Usuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscaru
            // 
            this.btn_buscaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_buscaru.FlatAppearance.BorderSize = 0;
            this.btn_buscaru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_buscaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscaru.Location = new System.Drawing.Point(264, 26);
            this.btn_buscaru.Name = "btn_buscaru";
            this.btn_buscaru.Size = new System.Drawing.Size(99, 25);
            this.btn_buscaru.TabIndex = 4;
            this.btn_buscaru.Text = "Buscar";
            this.btn_buscaru.UseVisualStyleBackColor = false;
            this.btn_buscaru.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_buscaru
            // 
            this.txt_buscaru.Location = new System.Drawing.Point(114, 28);
            this.txt_buscaru.Name = "txt_buscaru";
            this.txt_buscaru.Size = new System.Drawing.Size(135, 20);
            this.txt_buscaru.TabIndex = 5;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(583, 300);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(98, 26);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // Inicioadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(769, 356);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_buscaru);
            this.Controls.Add(this.btn_buscaru);
            this.Controls.Add(this.Agregar_Usuario);
            this.Controls.Add(this.btn_actualizaru);
            this.Controls.Add(this.btn_eliminaru);
            this.Controls.Add(this.dtg_visualizaru);
            this.Name = "Inicioadmin";
            this.Text = "Inicio Administrador  De Sistema";
            this.EnabledChanged += new System.EventHandler(this.Inicioadmin_EnabledChanged);
            this.DoubleClick += new System.EventHandler(this.Inicioadmin_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizaru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_visualizaru;
        private System.Windows.Forms.Button btn_eliminaru;
        private System.Windows.Forms.Button btn_actualizaru;
        private System.Windows.Forms.Button Agregar_Usuario;
        private System.Windows.Forms.Button btn_buscaru;
        private System.Windows.Forms.TextBox txt_buscaru;
        private System.Windows.Forms.Button btn_editar;
    }
}