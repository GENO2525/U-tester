using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookInGun : MonoBehaviour
{
    [SerializeField]
    GameObject Gun;

    [SerializeField]
    GameObject lookingun;

    [SerializeField]
    Camera Camera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Gun.SetActive(false);
            lookingun.SetActive(true);
            Camera.fieldOfView = 15;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Gun.SetActive(true);
            lookingun.SetActive(false);
            Camera.fieldOfView = 60;
        }
    }
}
