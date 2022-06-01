using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class ChessPlayerRepository : IChessPlayerRepository
    {
        private PostContext DbContext;
        public ChessPlayerRepository(PostContext context)
        {
            DbContext = context;

/*            bool isCreated = DbContext.Database.EnsureCreated();
            // bool isCreated2 = await db.Database.EnsureCreatedAsync();
            if (isCreated)
            {
                Debug.WriteLine("База данных была создана");
                DbContext.Database.EnsureDeleted();
            }
            else Debug.WriteLine("База данных уже существует");*/
        }

        public async Task<bool> AddChessPlayer(ChessPlayer chessPlayer)
        {
            try
            {
                await DbContext.ChessPlayers.AddAsync(chessPlayer);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public IList<ChessPlayer> GetAllChessPlayers()
        { 
            return DbContext.ChessPlayers.ToList();
        }

        public ChessPlayer GetChessPlayer(int id)
        {
            return DbContext.ChessPlayers.FirstOrDefault(x => x.Id == id);
        }

        Task<bool> IChessPlayerRepository.DeleteChessPlaeyr(int id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IChessPlayerRepository.UpdateChessPlayer(ChessPlayer chessPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
