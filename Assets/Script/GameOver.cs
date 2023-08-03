using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Show Game over panel
    public void setup() {
        gameObject.SetActive(true);
    }

    //Restart the game
    public void restart() {
        SceneManager.LoadScene("VRGame");
    }
   
    
}
