using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadManager : MonoBehaviour
{

    
    public GameObject[] road;
    public int z;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createroad", 0.01f, 0.1f);
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
            roadd = Instantiate(road[Random.Range(0, 2)]) as GameObject;
            roadd.transform.position = new Vector3(0, 0, z);
            z = z + 6;
            //Destroy(roadd);
        }
        
    }
}
