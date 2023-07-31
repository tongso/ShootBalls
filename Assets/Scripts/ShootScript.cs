using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            GameObject newBulltBall = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rd = newBulltBall.GetComponent<Rigidbody>();
            rd.velocity = Vector3.forward* 30;
        }
    }
}
