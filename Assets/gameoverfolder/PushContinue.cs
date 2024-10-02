using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushContinue : MonoBehaviour
{
    public void OnButton()
    {
        SceneManager.LoadScene("gamascene");
    }
}
