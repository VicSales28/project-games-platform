namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        var gamesDevelopedByStudio = Games
            .Where(game => game.DeveloperStudio == gameStudio.Id)
            .ToList();

        return gamesDevelopedByStudio;
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        var gamesPlayedByPlayer = Games
            .Where(game => game.Players.Contains(player.Id))
            .ToList();

        return gamesPlayedByPlayer;
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        var gamesOwnedByPlayer = Games
            .Where(game => playerEntry.GamesOwned.Contains(game.Id))
            .ToList();

        return gamesOwnedByPlayer;
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        var gamesWithStudio = Games
            .Join(
                GameStudios,
                game => game.DeveloperStudio,
                studio => studio.Id,
                (game, studio) => new GameWithStudio
                {
                    GameName = game.Name,
                    StudioName = studio.Name,
                    NumberOfPlayers = game.Players.Count
                }
            )
            .ToList();

        return gamesWithStudio;
    }

    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        var distinctGameTypes = Games
            .Select(game => game.GameType)
            .Distinct()
            .ToList();

        return distinctGameTypes;
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        var result = GameStudios
            .Select(studio => new StudioGamesPlayers
            {
                GameStudioName = studio.Name,
                Games = Games
                    .Where(game => game.DeveloperStudio == studio.Id)
                    .Select(game => new GamePlayer
                    {
                        GameName = game.Name,
                        Players = Players
                            .Where(player => game.Players.Contains(player.Id))
                            .ToList()
                    })
                    .ToList()
            })
            .ToList();

        return result;
    }

}
