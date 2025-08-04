using UnityEngine;

namespace Game
{
    public class BoardManager
    {
        private Board[] m_boards = new Board[ Board.c_tileCount ];

        public BoardManager()
        {
            for( int i = 0; i < m_boards.Length; ++i )
            {
                m_boards[ i ] = new Board();
            }

            ResetGame();
        }

        public void ResetGame()
        {
            for( int i = 0; i < m_boards.Length; ++i )
            {
                m_boards[ i ].Reset();
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

        public bool SetTile( int _boardIndex, int _tileIndex, BoardState _newState )
        {
            if( _boardIndex >= m_boards.Length )
                return false;

            bool success = m_boards[ _boardIndex ].SetTile( _tileIndex, _newState );
            return success;
        }

        public BoardState GetTile( int _boardIndex, int _tileIndex )
        {
            if( _boardIndex >= m_boards.Length )
                return BoardState.None;

            return m_boards[ _boardIndex ].GetTile( _tileIndex );
        }

    } // public class BoardManager

} // namespace Game
