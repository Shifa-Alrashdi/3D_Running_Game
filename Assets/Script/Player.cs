using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //forword movement
        /*
        if (transform.position.z < 5 &&  Input.GetKey(KeyCode.UpArrow))
        { 
             transform.position += transform.forward * speed * Time.deltaTime ;
        }*/
        if ( Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        //Right movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;

        }

        //backword movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        //left movement
        if ( Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;

        }
    }

    public void OnCollisionEnter(Collision collision)
    { 
    if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            print("collision");
        }

}
}
