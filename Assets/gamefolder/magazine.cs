using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazine : MonoBehaviour
{
    [SerializeField]
    float reload;

    // 経過時間を計測
    float currentTime;

    [SerializeField]
    public int mag;

    // Start is called before the first frame update
    void Start()
    {
        // 最初なので経過は０
        currentTime = 0;
    }

    // 設定したレートの通りに動かすようにチェックする
    bool CheckFireLate()
    {
        if (currentTime > reload)
        {
            // 超えたのでタイマーリセット
            currentTime = 0;
            return true;
        }
        else return false;
    }

    void Update()
    {
        // 時間経過を加算
        currentTime += Time.deltaTime;

        // キー入力検知
        if (Input.GetKey(KeyCode.R))
        {
            // マガジンクールタイムを超えないかチェック
            if (CheckFireLate())
            {
                mag = 30;
            }
        }
       
        //Debug.Log(currentTime);
    }
}
