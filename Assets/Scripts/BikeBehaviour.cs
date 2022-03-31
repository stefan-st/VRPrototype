using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class BikeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed;
    private Rigidbody rigidBody;

    private bool isMoving = true;
    void Start()
    {
        speed = Random.Range(1.0f, 5.0f);
        transform.position += Vector3.forward * Random.Range(0.0f, 4.0f);
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = -speed * Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.position -= speed * Vector3.right * Time.deltaTime;

            if (transform.position.x < -70) Destroy(gameObject);
        }
        else
        {
            if (transform.position.x < 100)
                transform.position += speed * Vector3.up * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = -speed * Vector3.right * Time.fixedDeltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") isMoving = false;
        // rigidBody.useGravity = false;
        // rigidBody.AddExplosionForce(20, transform.position, 2);
    }
}
