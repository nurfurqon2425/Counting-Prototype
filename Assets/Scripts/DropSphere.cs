using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSphere : MonoBehaviour
{
    [SerializeField]
    private GameObject spherePrefab;
    private float startDelay = 0.5f;
    private float spawnRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSphere", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSphere()
    {
        spherePrefab.transform.position = new Vector3(Random.Range(-20.0f, 20.0f), 12.0f, 0.0f);
        Instantiate(spherePrefab, spherePrefab.transform.position, spherePrefab.transform.rotation);
    }
}
