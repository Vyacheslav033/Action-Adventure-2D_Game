using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenUIManager : MonoBehaviour
{
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("CutScene");
    }

    public void SettingsButtonClicked()
    {
        // TODO: настройки
    }

    public void ExitButtonClicked()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
