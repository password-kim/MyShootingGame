using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyControl : MonoBehaviour
{
    private Transform myTransform;

    public float moveSpeed = 5.0f;

    public GameObject explosionEffect = null;

    // UI
    private int score = 0;

    public TextMeshProUGUI textScore = null;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector3.down * moveSpeed * Time.deltaTime;

        myTransform.Translate(moveDirection);

        if(myTransform.position.y < -5.2f)
        {
            PositionInit();
        }
    }

    private void PositionInit()
    {
        myTransform.position = new Vector3(Random.Range(-8.0f, 8.0f), 6.0f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(explosionEffect, myTransform.position, Quaternion.identity);
            PositionInit();
            
            score += 100;
            textScore.text = "<color=blue>SCORE</color> : <color=red>" + score.ToString() + "</color>";

            if(score >= 1000)
            {
                SceneManager.LoadScene("ShootingClear");
            }
        }
    }

}
