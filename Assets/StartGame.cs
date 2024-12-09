using UnityEngine;
using System.Collections.Generic;
using system.Collections;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour
{
    public string LevelName;

    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
