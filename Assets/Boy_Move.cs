using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boy_Move : MonoBehaviour
{
    public Animator anmtn;
    public Rigidbody2D rb;
    public int jumpspeed;
    public int speed;
    float x, y;
    /*public GameObject winning_text;
    public GameObject gameOver_text;*/
    public TMP_Text score_text;
    int score_value = 0;
    public GameObject win_panel;
    public GameObject enemy_panel;
    public static bool isGrounded;
    public float Dmax, Dmin;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
       // y = Input.GetAxis("Jump");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
        //rb.AddForce(y * jumpspeed * transform.up);
        score_text.text = score_value.ToString();    
        
        if ( Input.GetKey(KeyCode.D) )
        {
            anmtn.SetBool("is_Walking", true);
            //rgd.velocity = new Vector2(1.5f, 0);
        }
        else
        {
            anmtn.SetBool("is_Walking", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            anmtn.SetBool("is_Backward", true);
            //rgd.velocity = new  Vector2(-0.5f, 0);
        }
        else
        {
            anmtn.SetBool("is_Backward", false);
        }

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            anmtn.SetBool("is_Jumping", true);
            rb.AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);
            //rgd.velocity = new Vector2(0.5f, 0);
        }
         else
        {
            anmtn.SetBool("is_Jumping", false);
        }
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, Dmin, Dmax), transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            enemy_panel.SetActive(true);
        }
        if (collision.gameObject.tag == "Points")
        {
            collision.gameObject.SetActive(false);
            score_value++;
        }
        if (collision.gameObject.tag == "Win")
        {
            gameObject.SetActive(true);
            Time.timeScale = 0;
            win_panel.SetActive(true);
        }
    }
}
