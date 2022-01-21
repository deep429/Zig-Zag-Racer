using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed;
    bool left = true;
    bool FirstTap = true;
    public float downward;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.Instance.GameStarted)
        {
            move();
            CheckInput();
        }
        if(rb.position.y <= -3f)
        {
            Restart();
        }

        if(rb.position.y<0.56f)
        {
                rb.AddForce(0, downward, 0);       
         }
    }
    

    void move()
    {
        transform.position += transform.forward * movespeed * Time.deltaTime;

    }
    void CheckInput()
    {
        if (FirstTap)
        {
            FirstTap = false;
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
        }
    }
    void ChangeDirection()
    {
        if (left)
        {
            left = false;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else
        {
            left = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");

    }

    
    
}


