using UnityEngine;
using UnityEngine.UI;


    public class LoginUI : MonoBehaviour
    {
        public Button hostButton;

        public void ToggleButtons(string username)
        {
            hostButton.interactable = !string.IsNullOrWhiteSpace(username);
        }
    }
