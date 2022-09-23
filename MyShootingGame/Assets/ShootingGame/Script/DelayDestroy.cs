using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestroy : MonoBehaviour
{
    public float delayTime = 1f;

    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // 1. ���� �ð� ��� �� ����.
        // Destroy(gameObject, delayTime);

        // 2. ���� �ð� ���
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // 2. ������ �ð����κ��� ���ϴ� �����ð� �ڿ� ����.
        if(Time.time > currentTime + delayTime)
        {
            Destroy(gameObject);
        }
    }
}
