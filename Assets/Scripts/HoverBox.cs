using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverBox : MonoBehaviour
{
    Vector3[] direction = {Vector3.up, Vector3.down, Vector3.right, Vector3.left};

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveBox());
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 50)
        {
            transform.position = new Vector3(50, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }

        if (transform.position.y > 10)
        {
            transform.position = new Vector3(transform.position.x, 10, transform.position.z);
        }
        else if (transform.position.y < -8)
        {
            transform.position = new Vector3(transform.position.x, -8, transform.position.z);
        }
    }

    IEnumerator MoveBox()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);

            float speed = Random.Range(5.0f, 10.0f);
            int dirIndex = Random.Range(0, direction.Length);
            transform.Translate(direction[dirIndex] * speed);
        }
    }

}
