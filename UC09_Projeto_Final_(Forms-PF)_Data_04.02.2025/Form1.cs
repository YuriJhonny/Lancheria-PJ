using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySqlConnector;

namespace UC09_Projeto_Final__Forms_PF__Data_04._02._2025
{
    public partial class frmFormsPf : Form
    {
        // Declaração da variável para a conexão com o banco de dados
        private MySqlConnection Conexao;

        // String de conexão para o banco de dados MySQL
        string data_source = "server=localhost;database=meubanco;user=root;password=senha";

        public frmFormsPf()
        {
            InitializeComponent();

            // Configuração do ListView para exibir os dados em formato de tabela
            lvDados.View = View.Details;
            lvDados.LabelEdit = false;
            lvDados.AllowColumnReorder = false;
            lvDados.FullRowSelect = false;
            lvDados.GridLines = true;

            // Adicionando as colunas no ListView
            lvDados.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lvDados.Columns.Add("Qtd-a-Fazer", 150, HorizontalAlignment.Left);
            lvDados.Columns.Add("Possui", 150, HorizontalAlignment.Left);
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar uma nova conexão com o banco de dados usando a string de conexão
                using (Conexao = new MySqlConnection(data_source))
                {
                    // Abrir a conexão
                    Conexao.Open();

                    // Aqui você pode executar um comando SQL, como um SELECT, INSERT, etc.
                    // No momento, está apenas abrindo e fechando a conexão, mas você pode incluir lógica adicional

                    // Exemplo de uso: Verificar se a conexão foi bem-sucedida
                    MessageBox.Show("Conexão estabelecida com sucesso!");

                    // Aqui é onde o redirecionamento para o novo formulário acontece
                    // Descomente a linha abaixo para abrir o formulário 'frmFormsPedido'
                    //frmFormsPedido frmPedido = new frmFormsPedido();  // Criação do novo formulário
                    //frmPedido.Show();  // Exibe o novo formulário

                }
            }
            catch (Exception ex)
            {
                // Exibe qualquer erro ocorrido durante a conexão
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void AtualizarList()
        {
            try
            {
                // Usando a instrução "using" para garantir que os objetos sejam descartados corretamente
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    // Abrir a conexão com o banco de dados
                    conexao.Open();

                    // Consulta SQL para obter todos os dados da tabela "contato"
                    string sql = "SELECT * FROM contato";

                    // Criar o comando SQL e associar a conexão
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        // Executar o comando e obter os dados com o MySqlDataReader
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Limpar os itens do ListView antes de adicionar novos dados
                            lvDados.Items.Clear();

                            // Ler os dados e adicionar no ListView
                            while (reader.Read())
                            {
                                // Criar um novo item de ListView para cada linha lida
                                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                                item.SubItems.Add(reader["Qtd-a-Fazer"].ToString());
                                item.SubItems.Add(reader["Possui"].ToString());

                                // Adicionar o item ao ListView
                                lvDados.Items.Add(item);
                            }
                        }
                    }
                }

                // Mensagem indicando que a atualização foi bem-sucedida
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                // Exibe qualquer erro ocorrido ao tentar atualizar os dados
                MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
            }
        }

        private void frmFormsPf_Load(object sender, EventArgs e)
        {
            // Chama o método para atualizar o ListView quando o formulário for carregado
            AtualizarList();
        }
    }
}
