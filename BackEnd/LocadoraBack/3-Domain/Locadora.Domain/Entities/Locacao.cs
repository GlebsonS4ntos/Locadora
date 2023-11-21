using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Domain.Entities
{
    public class Locacao : BaseEntity
    {
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool IsEntregue { get; set; }

        public Locacao() { } 
        public void UpdateLocacao(Locacao l)
        {
            Veiculo = l.Veiculo;
            VeiculoId = l.VeiculoId;
            DataCriacao = l.DataCriacao;
            DataFinal = l.DataFinal;
            IsEntregue = l.IsEntregue;
        }
    }
}
