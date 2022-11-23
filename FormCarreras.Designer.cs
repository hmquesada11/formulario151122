
namespace formulario151122
{
    partial class FormCarreras
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodcarrer = new System.Windows.Forms.Label();
            this.lblnomcarrer = new System.Windows.Forms.Label();
            this.txtcodigocarrer = new System.Windows.Forms.TextBox();
            this.txtnomcarrer = new System.Windows.Forms.TextBox();
            this.dgvcarreras = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARRERAS";
            // 
            // lblcodcarrer
            // 
            this.lblcodcarrer.AutoSize = true;
            this.lblcodcarrer.Location = new System.Drawing.Point(74, 117);
            this.lblcodcarrer.Name = "lblcodcarrer";
            this.lblcodcarrer.Size = new System.Drawing.Size(94, 13);
            this.lblcodcarrer.TabIndex = 1;
            this.lblcodcarrer.Text = "Codigo de carrera:";
            // 
            // lblnomcarrer
            // 
            this.lblnomcarrer.AutoSize = true;
            this.lblnomcarrer.Location = new System.Drawing.Point(70, 157);
            this.lblnomcarrer.Name = "lblnomcarrer";
            this.lblnomcarrer.Size = new System.Drawing.Size(98, 13);
            this.lblnomcarrer.TabIndex = 2;
            this.lblnomcarrer.Text = "Nombre de carrera:";
            // 
            // txtcodigocarrer
            // 
            this.txtcodigocarrer.Location = new System.Drawing.Point(188, 114);
            this.txtcodigocarrer.Name = "txtcodigocarrer";
            this.txtcodigocarrer.Size = new System.Drawing.Size(100, 20);
            this.txtcodigocarrer.TabIndex = 3;
            // 
            // txtnomcarrer
            // 
            this.txtnomcarrer.Location = new System.Drawing.Point(188, 154);
            this.txtnomcarrer.Name = "txtnomcarrer";
            this.txtnomcarrer.Size = new System.Drawing.Size(276, 20);
            this.txtnomcarrer.TabIndex = 4;
            // 
            // dgvcarreras
            // 
            this.dgvcarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarreras.Location = new System.Drawing.Point(58, 210);
            this.dgvcarreras.Name = "dgvcarreras";
            this.dgvcarreras.Size = new System.Drawing.Size(339, 243);
            this.dgvcarreras.TabIndex = 5;
            this.dgvcarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcarreras_CellClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(482, 239);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(482, 293);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 7;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(482, 347);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 8;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(482, 402);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 9;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            // 
            // FormCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 489);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvcarreras);
            this.Controls.Add(this.txtnomcarrer);
            this.Controls.Add(this.txtcodigocarrer);
            this.Controls.Add(this.lblnomcarrer);
            this.Controls.Add(this.lblcodcarrer);
            this.Controls.Add(this.label1);
            this.Name = "FormCarreras";
            this.Text = "FormCarreras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcodcarrer;
        private System.Windows.Forms.Label lblnomcarrer;
        private System.Windows.Forms.TextBox txtcodigocarrer;
        private System.Windows.Forms.TextBox txtnomcarrer;
        private System.Windows.Forms.DataGridView dgvcarreras;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnregresar;
    }
}