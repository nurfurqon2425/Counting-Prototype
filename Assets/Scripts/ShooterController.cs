using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;
    [SerializeField]
    private GameObject barrel;
        
    private Vector3 rotationAngle;

    // Start is called before the first frame update
    void Start()
    {
        rotationAngle = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.rotation.z >= 0)
        //{
        //    rotationAngle = Vector3.zero;
        //}
        //else if (transform.rotation.z <= -90)
        //{
        //    rotationAngle = Vector3.zero;
        //}

        if (Input.GetKey(KeyCode.A))
        {
            rotationAngle = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotationAngle = Vector3.back;
        }
        else
        {
            rotationAngle = Vector3.zero;
        }

        transform.Rotate(rotationAngle);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBall();
        }
    }

    private void ShootBall()
    {      
        GameObject gameObj = Instantiate(ballPrefab, barrel.transform.position, transform.rotation);
        Rigidbody ballRb = gameObj.GetComponent<Rigidbody>();
        ballRb.AddRelativeForce(Vector3.up * 1500.0f, ForceMode.Force);
    }
}
