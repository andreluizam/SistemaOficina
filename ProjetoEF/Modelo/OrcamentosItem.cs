using ProjetoEF.Pesquisa;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEF
{
    public class OrcamentosItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("OrcamentoID")]
        public int OrcamentoID { get; set; }
        public virtual Orcamentos Orcamento { get; set; }

        [ForeignKey("PecasID")]
        public int PecasID { get; set; }
        public virtual Pecas Pecas { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Subtotal { get; set; }
    }
}
