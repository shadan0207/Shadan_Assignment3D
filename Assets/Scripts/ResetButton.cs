using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    private void Start()
    {
        // Attach the button click event
        Button resetButton = GetComponent<Button>();
        if (resetButton != null)
        {
            resetButton.onClick.AddListener(ResetButtonClick);
        }
    }

    private void ResetButtonClick()
    {
        // This function will be called when the button is clicked
        Debug.Log("Reset button clicked");

        // Call the function to reset the scene
        ResetScene();
    }

    private void ResetScene()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
