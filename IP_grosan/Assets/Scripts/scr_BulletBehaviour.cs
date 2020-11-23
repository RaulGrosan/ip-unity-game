using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_BulletBehaviour : MonoBehaviour
{
    private Transform bulletTransform;
    public float speed;

    public GameObject enemyRespawnPrefab;

    // Start is called before the first frame update
    void Start()
    {
        bulletTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletTransform.position += Vector3.up * speed;

        if(bulletTransform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Vector3 enemyRespawnPosition = new Vector3(Random.Range(-9,9), 6, 0);
            Instantiate(enemyRespawnPrefab, enemyRespawnPosition, Quaternion.identity);
            Instantiate(enemyRespawnPrefab, enemyRespawnPosition, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
