using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float zDestroy = -10f;

    private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GoDown();

        DestroyOnLimit();
    }

    void GoDown()
    {
        objectRb.AddForce(Vector3.forward * -speed);
    }

    void DestroyOnLimit()
    {
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
