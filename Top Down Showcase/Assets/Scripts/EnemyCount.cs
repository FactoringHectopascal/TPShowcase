using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCount : MonoBehaviour
{
    //https://docs.unity3d.com/ScriptReference/GameObject.Find.html
    //Get Started HERE Friend!
    //https://docs.unity3d.com/ScriptReference/GameObject.FindWithTag.html
    [SerializeField]
    string LevelToLoad;
    void Start()
    {

    }
    void Update()
    {
    if(GameObject.FindGameObjectsWithTag("Enemy").Length < 1)
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
