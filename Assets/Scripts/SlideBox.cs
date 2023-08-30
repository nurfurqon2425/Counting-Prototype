using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBox : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x >= 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }

    }

    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * Time.deltaTime * speed);
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * Time.deltaTime * speed);
        //}

    }
}
