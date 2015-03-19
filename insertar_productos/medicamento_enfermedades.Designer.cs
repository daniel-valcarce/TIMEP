namespace insertar_productos
{
    partial class medicamento_enfermedades
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
            this.txt_enferm = new System.Windows.Forms.TextBox();
            this.pn_enfer = new System.Windows.Forms.Panel();
            this.lstb_resul_bus_enfer = new System.Windows.Forms.ListBox();
            this.lbl_nomb_enfer = new System.Windows.Forms.Label();
            this.lbl_enfermedades = new System.Windows.Forms.Label();
            this.pn_medica = new System.Windows.Forms.Panel();
            this.lstb_resul_bus_medic = new System.Windows.Forms.ListBox();
            this.lbl_nomb_med = new System.Windows.Forms.Label();
            this.txt_medicam = new System.Windows.Forms.TextBox();
            this.lbl_medicamentos = new System.Windows.Forms.Label();
            this.lstb_enfer_selec = new System.Windows.Forms.ListBox();
            this.lstb_medic_selec = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.mc_enferm = new System.Windows.Forms.MonthCalendar();
            this.btn_cancel_enfer = new System.Windows.Forms.Button();
            this.btn_guar_fech = new System.Windows.Forms.Button();
            this.lbl_titu_mont_cal = new System.Windows.Forms.Label();
            this.pn_botones = new System.Windows.Forms.Panel();
            this.pn_enfer.SuspendLayout();
            this.pn_medica.SuspendLayout();
            this.pn_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_enferm
            // 
            this.txt_enferm.Location = new System.Drawing.Point(218, 58);
            this.txt_enferm.Name = "txt_enferm";
            this.txt_enferm.Size = new System.Drawing.Size(185, 20);
            this.txt_enferm.TabIndex = 1;
            this.txt_enferm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_enferm_KeyPress);
            this.txt_enferm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_enferm_KeyUp);
            // 
            // pn_enfer
            // 
            this.pn_enfer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_enfer.Controls.Add(this.lstb_resul_bus_enfer);
            this.pn_enfer.Controls.Add(this.lbl_nomb_enfer);
            this.pn_enfer.Controls.Add(this.lbl_enfermedades);
            this.pn_enfer.Controls.Add(this.txt_enferm);
            this.pn_enfer.Location = new System.Drawing.Point(63, 21);
            this.pn_enfer.Name = "pn_enfer";
            this.pn_enfer.Size = new System.Drawing.Size(429, 211);
            this.pn_enfer.TabIndex = 2;
            // 
            // lstb_resul_bus_enfer
            // 
            this.lstb_resul_bus_enfer.FormattingEnabled = true;
            this.lstb_resul_bus_enfer.Location = new System.Drawing.Point(22, 103);
            this.lstb_resul_bus_enfer.Name = "lstb_resul_bus_enfer";
            this.lstb_resul_bus_enfer.Size = new System.Drawing.Size(381, 95);
            this.lstb_resul_bus_enfer.TabIndex = 4;
            this.lstb_resul_bus_enfer.SelectedIndexChanged += new System.EventHandler(this.lstb_resul_bus_enfer_SelectedIndexChanged);
            this.lstb_resul_bus_enfer.DoubleClick += new System.EventHandler(this.lstb_resul_bus_enfer_DoubleClick);
            // 
            // lbl_nomb_enfer
            // 
            this.lbl_nomb_enfer.AutoSize = true;
            this.lbl_nomb_enfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomb_enfer.Location = new System.Drawing.Point(27, 57);
            this.lbl_nomb_enfer.Name = "lbl_nomb_enfer";
            this.lbl_nomb_enfer.Size = new System.Drawing.Size(179, 20);
            this.lbl_nomb_enfer.TabIndex = 3;
            this.lbl_nomb_enfer.Text = "Nombre de Enfermedad";
            // 
            // lbl_enfermedades
            // 
            this.lbl_enfermedades.AutoSize = true;
            this.lbl_enfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enfermedades.Location = new System.Drawing.Point(121, 17);
            this.lbl_enfermedades.Name = "lbl_enfermedades";
            this.lbl_enfermedades.Size = new System.Drawing.Size(146, 24);
            this.lbl_enfermedades.TabIndex = 2;
            this.lbl_enfermedades.Text = "Enfermedades";
            // 
            // pn_medica
            // 
            this.pn_medica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_medica.Controls.Add(this.lstb_resul_bus_medic);
            this.pn_medica.Controls.Add(this.lbl_nomb_med);
            this.pn_medica.Controls.Add(this.txt_medicam);
            this.pn_medica.Controls.Add(this.lbl_medicamentos);
            this.pn_medica.Location = new System.Drawing.Point(665, 21);
            this.pn_medica.Name = "pn_medica";
            this.pn_medica.Size = new System.Drawing.Size(429, 211);
            this.pn_medica.TabIndex = 3;
            // 
            // lstb_resul_bus_medic
            // 
            this.lstb_resul_bus_medic.FormattingEnabled = true;
            this.lstb_resul_bus_medic.Location = new System.Drawing.Point(28, 103);
            this.lstb_resul_bus_medic.Name = "lstb_resul_bus_medic";
            this.lstb_resul_bus_medic.Size = new System.Drawing.Size(381, 95);
            this.lstb_resul_bus_medic.TabIndex = 5;
            this.lstb_resul_bus_medic.DoubleClick += new System.EventHandler(this.lstb_resul_bus_medic_DoubleClick);
            // 
            // lbl_nomb_med
            // 
            this.lbl_nomb_med.AutoSize = true;
            this.lbl_nomb_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomb_med.Location = new System.Drawing.Point(24, 58);
            this.lbl_nomb_med.Name = "lbl_nomb_med";
            this.lbl_nomb_med.Size = new System.Drawing.Size(187, 20);
            this.lbl_nomb_med.TabIndex = 4;
            this.lbl_nomb_med.Text = "Nombre de Medicamento";
            // 
            // txt_medicam
            // 
            this.txt_medicam.Location = new System.Drawing.Point(224, 60);
            this.txt_medicam.Name = "txt_medicam";
            this.txt_medicam.Size = new System.Drawing.Size(185, 20);
            this.txt_medicam.TabIndex = 4;
            this.txt_medicam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_medicam_KeyUp);
            // 
            // lbl_medicamentos
            // 
            this.lbl_medicamentos.AutoSize = true;
            this.lbl_medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medicamentos.Location = new System.Drawing.Point(120, 17);
            this.lbl_medicamentos.Name = "lbl_medicamentos";
            this.lbl_medicamentos.Size = new System.Drawing.Size(146, 24);
            this.lbl_medicamentos.TabIndex = 3;
            this.lbl_medicamentos.Text = "Medicamentos";
            // 
            // lstb_enfer_selec
            // 
            this.lstb_enfer_selec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstb_enfer_selec.FormattingEnabled = true;
            this.lstb_enfer_selec.Location = new System.Drawing.Point(85, 279);
            this.lstb_enfer_selec.Name = "lstb_enfer_selec";
            this.lstb_enfer_selec.Size = new System.Drawing.Size(381, 95);
            this.lstb_enfer_selec.TabIndex = 4;
            this.lstb_enfer_selec.DoubleClick += new System.EventHandler(this.lstb_enfer_selec_DoubleClick);
            // 
            // lstb_medic_selec
            // 
            this.lstb_medic_selec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstb_medic_selec.FormattingEnabled = true;
            this.lstb_medic_selec.Location = new System.Drawing.Point(695, 279);
            this.lstb_medic_selec.Name = "lstb_medic_selec";
            this.lstb_medic_selec.Size = new System.Drawing.Size(390, 95);
            this.lstb_medic_selec.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enfermedades Seleccionadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(809, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Medicamentos Seleccionados";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(14, 3);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(132, 23);
            this.btn_remover.TabIndex = 8;
            this.btn_remover.Text = "Remover Seleccionado";
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(215, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(354, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // mc_enferm
            // 
            this.mc_enferm.Location = new System.Drawing.Point(465, 244);
            this.mc_enferm.Name = "mc_enferm";
            this.mc_enferm.TabIndex = 11;
            this.mc_enferm.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_enferm_DateChanged);
            // 
            // btn_cancel_enfer
            // 
            this.btn_cancel_enfer.Location = new System.Drawing.Point(465, 407);
            this.btn_cancel_enfer.Name = "btn_cancel_enfer";
            this.btn_cancel_enfer.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_enfer.TabIndex = 12;
            this.btn_cancel_enfer.Text = "Cancelar";
            this.btn_cancel_enfer.UseVisualStyleBackColor = true;
            this.btn_cancel_enfer.Click += new System.EventHandler(this.btn_cancel_enfer_Click);
            // 
            // btn_guar_fech
            // 
            this.btn_guar_fech.Location = new System.Drawing.Point(557, 407);
            this.btn_guar_fech.Name = "btn_guar_fech";
            this.btn_guar_fech.Size = new System.Drawing.Size(75, 23);
            this.btn_guar_fech.TabIndex = 13;
            this.btn_guar_fech.Text = "Listo";
            this.btn_guar_fech.UseVisualStyleBackColor = true;
            this.btn_guar_fech.Click += new System.EventHandler(this.btn_guar_fech_Click);
            // 
            // lbl_titu_mont_cal
            // 
            this.lbl_titu_mont_cal.AutoSize = true;
            this.lbl_titu_mont_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titu_mont_cal.Location = new System.Drawing.Point(518, 221);
            this.lbl_titu_mont_cal.Name = "lbl_titu_mont_cal";
            this.lbl_titu_mont_cal.Size = new System.Drawing.Size(99, 16);
            this.lbl_titu_mont_cal.TabIndex = 14;
            this.lbl_titu_mont_cal.Text = "Fecha de Inicio";
            // 
            // pn_botones
            // 
            this.pn_botones.Controls.Add(this.btn_remover);
            this.pn_botones.Controls.Add(this.btn_cancelar);
            this.pn_botones.Controls.Add(this.btn_guardar);
            this.pn_botones.Location = new System.Drawing.Point(665, 407);
            this.pn_botones.Name = "pn_botones";
            this.pn_botones.Size = new System.Drawing.Size(439, 33);
            this.pn_botones.TabIndex = 15;
            // 
            // medicamento_enfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 524);
            this.Controls.Add(this.pn_botones);
            this.Controls.Add(this.lbl_titu_mont_cal);
            this.Controls.Add(this.btn_guar_fech);
            this.Controls.Add(this.btn_cancel_enfer);
            this.Controls.Add(this.mc_enferm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstb_medic_selec);
            this.Controls.Add(this.lstb_enfer_selec);
            this.Controls.Add(this.pn_medica);
            this.Controls.Add(this.pn_enfer);
            this.Name = "medicamento_enfermedades";
            this.Text = "medicamento_enfermedades";
            this.Load += new System.EventHandler(this.medicamento_enfermedades_Load);
            this.pn_enfer.ResumeLayout(false);
            this.pn_enfer.PerformLayout();
            this.pn_medica.ResumeLayout(false);
            this.pn_medica.PerformLayout();
            this.pn_botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_enferm;
        private System.Windows.Forms.Panel pn_enfer;
        private System.Windows.Forms.Label lbl_enfermedades;
        private System.Windows.Forms.Panel pn_medica;
        private System.Windows.Forms.Label lbl_medicamentos;
        private System.Windows.Forms.TextBox txt_medicam;
        private System.Windows.Forms.Label lbl_nomb_enfer;
        private System.Windows.Forms.Label lbl_nomb_med;
        private System.Windows.Forms.ListBox lstb_resul_bus_enfer;
        private System.Windows.Forms.ListBox lstb_resul_bus_medic;
        private System.Windows.Forms.ListBox lstb_enfer_selec;
        private System.Windows.Forms.ListBox lstb_medic_selec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.MonthCalendar mc_enferm;
        private System.Windows.Forms.Button btn_cancel_enfer;
        private System.Windows.Forms.Button btn_guar_fech;
        private System.Windows.Forms.Label lbl_titu_mont_cal;
        private System.Windows.Forms.Panel pn_botones;
    }
}