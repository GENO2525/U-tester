using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonselector : MonoBehaviour
{
    [SerializeField]
    Button botton;
    // Start is called before the first frame update
    void Start()
    {
        botton.Select();
    }
}
