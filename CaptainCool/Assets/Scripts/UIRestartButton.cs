using UnityEngine;
using UnityEngine.SceneManagement;

public class UIRestartButton : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
