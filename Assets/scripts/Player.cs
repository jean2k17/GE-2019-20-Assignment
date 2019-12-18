using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myrigidbody;
    public float speed;
    private float jumpForce = 20;
    public float jumpmax;
    private float jumptime;
    private bool doublejump;

    public bool isgrounded;
    public LayerMask groundis;
    public Transform groundcheck;
    public float groundradius;
    public Game thegame;

    public AudioSource jumpsound;
    public AudioSource deathsound;

    //private Collider2D mycollider;
    private Animator myanimator;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        //mycollider = GetComponent<Collider2D>();
        myanimator = GetComponent<Animator>();
        jumptime = jumpmax;
    }

    // Update is called once per frame
    void Update()
    {
        //isgrounded = Physics2D.IsTouchingLayers(mycollider, groundis);
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, groundradius, groundis);

        myrigidbody.velocity = new Vector2(speed, myrigidbody.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isgrounded)
            {
                myrigidbody.velocity = new Vector2(myrigidbody.velocity.y, jumpForce);
                jumpsound.Play();
            }
            if (!isgrounded && doublejump)
            {
                myrigidbody.velocity = new Vector2(myrigidbody.velocity.y, jumpForce);
                doublejump = false;
                jumpsound.Play();
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(jumptime > 0)
            {
                myrigidbody.velocity = new Vector2(myrigidbody.velocity.y, jumpForce);
                jumptime -= Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            jumptime = 0;
        }
        if (isgrounded)
        {
            jumptime = jumpmax;
            doublejump = true;
        }
        myanimator.SetFloat("speed", myrigidbody.velocity.x);
        myanimator.SetBool("isgrounded", isgrounded);
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.tag == "killbox")
        {
            thegame.RestartGame();
            deathsound.Play();
        }
    }

}
