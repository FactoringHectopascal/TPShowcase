using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    string LevelToLoad = "Level 1";
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
    }
public void start()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    public void quit()
    {
        Application.Quit();
    }
}
