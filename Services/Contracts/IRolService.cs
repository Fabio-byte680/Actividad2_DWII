using apiServicio.Models;

namespace apiServicio.Services.Contracts
{
    public interface IRolService
    {
        public Task<List<Rol>> GetList();
    }
}
