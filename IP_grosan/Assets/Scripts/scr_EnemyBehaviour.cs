using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_EnemyBehaviour : MonoBehaviour
{
    private Transform enemyTransform;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        enemyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyTransform.position += Vector3.down * speed;
    }
}
