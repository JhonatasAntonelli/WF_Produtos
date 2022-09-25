namespace WF_Produtos
{
    partial class Frm_adicionarProdutos
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
            this.Lbl_NomeAdd = new System.Windows.Forms.Label();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.txt_descricaoProduto = new System.Windows.Forms.TextBox();
            this.txt_quantidadeProduto = new System.Windows.Forms.TextBox();
            this.lbl_descricaoAdd = new System.Windows.Forms.Label();
            this.Lbl_quantidadeAdd = new System.Windows.Forms.Label();
            this.Btn_enviar = new System.Windows.Forms.Button();
            this.list_buscarProduto = new System.Windows.Forms.ListView();
            this.Lbl_buscarProduto = new System.Windows.Forms.Label();
            this.Txt_buscarProduto = new System.Windows.Forms.TextBox();
            this.Btn_buscarProduto = new System.Windows.Forms.Button();
            this.lbl_excluir = new System.Windows.Forms.Label();
            this.txt_RemoverID = new System.Windows.Forms.TextBox();
            this.btn_removerID = new System.Windows.Forms.Button();
            this.txt_codigoProduto = new System.Windows.Forms.TextBox();
            this.lbl_codigoAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_precoEditar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigoEditar = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_quantidadeEditar = new System.Windows.Forms.TextBox();
            this.txt_descricaoEditar = new System.Windows.Forms.TextBox();
            this.txt_nomeEditar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_idEditar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_NomeAdd
            // 
            this.Lbl_NomeAdd.AutoSize = true;
            this.Lbl_NomeAdd.Location = new System.Drawing.Point(12, 103);
            this.Lbl_NomeAdd.Name = "Lbl_NomeAdd";
            this.Lbl_NomeAdd.Size = new System.Drawing.Size(133, 20);
            this.Lbl_NomeAdd.TabIndex = 0;
            this.Lbl_NomeAdd.Text = "Nome do Produto";
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Location = new System.Drawing.Point(201, 103);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.Size = new System.Drawing.Size(162, 26);
            this.txt_nomeProduto.TabIndex = 2;
            // 
            // txt_descricaoProduto
            // 
            this.txt_descricaoProduto.Location = new System.Drawing.Point(201, 150);
            this.txt_descricaoProduto.Name = "txt_descricaoProduto";
            this.txt_descricaoProduto.Size = new System.Drawing.Size(162, 26);
            this.txt_descricaoProduto.TabIndex = 3;
            // 
            // txt_quantidadeProduto
            // 
            this.txt_quantidadeProduto.Location = new System.Drawing.Point(201, 196);
            this.txt_quantidadeProduto.Name = "txt_quantidadeProduto";
            this.txt_quantidadeProduto.Size = new System.Drawing.Size(162, 26);
            this.txt_quantidadeProduto.TabIndex = 4;
            this.txt_quantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantidadeProduto_KeyPress);
            // 
            // lbl_descricaoAdd
            // 
            this.lbl_descricaoAdd.AutoSize = true;
            this.lbl_descricaoAdd.Location = new System.Drawing.Point(12, 153);
            this.lbl_descricaoAdd.Name = "lbl_descricaoAdd";
            this.lbl_descricaoAdd.Size = new System.Drawing.Size(162, 20);
            this.lbl_descricaoAdd.TabIndex = 4;
            this.lbl_descricaoAdd.Text = "Descrição do Produto";
            // 
            // Lbl_quantidadeAdd
            // 
            this.Lbl_quantidadeAdd.AutoSize = true;
            this.Lbl_quantidadeAdd.Location = new System.Drawing.Point(12, 196);
            this.Lbl_quantidadeAdd.Name = "Lbl_quantidadeAdd";
            this.Lbl_quantidadeAdd.Size = new System.Drawing.Size(174, 20);
            this.Lbl_quantidadeAdd.TabIndex = 5;
            this.Lbl_quantidadeAdd.Text = "Quantidade de Produto";
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.Location = new System.Drawing.Point(12, 286);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(347, 36);
            this.Btn_enviar.TabIndex = 6;
            this.Btn_enviar.Text = "Enviar";
            this.Btn_enviar.UseVisualStyleBackColor = true;
            this.Btn_enviar.Click += new System.EventHandler(this.Btn_enviar_Click);
            // 
            // list_buscarProduto
            // 
            this.list_buscarProduto.HideSelection = false;
            this.list_buscarProduto.Location = new System.Drawing.Point(448, 103);
            this.list_buscarProduto.Name = "list_buscarProduto";
            this.list_buscarProduto.Size = new System.Drawing.Size(625, 113);
            this.list_buscarProduto.TabIndex = 9;
            this.list_buscarProduto.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_buscarProduto
            // 
            this.Lbl_buscarProduto.AutoSize = true;
            this.Lbl_buscarProduto.Location = new System.Drawing.Point(444, 59);
            this.Lbl_buscarProduto.Name = "Lbl_buscarProduto";
            this.Lbl_buscarProduto.Size = new System.Drawing.Size(119, 20);
            this.Lbl_buscarProduto.TabIndex = 8;
            this.Lbl_buscarProduto.Text = "Buscar Produto";
            // 
            // Txt_buscarProduto
            // 
            this.Txt_buscarProduto.Location = new System.Drawing.Point(585, 56);
            this.Txt_buscarProduto.Name = "Txt_buscarProduto";
            this.Txt_buscarProduto.Size = new System.Drawing.Size(267, 26);
            this.Txt_buscarProduto.TabIndex = 7;
            // 
            // Btn_buscarProduto
            // 
            this.Btn_buscarProduto.Location = new System.Drawing.Point(876, 51);
            this.Btn_buscarProduto.Name = "Btn_buscarProduto";
            this.Btn_buscarProduto.Size = new System.Drawing.Size(197, 34);
            this.Btn_buscarProduto.TabIndex = 8;
            this.Btn_buscarProduto.Text = "Buscar";
            this.Btn_buscarProduto.UseVisualStyleBackColor = true;
            this.Btn_buscarProduto.Click += new System.EventHandler(this.Btn_buscarProduto_Click);
            // 
            // lbl_excluir
            // 
            this.lbl_excluir.AutoSize = true;
            this.lbl_excluir.Location = new System.Drawing.Point(543, 294);
            this.lbl_excluir.Name = "lbl_excluir";
            this.lbl_excluir.Size = new System.Drawing.Size(222, 20);
            this.lbl_excluir.TabIndex = 11;
            this.lbl_excluir.Text = "Digite o id que deseja remover";
            // 
            // txt_RemoverID
            // 
            this.txt_RemoverID.Location = new System.Drawing.Point(783, 288);
            this.txt_RemoverID.Name = "txt_RemoverID";
            this.txt_RemoverID.Size = new System.Drawing.Size(207, 26);
            this.txt_RemoverID.TabIndex = 10;
            // 
            // btn_removerID
            // 
            this.btn_removerID.Location = new System.Drawing.Point(547, 333);
            this.btn_removerID.Name = "btn_removerID";
            this.btn_removerID.Size = new System.Drawing.Size(443, 36);
            this.btn_removerID.TabIndex = 11;
            this.btn_removerID.Text = "Remover";
            this.btn_removerID.UseVisualStyleBackColor = true;
            this.btn_removerID.Click += new System.EventHandler(this.btn_removerID_Click);
            // 
            // txt_codigoProduto
            // 
            this.txt_codigoProduto.Location = new System.Drawing.Point(201, 56);
            this.txt_codigoProduto.Name = "txt_codigoProduto";
            this.txt_codigoProduto.Size = new System.Drawing.Size(162, 26);
            this.txt_codigoProduto.TabIndex = 1;
            // 
            // lbl_codigoAdd
            // 
            this.lbl_codigoAdd.AutoSize = true;
            this.lbl_codigoAdd.Location = new System.Drawing.Point(12, 59);
            this.lbl_codigoAdd.Name = "lbl_codigoAdd";
            this.lbl_codigoAdd.Size = new System.Drawing.Size(141, 20);
            this.lbl_codigoAdd.TabIndex = 15;
            this.lbl_codigoAdd.Text = "Código do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Preço do produto";
            // 
            // txt_precoProduto
            // 
            this.txt_precoProduto.Location = new System.Drawing.Point(201, 245);
            this.txt_precoProduto.Name = "txt_precoProduto";
            this.txt_precoProduto.Size = new System.Drawing.Size(162, 26);
            this.txt_precoProduto.TabIndex = 5;
            this.txt_precoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precoProduto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adicionar Produtos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Excluir Produtos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1226, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Editar Produtos";
            // 
            // txt_precoEditar
            // 
            this.txt_precoEditar.Location = new System.Drawing.Point(1358, 264);
            this.txt_precoEditar.Name = "txt_precoEditar";
            this.txt_precoEditar.Size = new System.Drawing.Size(162, 26);
            this.txt_precoEditar.TabIndex = 16;
            this.txt_precoEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precoEditar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1169, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Preço do produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1169, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Código do Produto";
            // 
            // txt_codigoEditar
            // 
            this.txt_codigoEditar.Location = new System.Drawing.Point(1358, 106);
            this.txt_codigoEditar.Name = "txt_codigoEditar";
            this.txt_codigoEditar.Size = new System.Drawing.Size(162, 26);
            this.txt_codigoEditar.TabIndex = 12;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(1173, 314);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(347, 36);
            this.btn_editar.TabIndex = 17;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1169, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Quantidade de Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1169, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Descrição do Produto";
            // 
            // txt_quantidadeEditar
            // 
            this.txt_quantidadeEditar.Location = new System.Drawing.Point(1358, 219);
            this.txt_quantidadeEditar.Name = "txt_quantidadeEditar";
            this.txt_quantidadeEditar.Size = new System.Drawing.Size(162, 26);
            this.txt_quantidadeEditar.TabIndex = 15;
            this.txt_quantidadeEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantidadeEditar_KeyPress);
            // 
            // txt_descricaoEditar
            // 
            this.txt_descricaoEditar.Location = new System.Drawing.Point(1358, 182);
            this.txt_descricaoEditar.Name = "txt_descricaoEditar";
            this.txt_descricaoEditar.Size = new System.Drawing.Size(162, 26);
            this.txt_descricaoEditar.TabIndex = 14;
            // 
            // txt_nomeEditar
            // 
            this.txt_nomeEditar.Location = new System.Drawing.Point(1358, 147);
            this.txt_nomeEditar.Name = "txt_nomeEditar";
            this.txt_nomeEditar.Size = new System.Drawing.Size(162, 26);
            this.txt_nomeEditar.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1169, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nome do Produto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1169, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "ID do Produto";
            // 
            // txt_idEditar
            // 
            this.txt_idEditar.Location = new System.Drawing.Point(1358, 65);
            this.txt_idEditar.Name = "txt_idEditar";
            this.txt_idEditar.Size = new System.Drawing.Size(162, 26);
            this.txt_idEditar.TabIndex = 12;
            this.txt_idEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idEditar_KeyPress);
            // 
            // Frm_adicionarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 450);
            this.Controls.Add(this.txt_idEditar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_precoEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_codigoEditar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_quantidadeEditar);
            this.Controls.Add(this.txt_descricaoEditar);
            this.Controls.Add(this.txt_nomeEditar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_precoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_codigoAdd);
            this.Controls.Add(this.txt_codigoProduto);
            this.Controls.Add(this.btn_removerID);
            this.Controls.Add(this.txt_RemoverID);
            this.Controls.Add(this.lbl_excluir);
            this.Controls.Add(this.Btn_buscarProduto);
            this.Controls.Add(this.Txt_buscarProduto);
            this.Controls.Add(this.Lbl_buscarProduto);
            this.Controls.Add(this.list_buscarProduto);
            this.Controls.Add(this.Btn_enviar);
            this.Controls.Add(this.Lbl_quantidadeAdd);
            this.Controls.Add(this.lbl_descricaoAdd);
            this.Controls.Add(this.txt_quantidadeProduto);
            this.Controls.Add(this.txt_descricaoProduto);
            this.Controls.Add(this.txt_nomeProduto);
            this.Controls.Add(this.Lbl_NomeAdd);
            this.Name = "Frm_adicionarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produtos";
            this.Load += new System.EventHandler(this.Frm_adicionarProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NomeAdd;
        private System.Windows.Forms.TextBox txt_nomeProduto;
        private System.Windows.Forms.TextBox txt_descricaoProduto;
        private System.Windows.Forms.TextBox txt_quantidadeProduto;
        private System.Windows.Forms.Label lbl_descricaoAdd;
        private System.Windows.Forms.Label Lbl_quantidadeAdd;
        private System.Windows.Forms.Button Btn_enviar;
        private System.Windows.Forms.ListView list_buscarProduto;
        private System.Windows.Forms.Label Lbl_buscarProduto;
        private System.Windows.Forms.TextBox Txt_buscarProduto;
        private System.Windows.Forms.Button Btn_buscarProduto;
        private System.Windows.Forms.Label lbl_excluir;
        private System.Windows.Forms.TextBox txt_RemoverID;
        private System.Windows.Forms.Button btn_removerID;
        private System.Windows.Forms.TextBox txt_codigoProduto;
        private System.Windows.Forms.Label lbl_codigoAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_precoEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigoEditar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_quantidadeEditar;
        private System.Windows.Forms.TextBox txt_descricaoEditar;
        private System.Windows.Forms.TextBox txt_nomeEditar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_idEditar;
    }
}

