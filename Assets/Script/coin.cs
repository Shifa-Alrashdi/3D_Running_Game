using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    Animator coinAnimator;

    // Start is called before the first frame update
    void Start()
    {
        coinAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            {
            coinAnimator.SetTrigger("rotate to scale");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            coinAnimator.SetTrigger("scale to rotate");
        }
    }
}
