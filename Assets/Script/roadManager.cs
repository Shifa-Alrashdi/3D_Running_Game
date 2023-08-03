//Script to create random road
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadManager : MonoBehaviour
{

    //intiate variable
    public GameObject[] road;
    public int Z =18;
 
    // Start is called before the first frame update
    void Start()
    {
        //Call function that create the road
        InvokeRepeating("createroad", 4, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Function to create random road
    void createroad()
    {   
        if (UI.institite.isPlay == true)
        {
            
            GameObject roadd;
            roadd = Instantiate(road[Random.Range(0, 3)]) as GameObject;
            roadd.transform.position = new Vector3(0, 0, Z);
            Z = Z + 6;
            print(Z);
            
            
        }
       
        
    }
}
