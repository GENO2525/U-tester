using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushGameStart : MonoBehaviour
{
    public void OnButton()
    {
        SceneManager.LoadScene("gamascene");
    }
}
