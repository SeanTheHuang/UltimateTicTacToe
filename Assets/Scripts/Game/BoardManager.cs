using UnityEngine;

namespace Game
{
    public class BoardManager
    {
        private Board[] m_boards = new Board[ Board.c_boardSize * Board.c_boardSize ];

        private int? m_currentBoardIndex = null; // When null, all boards are valid

        BoardManager()
        {
            ResetGame();
        }

        public void ResetGame()
        { 
            for( int i = 0; i < m_boards.Length; ++i ) 
            {
                m_boards[i].Reset(); 
            }
        }

        public BoardState GetWinner()
        {
            var temp_board = new Board();
            for( int i = 0; i < m_boards.Length; ++i )
            {
                temp_board.SetTile( i, m_boards[ i ].GetWinner() );
            }

            return temp_board.GetWinner();
        }

    } // public class BoardManager

} // namespace Game
