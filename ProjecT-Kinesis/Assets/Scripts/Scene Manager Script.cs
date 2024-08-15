using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
