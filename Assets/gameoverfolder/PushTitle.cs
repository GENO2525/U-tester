using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushTitle : MonoBehaviour
{
    public void OnButton()
    {
        SceneManager.LoadScene("titlescene");
    }
}
