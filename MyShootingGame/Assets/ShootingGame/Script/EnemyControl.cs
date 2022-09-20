using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private Transform myTransform;

    public float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector3.down * moveSpeed * Time.deltaTime;

        myTransform.Translate(moveDirection);

        if(myTransform.position.y < -5.2f)
        {
            myTransform.position = new Vector3(Random.Range(-8.0f, 8.0f), 6.0f, 0f);
        }
    }
}
