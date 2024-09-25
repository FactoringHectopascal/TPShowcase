using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseScreen : MonoBehaviour
{
    [SerializeField]
    string Retry;
    [SerializeField]
    string Menu;
    public void replay()
    {
        SceneManager.LoadScene(Retry);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(Menu);
    }
}
