﻿using System;
using TicTacToe;
using Xunit;

namespace Tests.TicTacToe {

    public class BoardTest {

        private Board board;
        
        public BoardTest() {
            this.board = new Board();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        public void AddMarkerToGameBoard(int move) {
           
            string[] updatedBoard = this.board.GameBoard;
            string[] gameBoard = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            gameBoard[move] = "X";
            this.board.UpdateBoard(move);

            Assert.Equal(gameBoard, updatedBoard);
        }

    }
}