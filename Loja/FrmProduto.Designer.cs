namespace Loja
{
    partial class FrmProduto
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label codigoCategoriaLabel;
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtGVProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.BtNovo = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descricaoLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            codigoCategoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Loja.DAL.Produto);
            // 
            // dtGVProdutos
            // 
            this.dtGVProdutos.AllowUserToAddRows = false;
            this.dtGVProdutos.AllowUserToDeleteRows = false;
            this.dtGVProdutos.AutoGenerateColumns = false;
            this.dtGVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dtGVProdutos.DataSource = this.produtoBindingSource;
            this.dtGVProdutos.Location = new System.Drawing.Point(55, 163);
            this.dtGVProdutos.Name = "dtGVProdutos";
            this.dtGVProdutos.ReadOnly = true;
            this.dtGVProdutos.Size = new System.Drawing.Size(445, 171);
            this.dtGVProdutos.TabIndex = 1;
            this.dtGVProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.produtoDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(378, 117);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(275, 117);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(160, 117);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 2;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // BtNovo
            // 
            this.BtNovo.Location = new System.Drawing.Point(58, 117);
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.Size = new System.Drawing.Size(75, 23);
            this.BtNovo.TabIndex = 3;
            this.BtNovo.Text = "Novo";
            this.BtNovo.UseVisualStyleBackColor = true;
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(52, 15);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 7;
            descricaoLabel.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(116, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new System.Drawing.Point(72, 40);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(38, 13);
            precoLabel.TabIndex = 8;
            precoLabel.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Preco", true));
            this.txtPreco.Location = new System.Drawing.Point(116, 37);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 9;
            // 
            // codigoCategoriaLabel
            // 
            codigoCategoriaLabel.AutoSize = true;
            codigoCategoriaLabel.Location = new System.Drawing.Point(19, 66);
            codigoCategoriaLabel.Name = "codigoCategoriaLabel";
            codigoCategoriaLabel.Size = new System.Drawing.Size(91, 13);
            codigoCategoriaLabel.TabIndex = 9;
            codigoCategoriaLabel.Text = "Código Categoria:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "CodigoCategoria", true));
            this.comboCategoria.DataSource = this.categoriaBindingSource;
            this.comboCategoria.DisplayMember = "Descricao";
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(116, 63);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 10;
            this.comboCategoria.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Loja.DAL.Categoria);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 346);
            this.Controls.Add(codigoCategoriaLabel);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.BtNovo);
            this.Controls.Add(this.dtGVProdutos);
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProduto_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView dtGVProdutos;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button BtNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}