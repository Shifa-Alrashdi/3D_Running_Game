using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadDestrory : MonoBehaviour
{
    public GameObject road;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyRoad", 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destroyRoad()
    {
        if (UI.institite.isPlay == true)
        {
            Destroy(road);
        }
    }
}
