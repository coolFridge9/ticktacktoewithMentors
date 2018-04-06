using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class RendererShould
    {
        [Fact]
        public void Render3x3EmptyBoard()
        {
            var board = new Board();
            var renderer = new Renderer();
            var player1 = new Player('x',new HumanMover());
            var players = new List<Player> {player1};
            var result = renderer.RenderBoard(players);

            const string expected = "...\n" +
                                    "...\n" +
                                    "...\n";
            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Render3x3SingleMoveBoard()
        {
            var renderer = new Renderer();
            var player1 = new Player('x',new HumanMover());
            player1.AddMove(new Move(1,1));
            player1.AddMove(new Move(1,2));
            var players = new List<Player> {player1};
            
            var result = renderer.RenderBoard(players);

            const string expected = "xx.\n" +
                                    "...\n" +
                                    "...\n";
            
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Render3x3playersMoveBoard()
        {
            var renderer = new Renderer();
            var player1 = new Player('x',new HumanMover());
            var player2 = new Player('o',new HumanMover());
            player1.AddMove(new Move(1,1));
            player1.AddMove(new Move(1,2));
            player2.AddMove(new Move(2,2));
            player2.AddMove(new Move(3,3));

            var players = new List<Player> {player1, player2};

            var result = renderer.RenderBoard(players);

            const string expected = "xx.\n" +
                                    ".o.\n" +
                                    "..o\n";
            
            Assert.Equal(expected, result);
        }
    }
}