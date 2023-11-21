using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Domain.Entities
{
    public class Veiculo : BaseEntity
    {
        public string UrlImage { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public bool IsDisponivel { get; set; }
        public ICollection<Locacao> Locacoes { get; set; }

        public Veiculo() { }
        public void UpdateVeiculo(Veiculo v)
        {
            Modelo = v.Modelo;
            Marca = v.Marca;
            Ano = v.Ano;
            Placa = v.Placa;
            Cor = v.Cor;
            IsDisponivel = v.IsDisponivel;
            Locacoes = v.Locacoes;
            UrlImage = v.UrlImage;
        }
    }
}
