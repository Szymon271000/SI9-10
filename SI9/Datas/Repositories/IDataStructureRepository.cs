using Data.Models;

namespace SI9.Datas.Repositories
{
    public interface IDataStructureRepository
    {
        public Task<DataStructure> GetSingleDataStructure(string name);
    }
}
