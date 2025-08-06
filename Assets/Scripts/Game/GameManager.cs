using Unity.VisualScripting;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(BoardVisualsManager))]
    public class GameManager : MonoBehaviour
    {
        private BoardVisualsManager m_boardVisuals = null;
        private BoardManager m_board = new BoardManager();
        private BoardState m_activePlayer = BoardState.None;
        private int? m_activeBoardIndex = null; // null means player can place tile in any board

        public void Awake()
        {
            m_boardVisuals = GetComponent<BoardVisualsManager>();
        }

        public void Start()
        {

        }

        public void Update()
        {

        }
    }

} // namespace Game
