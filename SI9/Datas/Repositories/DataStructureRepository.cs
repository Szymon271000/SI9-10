using Data.Context;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace SI9.Datas.Repositories
{
    public class DataStructureRepository : IDataStructureRepository
    {
        private readonly DataStructuresAndAlghoritmsContext _context;

        public DataStructureRepository(DataStructuresAndAlghoritmsContext context)
        {
            _context = context;
        }

        public async Task<DataStructure> GetSingleDataStructure(string name)
        {
            return await _context.dataStructures.FirstOrDefaultAsync(x=> x.Name == name);
        }
    }
}
