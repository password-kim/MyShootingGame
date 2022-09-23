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
        // 1. 일정 시간 경과 후 삭제.
        // Destroy(gameObject, delayTime);

        // 2. 일정 시간 경과
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // 2. 생성된 시간으로부터 원하는 지연시간 뒤에 삭제.
        if(Time.time > currentTime + delayTime)
        {
            Destroy(gameObject);
        }
    }
}
