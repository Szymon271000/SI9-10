using Data.Context;

namespace SI9.Datas.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataStructuresAndAlghoritmsContext _context;
        public IDataStructureRepository dataStructureRepository { get; set; }

        public UnitOfWork(DataStructuresAndAlghoritmsContext context)
        {
            _context = context;
            dataStructureRepository = new DataStructureRepository(context);
        }
    }
}
