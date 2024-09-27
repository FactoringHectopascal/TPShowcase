using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossSummon : MonoBehaviour
{
    [SerializeField]
    GameObject minion;
    [SerializeField]
    bool canSpawn = false;

    //DOCUMENTATION: https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html
    // https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
    // https://docs.unity3d.com/Manual/Coroutines.html
    // https://docs.unity3d.com/ScriptReference/Coroutine.html

    void Start()
    {
        if (Time.time > 5)
        {
            StartCoroutine(Spawn());
        }
    }
    public IEnumerator Spawn()
    {
        canSpawn = true;
        Spawnin();
        yield return new WaitForSeconds(2);
    }
    public void Spawnin()
    {
        if (canSpawn == true)
        {
            Instantiate(minion, transform.position, Quaternion.identity);
            canSpawn = false;
        }
    }
}
