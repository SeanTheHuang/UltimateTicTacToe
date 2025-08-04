using Unity.VisualScripting;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        private BoardManager m_board = new BoardManager();
        private BoardState m_activePlayer = BoardState.None;
        private int? m_activeBoardIndex = null; // null means player can place tile in any board

        public void Awake()
        {

        }

        public void Start()
        {

        }

        public void Update()
        {

        }
    }

} // namespace Game
