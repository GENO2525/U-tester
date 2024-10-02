using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    // Žõ–½
    [SerializeField]
    float lifeSpan;

    [SerializeField]
    GameObject flash;

    // Œo‰ßŽžŠÔ‚ðŒv‘ª
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        // Åy‘c‚È‚Ì‚ÅŒo‰ß‚Í‚O
        currentTime = 0;
    }

    void Update()
    {

        // Œo‰ßŽžŠÔ‚ð‰ÁŽZ
        currentTime += Time.deltaTime;
        // ¶‘¶ŽžŠÔ‚ªŽõ–½‚ð’´‚¦‚½‚ç
        if (currentTime > lifeSpan)
        {
            Destroy(flash);
        }
    }
}
