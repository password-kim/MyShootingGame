using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerControl : MonoBehaviour
{
    private Transform myTransform; // Ʈ������ ĳ�̿뵵.

    public float moveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���� Ű�� �Է��ϸ� -1, ������ Ű�� �Է��ϸ� +1.
        float moveAmountX = Input.GetAxis("Horizontal");
        float moveAmountY = Input.GetAxis("Vertical");

        // �� ������ �̵��� �̵� ����.
        Vector3 moveDirectionX = Vector3.right * moveAmountX * moveSpeed * Time.deltaTime;
        Vector3 moveDirectionY = Vector3.up * moveAmountY * moveSpeed * Time.deltaTime;

        myTransform.Translate(moveDirectionX + moveDirectionY);

    }
}
