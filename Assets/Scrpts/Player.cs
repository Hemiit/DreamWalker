using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
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
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        var vertical = new Vector3(0f, Input.GetAxis("Vertical"), 0f);

        transform.position = transform.position + horizontal * Time.deltaTime * speed;
        transform.position = transform.position + vertical * Time.deltaTime * speed;
    }
}
