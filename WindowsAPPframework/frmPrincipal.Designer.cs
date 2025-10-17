namespace WindowsAPPframework
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtId = new TextBox();
            txtNomeProduto = new TextBox();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            dgvProdutos = new DataGridView();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtQuantidadeDeProdutos = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 141);
            label1.Name = "label1";
            label1.Size = new Size(27, 19);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(14, 163);
            txtId.Name = "txtId";
            txtId.Size = new Size(63, 26);
            txtId.TabIndex = 4;
            txtId.TextChanged += frmPrincipal_TextChanged;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeProduto.Location = new Point(12, 31);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(167, 26);
            txtNomeProduto.TabIndex = 5;
            txtNomeProduto.TextChanged += frmPrincipal_TextChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(195, 33);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(261, 26);
            txtDescricao.TabIndex = 6;
            txtDescricao.TextChanged += frmPrincipal_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPreco.Location = new Point(14, 95);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(115, 26);
            txtPreco.TabIndex = 7;
            txtPreco.TextChanged += frmPrincipal_TextChanged;
            txtPreco.KeyPress += txtQuantidadeDeProdutos_KeyPress;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToOrderColumns = true;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = SystemColors.Window;
            dgvProdutos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProdutos.GridColor = SystemColors.Highlight;
            dgvProdutos.Location = new Point(12, 210);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(618, 233);
            dgvProdutos.TabIndex = 8;
            dgvProdutos.CellClick += dgvClientes_CellClick;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Green;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInserir.ForeColor = SystemColors.ControlLightLight;
            btnInserir.Location = new Point(481, 27);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(159, 37);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "INSERIR PRODUTO";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = SystemColors.HotTrack;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = SystemColors.ControlLightLight;
            btnAtualizar.Location = new Point(636, 286);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(156, 54);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Firebrick;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.ControlLightLight;
            btnExcluir.Location = new Point(636, 360);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(156, 54);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Teal;
            btnListar.FlatAppearance.BorderSize = 0;
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListar.ForeColor = SystemColors.ControlLightLight;
            btnListar.Location = new Point(636, 210);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(159, 54);
            btnListar.TabIndex = 12;
            btnListar.Text = "LISTAR";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(144, 19);
            label5.TabIndex = 1;
            label5.Text = "NOME DO PRODUTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(195, 11);
            label6.Name = "label6";
            label6.Size = new Size(90, 19);
            label6.TabIndex = 2;
            label6.Text = "DESCRIÇÃO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 73);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 3;
            label7.Text = "PREÇO";
            // 
            // txtQuantidadeDeProdutos
            // 
            txtQuantidadeDeProdutos.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidadeDeProdutos.Location = new Point(153, 95);
            txtQuantidadeDeProdutos.Name = "txtQuantidadeDeProdutos";
            txtQuantidadeDeProdutos.Size = new Size(122, 26);
            txtQuantidadeDeProdutos.TabIndex = 14;
            txtQuantidadeDeProdutos.TextChanged += frmPrincipal_TextChanged;
            txtQuantidadeDeProdutos.KeyPress += txtQuantidadeDeProdutos_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(153, 73);
            label4.Name = "label4";
            label4.Size = new Size(198, 19);
            label4.TabIndex = 13;
            label4.Text = "QUANTIDADE EM ESTOQUE";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtQuantidadeDeProdutos);
            Controls.Add(label4);
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(dgvProdutos);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            Text = "Cadastro de clientes";
            TextChanged += frmPrincipal_TextChanged;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNomeProduto;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private DataGridView dgvProdutos;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnListar;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtQuantidadeDeProdutos;
        private Label label4;
    }
}