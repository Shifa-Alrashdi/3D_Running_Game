using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public static player2 institite;
    float speed = 3.5f;
    public int score = 0;

    string[] road;

    Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
          if (institite == null)
          institite = this;

         playerAnimator = GetComponent<Animator>();
        //coinCollection = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.institite.isPlay == true)
        {
            playerAnimator.SetTrigger("idle to run");
            transform.position += transform.forward * speed * Time.deltaTime;

            if (transform.position.x < 1 && Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += transform.right * speed * Time.deltaTime;

            }

            if (transform.position.x > -1 && Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= transform.right * speed * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += transform.up * speed * Time.deltaTime;

            }
            speed = speed + 0.001f; ;
        }
       
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score++;
            UI.institite.scoreText.SetText("SCORE: " + score.ToString());
            /*
            coinCollection.Stop();
            coinCollection.clip = CoinIncrease;
            coinCollection.Play();
            //scoreText.text = "SCORE: " + score.ToString();
            */
        }
        if (collision.gameObject.tag == "bomb")
        {
            Destroy(collision.gameObject);
            score--;
            UI.institite.scoreText.SetText("SCORE: " + score.ToString());
            /*
            coinCollection.Stop();
            coinCollection.clip = CoinDecrease;
            coinCollection.Play();
            //scoreText.text = "SCORE: " + score.ToString();
            */
        }

    }
}
