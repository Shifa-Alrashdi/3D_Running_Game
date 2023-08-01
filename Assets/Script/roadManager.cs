using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadManager : MonoBehaviour
{

    
    public GameObject[] road;
    public GameObject[] road2;
    public int z=18;
    float increaseTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createroad", 3, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void createroad()
    {   
        if (UI.institite.isPlay == true)
        {
            //road ={ prefab, prefab2, prefab3 };
            GameObject roadd;
            roadd = Instantiate(road[Random.Range(0, 3)]) as GameObject;
            roadd.transform.position = new Vector3(0, 0, z);
            
            z = z + 6;
            
            //Destroy(roadd);
        }
       
        
    }
}
