namespace proiect_POO_2
{
    partial class an2sem1CALC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acronim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nume,
            this.acronim,
            this.credite});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // cod
            // 
            this.cod.HeaderText = "Cod";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 61;
            // 
            // nume
            // 
            this.nume.HeaderText = "Nume";
            this.nume.MinimumWidth = 6;
            this.nume.Name = "nume";
            this.nume.ReadOnly = true;
            this.nume.Width = 72;
            // 
            // acronim
            // 
            this.acronim.HeaderText = "Acronim";
            this.acronim.MinimumWidth = 6;
            this.acronim.Name = "acronim";
            this.acronim.ReadOnly = true;
            this.acronim.Width = 85;
            // 
            // credite
            // 
            this.credite.HeaderText = "Credite";
            this.credite.MinimumWidth = 6;
            this.credite.Name = "credite";
            this.credite.ReadOnly = true;
            this.credite.Width = 79;
            // 
            // an2sem1CALC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "an2sem1CALC";
            this.Size = new System.Drawing.Size(862, 294);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn acronim;
        private System.Windows.Forms.DataGridViewTextBoxColumn credite;
    }
}
