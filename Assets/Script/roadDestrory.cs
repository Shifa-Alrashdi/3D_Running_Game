//Script to destroy the road 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadDestrory : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //Call functio that destroy the road after 60 sec
        Invoke("destroyRoad", 60);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Function to destroy the road
    public void destroyRoad()
    {

        if (UI.institite.isPlay == true)
        {
           
                Destroy(gameObject);
            
        }
    }
}

