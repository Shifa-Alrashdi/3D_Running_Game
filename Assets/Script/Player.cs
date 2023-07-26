using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public static Player institite;
    float speed = 5.5f;
    public int score = 0;
    //public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (institite == null)
            institite = this;
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
            score++;
            UI.institite.scoreText.SetText("SCORE: " + score.ToString()) ;
            //scoreText.text = "SCORE: " + score.ToString();
        }
    }
}
