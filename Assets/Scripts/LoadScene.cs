using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public string levelname;
    public void LoadScene()
    {
        SceneManager.LoadScene(levelname);
    }
}