using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    [SerializeField]
    private string _gameSceneName = "Menu";
    private void Update()
    {
        if (InputManager.EscWasPressed)
        {
            ExitGame();
        }
    }

    private void ExitGame()
    {
        SceneManager.LoadScene(_gameSceneName);
    }
}
