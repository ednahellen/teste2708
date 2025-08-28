using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SistemaCestas
{
    public static class ProdutoDAL
    {
        // String de conexão única
        private static readonly string ConnectionString = "server=localhost;database=sistemacestas;uid=root;pwd=;";

        // Lista produtos do mês e ano fornecidos
        public static List<Produto> ListarProdutosMes(int mes, int ano)
        {
            List<Produto> lista = new List<Produto>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string sql = @"
                    SELECT Id, CodigoBarras, Nome, Quantidade, Peso, Validade, DataEntrada
                    FROM Produtos
                    WHERE MONTH(DataEntrada) = @mes AND YEAR(DataEntrada) = @ano";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@mes", mes);
                    cmd.Parameters.AddWithValue("@ano", ano);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Produto
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                CodigoBarras = reader["CodigoBarras"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                Quantidade = Convert.ToInt32(reader["Quantidade"]),
                                Peso = Convert.ToDouble(reader["Peso"]),
                                Validade = Convert.ToDateTime(reader["Validade"]),
                                DataEntrada = Convert.ToDateTime(reader["DataEntrada"])
                            });
                        }
                    }
                }
            }

            return lista;
        }

        // Alias com o nome que algumas partes do código podem usar
        public static List<Produto> ObterProdutosDoMes(int mes, int ano)
        {
            return ListarProdutosMes(mes, ano);
        }

        // Inserir novo produto
        public static void InserirProduto(Produto produto)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                string sql = @"
                    INSERT INTO Produtos (CodigoBarras, Nome, Quantidade, Peso, Validade, DataEntrada)
                    VALUES (@CodigoBarras, @Nome, @Quantidade, @Peso, @Validade, @DataEntrada)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CodigoBarras", produto.CodigoBarras);
                    cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    cmd.Parameters.AddWithValue("@Peso", produto.Peso);
                    cmd.Parameters.AddWithValue("@Validade", produto.Validade);
                    cmd.Parameters.AddWithValue("@DataEntrada", produto.DataEntrada);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
