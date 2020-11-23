using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerBehaviour : MonoBehaviour
{
    //movemint
    private Transform playerTransform;
    public float speed;

    //bullet related stuff
    public GameObject bulletFired;
    public float fireRate;
    private float nextFire;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveH, 0, 0);
        playerTransform.position += movement * speed;

        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            Instantiate(bulletFired, playerTransform.position, playerTransform.rotation);
            nextFire = Time.time + fireRate;
        }
    }
}
