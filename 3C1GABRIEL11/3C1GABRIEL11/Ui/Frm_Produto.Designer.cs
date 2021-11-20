namespace _3C1GABRIEL11.Ui
{
    partial class Frm_Produto
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.dgtlista = new System.Windows.Forms.DataGridView();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtlista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(513, 258);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(145, 23);
            this.btn_editar.TabIndex = 19;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(333, 258);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(145, 23);
            this.btn_excluir.TabIndex = 18;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(235, 57);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(143, 258);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(145, 23);
            this.btn_cadastrar.TabIndex = 15;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // dgtlista
            // 
            this.dgtlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtlista.Location = new System.Drawing.Point(183, 317);
            this.dgtlista.Name = "dgtlista";
            this.dgtlista.Size = new System.Drawing.Size(435, 77);
            this.dgtlista.TabIndex = 14;
            this.dgtlista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listar);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(235, 163);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 13;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(235, 115);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(100, 20);
            this.txtproduto.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Produto:";
            // 
            // Frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dgtlista);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Produto";
            this.Text = "Frm_Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgtlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridView dgtlista;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}