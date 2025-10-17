namespace WindowsAPPframework
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            ListarProdutos();
            desabilitar_botoes();
        }

        private void ListarProdutos()
        {
            using (var db = new AppDbContext())
            {
                dgvProdutos.DataSource = db.Produto.ToList();
            }
        }
        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuantidadeDeProdutos.Text = string.Empty;
            txtNomeProduto.Focus();
        }

        private void habilitar_botoes()
        {
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void desabilitar_botoes()
        {
            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;
        }

        private string formatar_preco(string preco)
        {
            return preco.Replace(".", ",");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                try
                {
                    if (!string.IsNullOrEmpty(txtId.Text))
                    {
                        MessageBox.Show("Não preencha o canmpo de ID no cadastro!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparCampos();
                        return;
                    }
                    string preco_produto = formatar_preco(txtPreco.Text);
                    var produto = new Produtos()
                    {
                        nome_produto = txtNomeProduto.Text,
                        descricao = txtDescricao.Text,
                        preco = decimal.Parse(preco_produto),
                        qt_estoque = Convert.ToInt32(txtQuantidadeDeProdutos.Text)
                    };
                    db.Produto.Add(produto);
                    db.SaveChanges();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Por favor, preencha todos os campos!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimparCampos();
            ListarProdutos();
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNomeProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPreco.Text = dgvProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQuantidadeDeProdutos.Text = dgvProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
                habilitar_botoes();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                int id = int.Parse(txtId.Text);
                var produto = db.Produto.Find(id);
                string preco_produto = formatar_preco(txtPreco.Text);
                if (produto != null)
                {
                    produto.nome_produto = txtNomeProduto.Text;
                    produto.descricao = txtDescricao.Text;
                    produto.preco = decimal.Parse(preco_produto);
                    produto.qt_estoque = int.Parse(txtQuantidadeDeProdutos.Text);
                    db.SaveChanges();
                }
            }
            LimparCampos();
            ListarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {

                if (txtId.Text.Length <= 0)
                {
                    MessageBox.Show("Este Insira o id do cliente antes de exclui-lo!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int id = int.Parse(txtId.Text);
                var produto = db.Produto.Find(id);
                if (produto == null)
                {
                    MessageBox.Show("Este cliente não existe!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Produto.Remove(produto);
                db.SaveChanges();
            }
            LimparCampos();
            ListarProdutos();
        }

        private void txtQuantidadeDeProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmPrincipal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPreco.Text) && !string.IsNullOrWhiteSpace(txtNomeProduto.Text) && !string.IsNullOrWhiteSpace(txtId.Text) &&
                !string.IsNullOrWhiteSpace(txtQuantidadeDeProdutos.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                habilitar_botoes();
            }
            else
            {
                desabilitar_botoes();
            }
        }
    }
}