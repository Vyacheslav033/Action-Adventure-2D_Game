using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using UnityEngine.PlayerLoop;


public class EndCutScene : MonoBehaviour
{
    void Update()
    {
        if (gameObject.GetComponent<PlayableDirector>().time >= 10.3)
        {
            Invoke("EndScene", 3);
        }
        
    }

    private void EndScene()
    {
        SceneManager.LoadScene(0);
    }
}
