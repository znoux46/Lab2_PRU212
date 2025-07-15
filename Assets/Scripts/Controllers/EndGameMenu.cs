// --- SCRIPT: EndGameMenu.cs ---
// Attach this script to a GameObject in your End Game Scene (e.g., a UI Manager object).

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameMenu : MonoBehaviour
{
    // Called when the "Return to Main Menu" button is clicked
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // Load the Main Menu Scene
    }

    // Called when the "Quit Game" button is clicked
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game from End Game Scene...");
    }
}
