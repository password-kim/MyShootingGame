using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour
{
    public void OnClickRestartButton()
    {
        Debug.Log("Click Restart Button");
        SceneManager.LoadScene("ShootingGame");
    }
}
