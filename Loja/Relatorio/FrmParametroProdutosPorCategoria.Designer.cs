namespace Loja.Relatorio
{
    partial class FrmParametroProdutosPorCategoria
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.gerarRelatorio = new System.Windows.Forms.Button();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.DataSource = this.categoriaBindingSource;
            this.comboCategoria.DisplayMember = "Descricao";
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(89, 55);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(153, 21);
            this.comboCategoria.TabIndex = 1;
            this.comboCategoria.ValueMember = "Codigo";
            // 
            // gerarRelatorio
            // 
            this.gerarRelatorio.Location = new System.Drawing.Point(92, 103);
            this.gerarRelatorio.Name = "gerarRelatorio";
            this.gerarRelatorio.Size = new System.Drawing.Size(143, 23);
            this.gerarRelatorio.TabIndex = 2;
            this.gerarRelatorio.Text = "Gerar Relatorio";
            this.gerarRelatorio.UseVisualStyleBackColor = true;
            this.gerarRelatorio.Click += new System.EventHandler(this.gerarRelatorio_Click);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Loja.DAL.Categoria);
            // 
            // FrmParametroProdutosPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 168);
            this.Controls.Add(this.gerarRelatorio);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FrmParametroProdutosPorCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParametroProdutosPorCategoria";
            this.Load += new System.EventHandler(this.FrmParametroProdutosPorCategoria_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmParametroProdutosPorCategoria_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Button gerarRelatorio;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}