using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class Killcount : MonoBehaviour {
    //Keep count
    public Text countText;
    //win you win
    public Text winText;
    public float speed;  //Floating point variable to store the player's movement speed. 
    private int Count;
    public Scene scene;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        Count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");
       
        //Use the two store floats to create a new Vector3 variable movement.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        //Check the provided Collider parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Pickup"))
        {
            //... then set the other object we just collided with to inactive.
            other.gameObject.SetActive(false);
            Count = Count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + Count.ToString();
        if (Count >= 4)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
