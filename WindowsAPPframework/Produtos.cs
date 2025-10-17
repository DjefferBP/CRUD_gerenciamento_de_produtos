using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsAPPframework
{
    [Table("produtos")]
    public class Produtos
    {
        [Key]
        public int Id { get; set; }
        public string nome_produto { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qt_estoque { get; set; }
    }
}
