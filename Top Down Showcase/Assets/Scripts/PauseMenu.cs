using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if you press the escape key
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
            //make the pause menu visible
            GetComponent<Canvas>().enabled = true;
            //also, stop the game from playing
            Time.timeScale = 0;
            }
            else
            {
                Resume();
            }
        }
    }
    public void Resume()
    {
        //buttons can only run public functions
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void Retry()
    {
        //SET THE TIME TO NORMAL
        Time.timeScale = 1;
        //GET THE ACTIVE SCENE AND LOAD IT
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
       //Buttons want objects to run the script off of. 
       //DO NOT USE THE SCRIPT.
       //Use the PauseMenu (object) as the object, since it already contains this script.
       //Once you do that, you call call the function from on click ()
       //It becomes its own entity when declared, meaning you can call it from anywhere. 
       //Even from literally your own update function
       //Parenthesis are because it needs to be built in the same way so that it could receive 
       //information
