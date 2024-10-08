using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    // 寿命
    [SerializeField]
    float lifeSpan;

    [SerializeField]
    GameObject flash;

    // 経過時間を計測
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        // 最y祖なので経過は０
        currentTime = 0;
    }

    void Update()
    {

        // 経過時間を加算
        currentTime += Time.deltaTime;
        // 生存時間が寿命を超えたら
        if (currentTime > lifeSpan)
        {
            Destroy(flash);
        }
    }
}
