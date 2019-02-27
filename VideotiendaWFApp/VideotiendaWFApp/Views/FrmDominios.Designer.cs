namespace VideotiendaWFApp.Views
{
    partial class FrmDominios
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btneliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btneditar);
            this.splitContainer1.Panel1.Controls.Add(this.btnnuevo);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(946, 444);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnuevo.Location = new System.Drawing.Point(26, 16);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(135, 23);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneditar.Location = new System.Drawing.Point(189, 16);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(135, 23);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btneliminar.Location = new System.Drawing.Point(368, 16);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(135, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // FrmDominios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 444);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmDominios";
            this.Text = "Administrar Dominios";
            this.Load += new System.EventHandler(this.FrmDominios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}