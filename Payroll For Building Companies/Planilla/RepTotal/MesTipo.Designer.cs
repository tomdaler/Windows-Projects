namespace Planilla.RepTotal
{
    partial class MesTipo
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
            this.desde1 = new Rep1.Desde();
            this.button1 = new System.Windows.Forms.Button();
            this.dgObs = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgObs)).BeginInit();
            this.SuspendLayout();
            // 
            // desde1
            // 
            this.desde1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.desde1.Location = new System.Drawing.Point(12, 56);
            this.desde1.Name = "desde1";
            this.desde1.Size = new System.Drawing.Size(215, 105);
            this.desde1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 146;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgObs
            // 
            this.dgObs.AllowUserToAddRows = false;
            this.dgObs.AllowUserToDeleteRows = false;
            this.dgObs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObs.Location = new System.Drawing.Point(254, 27);
            this.dgObs.Name = "dgObs";
            this.dgObs.Size = new System.Drawing.Size(776, 626);
            this.dgObs.TabIndex = 147;
            this.dgObs.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 163;
            this.label6.Text = "DESDE :";
            // 
            // MesTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgObs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desde1);
            this.Name = "MesTipo";
            this.Text = "MesTipo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgObs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rep1.Desde desde1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgObs;
        private System.Windows.Forms.Label label6;
    }
}