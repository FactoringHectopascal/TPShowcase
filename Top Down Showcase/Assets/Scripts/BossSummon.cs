using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossSummon : MonoBehaviour
{
    [SerializeField]
    GameObject minion;
    //[SerializeField]
    //bool canSpawn = true;
    [SerializeField]
    float spawnTimerSeconds = 5f;
    int spawnTimer; // initialized in Start()

    

    //DOCUMENTATION: https://docs.unity3d.com/ScriptReference/MonoBehaviour.StartCoroutine.html
    // https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
    // https://docs.unity3d.com/Manual/Coroutines.html
    // https://docs.unity3d.com/ScriptReference/Coroutine.html

    void Start()
    {
        //StartCoroutine(Spawn());
        spawnTimer = (int)(spawnTimerSeconds / Time.deltaTime);
        // changes it to an int, then divides the seconds by the delta time (how much per frame)
    }
    private void Update()
    {
        spawnTimer--;
        if (GameObject.FindGameObjectsWithTag("minion").Length < 5)
        {
            if (spawnTimer <= 0)
            {
                Instantiate(minion, new Vector2(transform.position.x + 2, transform.position.y + 2), Quaternion.identity);
                spawnTimer = (int)(spawnTimerSeconds / Time.deltaTime);
            }
        }
    }


//    public IEnumerator Spawn()
//    {
//        //canSpawn = true;
//        //yield return new WaitForSeconds(5);
//        //Spawnin();

//        while (true)
//        {
//            yield return new WaitForSeconds(5);
//            Instantiate(minion, transform.position, Quaternion.identity);
//        }

//    }
//    //public void Spawnin()
//    //{
//    //    if (canSpawn == true)
//    //    {
//    //        Instantiate(minion, transform.position, Quaternion.identity);
//    //        canSpawn = false;
//    //       StartCoroutine(Spawn());
//    //    }
//    //}

}
