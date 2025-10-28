using Newtonsoft.Json.Converters;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player I;

    public Animator animator;
    
    public float speed = 5;
    public bool canMove=true;

    //Talked with the Chamelen;
    public bool hasTalked; 
    public bool hasKnockOffFlowerPot; 


    // Start is called before the first frame update
    void Start()
    {
        I = this;
    }

    public void PlayerCanMove(bool canMove) 
    {
        this.canMove = canMove;
    }

    // Update is called once per frame
    void Update()
    {

        if (canMove==false) return;

        //Ctrl Animator
        animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetFloat("Horizontal", 0);
        }

        //Move Player Sprite.
        Vector3 horizontal;
        //Vector3 horizontal = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        var vertical = new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        if (Input.GetAxisRaw("Vertical") != 0)
        {
             horizontal = new Vector3(0f, 0f, 0f);
        }
        else 
        {
             horizontal = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f); 
        }


        transform.position = transform.position + vertical * Time.deltaTime * speed;
        transform.position = transform.position + horizontal * Time.deltaTime * speed;

 
    }
}
