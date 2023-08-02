using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadDestrory : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyRoad", 60);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void destroyRoad()
    {
        
        if (UI.institite.isPlay == true)
        {
           
                Destroy(gameObject);
            
        }
    }
}

