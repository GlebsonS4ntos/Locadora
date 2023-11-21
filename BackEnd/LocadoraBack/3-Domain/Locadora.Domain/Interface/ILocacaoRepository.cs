using Locadora.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Domain.Interface
{
    public interface ILocacaoRepository
    {
        public Task<List<Locacao>> GetLocacoesByUserAsync(int UsuarioId);
        public Task<Locacao> GetLocacaoByIdAsync(int Id);
        public Task CreateLocacao(Locacao locacao);
        public Task UpdateLocacao(Locacao locacao, int locacaoId);
        public Task DeleteLocacaoByIdAsync(int id);
    }
}
