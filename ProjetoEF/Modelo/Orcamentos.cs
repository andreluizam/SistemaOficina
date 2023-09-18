using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace ProjetoEF.Pesquisa
{
    public class Orcamentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("ClienteID")]
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Carro { get; set; }
        public decimal Total { get; set; }
        public virtual ICollection<OrcamentosItem> Itens { get; set; } = new List<OrcamentosItem>();
    }
}
