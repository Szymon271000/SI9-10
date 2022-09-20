namespace SI9.Datas.Repositories
{
    public interface IUnitOfWork
    {
        public IDataStructureRepository dataStructureRepository { get; set; }
    }
}
