using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    private Transform myTransform = null;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = Vector3.up * moveSpeed * Time.deltaTime;
        myTransform.Translate(moveVector);

        if (myTransform.position.y > 10f)
        {
            Destroy(gameObject);
        }

    }
}
