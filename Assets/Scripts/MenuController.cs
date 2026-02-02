using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private string _gameSceneName = "Gameplay";

    private void OnEnable()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();
        if (uiDocument == null)
        {
            Debug.LogError("no UIDocument");
            return;
        }
        
        Button startButton = uiDocument.rootVisualElement.Q<Button>("StartButton");
        if (startButton != null)
        {
            startButton.clicked += OnStartButtonClicked;
        }
        else
        {
            Debug.LogError("StartButton not found ");
        }
            
    }

    private void Update()
    {
        if (InputManager.EscWasPressed)
        {
            ExitGame();
        }
    }

    private void OnStartButtonClicked()
    {
        SceneManager.LoadScene(_gameSceneName);
    }

    private void ExitGame()
    {
#if UNITY_EDITOR
        Debug.Log("quit");
#else
        Application.Quit();
#endif
    }
}

