namespace idade
{
    partial class frmidade
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmidade));
            this.btnverificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.btnpeso = new System.Windows.Forms.Button();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.Khaki;
            this.btnverificar.Location = new System.Drawing.Point(24, 148);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(95, 45);
            this.btnverificar.TabIndex = 0;
            this.btnverificar.Text = "Verificar\r\nidade";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite sua idade ou peso";
            // 
            // txtidade
            // 
            this.txtidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade.Location = new System.Drawing.Point(32, 87);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(87, 26);
            this.txtidade.TabIndex = 2;
            // 
            // btnpeso
            // 
            this.btnpeso.BackColor = System.Drawing.Color.Khaki;
            this.btnpeso.Location = new System.Drawing.Point(167, 148);
            this.btnpeso.Name = "btnpeso";
            this.btnpeso.Size = new System.Drawing.Size(89, 45);
            this.btnpeso.TabIndex = 3;
            this.btnpeso.Text = "Verificar peso";
            this.btnpeso.UseVisualStyleBackColor = false;
            this.btnpeso.Click += new System.EventHandler(this.btnpeso_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(167, 87);
            this.txtpeso.Multiline = true;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(89, 26);
            this.txtpeso.TabIndex = 4;
            // 
            // frmidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 246);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.btnpeso);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnverificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "idade / peso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Button btnpeso;
        private System.Windows.Forms.TextBox txtpeso;
    }
}

