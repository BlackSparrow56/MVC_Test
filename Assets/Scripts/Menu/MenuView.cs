using System;
using Menu.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class MenuView : MonoBehaviour, IMenuView
    {
        public event Action OnPlayRequested = () => { };
        public event Action OnExitRequested = () => { };

        [SerializeField] private Button playButton;
        [SerializeField] private Button exitButton;

        private void Play()
        {
            OnPlayRequested.Invoke();
        }

        private void Exit()
        {
            OnExitRequested.Invoke();
        }

        private void OnEnable()
        {
            playButton.onClick.AddListener(Play);
            exitButton.onClick.AddListener(Exit);
        }

        private void OnDisable()
        {
            playButton.onClick.RemoveListener(Play);
            exitButton.onClick.RemoveListener(Exit);
        }
    }
}
