using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exit : MonoBehaviour
{
    
    private void Start()
    {
        
        Button exitButton = GetComponent<Button>();
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitButtonClick);
        }
    }

    private void ExitButtonClick()
    {
        
        Debug.Log("Exit button clicked");

        // Call the function to exit the application
        ExitApplication();
    }

    private void ExitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}

