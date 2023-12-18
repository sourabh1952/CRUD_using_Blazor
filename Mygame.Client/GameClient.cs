using System;
using System.Collections.Generic;
using Mygame.Client.Models;


namespace Mygame.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id=1,
            Name="sourabh",
            Genre="fighting",
            Price=19.5M,
            ReleaseDate = new DateTime(1992,1,1)
        },
        new Game()
        {
            Id=2,
            Name="sourabh",
            Genre="fighting",
            Price=19.5M,
            ReleaseDate = new DateTime(1992,1,1)
        },
        new Game()
        {
            Id=3,
            Name="sourabh",
            Genre="fighting",
            Price=19.5M,
            ReleaseDate = new DateTime(1992,1,1)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static  void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public static Game GetGame(int Id)
    {
        return games.Find(game => game.Id==Id) ?? throw new Exception("not able to find that game!");

    }

    public static void UpdateGame(Game updatedGame)
    {
        Game priv = GetGame(updatedGame.Id);
        priv.Name = updatedGame.Name;
        priv.Genre = updatedGame.Genre;
        priv.Price = updatedGame.Price;
        priv.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }
}