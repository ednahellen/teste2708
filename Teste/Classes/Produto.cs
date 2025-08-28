using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaCestas
{
    public class Produto
    {
        public int Id { get; set; }                  // Chave primária
        public string CodigoBarras { get; set; }     // Código de barras
        public string Nome { get; set; }             // Nome do produto
        public int Quantidade { get; set; }          // Quantidade em estoque
        public double Peso { get; set; }             // Peso unitário
        public DateTime Validade { get; set; }       // Data de validade
        public DateTime DataEntrada { get; set; }    // Data de entrada no estoque
        public string Categoria { get; set; }        // Categoria opcional (se tiver)
    }
}


