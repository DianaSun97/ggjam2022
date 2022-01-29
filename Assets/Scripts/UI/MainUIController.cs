using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platformer.UI
{
    public class MainUIController : MonoBehaviour
    {
        public void StartGame()
        {
            Debug.Log("New game!");
            SceneManager.LoadScene("Scenes/GameScene");
        }

        public void QuitGame()
        {
            Debug.Log("Quit!");
            Application.Quit();
        }
    }
}