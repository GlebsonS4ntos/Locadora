using Locadora.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Domain.Interface
{
    public interface IVeiculoRepository
    {
        public Task<List<Veiculo>> GetVeiculosAsync();
        public Task<Veiculo> GetVeiculoByIdAsync(int id);
        public Task CreateVeiculoAsync(Veiculo veiculo);
        public Task UpdateVeiculoAsync(Veiculo veiculo, int id);
        public Task DeleteVeiculoAsync(int id);
    }
}
