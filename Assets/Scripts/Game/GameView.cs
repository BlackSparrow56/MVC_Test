using System;
using Game.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class GameView : MonoBehaviour, IGameView
    {
        public event Action OnBackRequested = () => { };

        [SerializeField] private Button backButton;

        private void Back()
        {
            OnBackRequested.Invoke();
        }

        private void OnEnable()
        {
            backButton.onClick.AddListener(Back);
        }

        private void OnDisable()
        {
            backButton.onClick.RemoveListener(Back);
        }
    }
}