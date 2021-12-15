using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class EndGame : MonoBehaviour
{
    void Update()
    {
        if (gameObject.GetComponent<PlayableDirector>().time >= 7)
        {
            Invoke("CloseGame", 3);
        }

    }

    private void CloseGame()
    {
        Application.Quit();
    }
}
