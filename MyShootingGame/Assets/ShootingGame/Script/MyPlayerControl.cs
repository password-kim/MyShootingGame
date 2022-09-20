using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerControl : MonoBehaviour
{
    private Transform myTransform; // 트랜스폼 캐싱용도.

    public float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 키를 입력하면 -1, 오른쪽 키를 입력하면 +1.
        float moveAmountX = Input.GetAxis("Horizontal");
        float moveAmountY = Input.GetAxis("Vertical");

        // 매 프레임 이동할 이동 벡터.
        Vector3 moveDirectionX = Vector3.right * moveAmountX * moveSpeed * Time.deltaTime;
        Vector3 moveDirectionY = Vector3.up * moveAmountY * moveSpeed * Time.deltaTime;

        myTransform.Translate(moveDirectionX + moveDirectionY);

    }
}
