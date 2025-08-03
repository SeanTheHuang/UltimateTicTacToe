using System;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game
{
    public enum BoardState
    { 
        None,
        P1,
        P2,

        Count
    }

    public class Board
    {
        public const int c_boardSize = 3;

        private BoardState[] m_tileStates = new BoardState[c_boardSize * c_boardSize];

        public Board() 
        {
            Reset();
        }

        public void Reset()
        {
            for( int i = 0; i < m_tileStates.Length; i++ )
            {
                m_tileStates[i] = BoardState.None;
            }
        }

        public bool SetTile( int _index, BoardState _newState )
        {
            if( _index >= m_tileStates.Length )
                return false;

            m_tileStates[ _index ] = _newState;
            return true;
        }

        public BoardState GetTile( int _index ) 
        {
            if( _index >= m_tileStates.Length )
                return BoardState.None;

            return m_tileStates[ _index ];
        }

        public BoardState GetWinner()
        {
            // Hardcoded checks. Don't think anything fancier is worth it.
            for( int i = 0; i < c_boardSize; ++i )
            {
                // Check horizontal
                int h_index = i * c_boardSize;
                if( m_tileStates[ h_index ] == m_tileStates[ h_index + 1 ] && m_tileStates[ h_index ] == m_tileStates[ h_index + 2 ] )
                    return m_tileStates[ h_index ];

                // Check vertical
                int v_index = i;
                if( m_tileStates[ v_index ] == m_tileStates[ v_index + c_boardSize ] && m_tileStates[ v_index ] == m_tileStates[ v_index + c_boardSize * 2 ] )
                    return m_tileStates[ v_index ];
            }

            // Check top-left diagonal
            if( m_tileStates[ 0 ] == m_tileStates[ c_boardSize + 1 ] && m_tileStates[ 0 ] == m_tileStates[ c_boardSize * 2 + 2 ] )
                return m_tileStates[ 0 ];

            // Check top-right diagonal
            if( m_tileStates[ c_boardSize - 1 ] == m_tileStates[ c_boardSize + 1 ] && m_tileStates[ c_boardSize - 1 ] == m_tileStates[ c_boardSize * 2 ] )
                return m_tileStates[ c_boardSize - 1 ];

            return BoardState.None;
        }

    } // public class Board

} // namespace Game
