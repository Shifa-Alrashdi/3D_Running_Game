using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createCoin", 0.1f,2);
        InvokeRepeating("createbomb", 0.1f, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createCoin()
    {
        if (UI.institite.isPlay == true)
        {
            GameObject coin;
            coin = Instantiate(prefab) as GameObject;
            coin.transform.position = new Vector3(Random.Range(-4.8f, 4.8f), 0.5f, Random.Range(-4.8f, 4.8f));
        }
    }
    void createbomb()
    {
        if (UI.institite.isPlay == true)
        {
            GameObject bomb;
            bomb = Instantiate(prefab2) as GameObject;
            bomb.transform.position = new Vector3(Random.Range(-4.8f, 4.8f), 0.5f, Random.Range(-4.8f, 4.8f));
        }
    }
}
