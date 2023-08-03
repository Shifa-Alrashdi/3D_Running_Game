//Script to control character move
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    //Initiate variable
    public static player2 institite;
    public float speed = 3;
    public int score = 0;
    public int live = 3;
    public ParticleSystem effect;
    string[] road;
    public GameObject player;
    public AudioClip CoinIncrease, CoinDecrease, GameOver;
    AudioSource coinCollection;
    public GameObject heart, playerSoul;
    Animator playerAnimator;
    public GameOver gameover;
    Rigidbody rigidbodyy;

    // Start is called before the first frame update
    void Start()
    {
          if (institite == null)
          institite = this;

        //Get component
         playerAnimator = GetComponent<Animator>();
         rigidbodyy = GetComponent<Rigidbody>();
         coinCollection = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.institite.isPlay == true)
        {
            effect.Play();

            //Tranform the character move to run
            playerAnimator.SetTrigger("idle to run");

            //Start the character to run forward
            transform.position += transform.forward * speed * Time.deltaTime;

            //Right move
            if (transform.position.x < 1 && Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += transform.right * speed * Time.deltaTime;

            }

            //Left move
            if (transform.position.x > -1 && Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= transform.right * speed * Time.deltaTime;

            }

            //Gump move
            if (transform.position.y < 3 && Input.GetKey(KeyCode.UpArrow))
            {
                rigidbodyy.AddForce(Vector3.up * 0.1f, ForceMode.Impulse);
            }
            //speed = speed + 0.001f; ;
        }
       
    }
    public void OnCollisionEnter(Collision collision)
    {
        //Collect the coins
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score++;
            UI.institite.scoreText.SetText("SCORE: " + score.ToString());
            
            coinCollection.Stop();
            coinCollection.clip = CoinIncrease;
            coinCollection.Play();
        }

        //Hit the enemies
        if (collision.gameObject.tag == "enemies")
        {
            Destroy(collision.gameObject);
            live--;
            UI.institite.liveText.SetText(": " + live.ToString());
            
            if (live > 0)
        {
                coinCollection.Stop();
                coinCollection.clip = CoinDecrease;
                coinCollection.Play();
        }
             
            //Game Over
             if (live == 0)
        {
                
           
                gameover.setup();
                UI.institite.FinalScore.SetText("Your Score: " + score.ToString());
                UI.institite.liveText.SetText(" ");
                UI.institite.timerText.SetText(" ");
                UI.institite.scoreText.SetText(" ");
                heart.SetActive(false);
                UI.institite.isPlay = false;
                coinCollection.Stop();
                coinCollection.clip = GameOver;
                coinCollection.Play();
                playerSoul.SetActive(false);

            }
        }
        
       

    }
}
