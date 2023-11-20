using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PengelolaScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("QUIT GAME!!!");
    }
}