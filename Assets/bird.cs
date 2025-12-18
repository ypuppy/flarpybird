using UnityEngine;
using UnityEngine.InputSystem;


public class bird : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public Logic logic;
    public bool birdIsAlive = true;
    public float upperBound = 27;
    public float lowerBound = -27;
    public bool gameStarted = false;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic")
                          .GetComponent<Logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive)
        {
            myrigidbody.linearVelocity = Vector2.up * flapstrength;
            //gameStarted = true;
        }

        if (birdIsAlive &&
       (transform.position.y > upperBound || transform.position.y < lowerBound))
        {
            logic.gameOver();
            birdIsAlive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
