using GameLibraryApi.Data;
using GameLibraryApi.Interfaces;
using GameLibraryApi.Models;

namespace GameLibraryApi.Services
{
    public class GameDatabaseService : IGameService
    {
        private GamingLibraryContext _context;
        public GameDatabaseService(GamingLibraryContext gamingLibraryContext)
        {
            _context = gamingLibraryContext;
        }



        public GameInformation CreateGame(GameInformation gameInformation)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(int id)
        {
            throw new NotImplementedException();
        }

        public GameInformation EditGame(GameInformation gameInformation)
        {
            throw new NotImplementedException();
        }

        public List<GameInformation> GetAllGames()
        {
            return _context.GameInformations.ToList();
        }

        public GameInformation GetGame(int id)
        {
            throw new NotImplementedException();
        }
    }
}
