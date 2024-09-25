using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField]
    string LevelMainMenu;
    [SerializeField]
    string LevelToReplay;
public void mainmenu()
    {
        SceneManager.LoadScene(LevelMainMenu);
    }

    public void replay()
    {
        SceneManager.LoadScene(LevelToReplay);
    }
}
