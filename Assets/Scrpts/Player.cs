using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public static Player I;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        I = this;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        

        Vector3 horizontal = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        var vertical = new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);

        transform.position = transform.position + horizontal * Time.deltaTime * speed;
        transform.position = transform.position + vertical * Time.deltaTime * speed;
    }
}
