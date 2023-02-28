namespace CoreWeb.Data.Repositories
{
    public class BaseRepository
    {
        protected readonly DataContext _db;

        public BaseRepository(DataContext db)
        {
            _db = db;
        }
    }
}
