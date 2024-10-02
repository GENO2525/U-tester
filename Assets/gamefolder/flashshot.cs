using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashshot : MonoBehaviour
{
    // 弾のオブジェクト
    [SerializeField]
    GameObject bulletPrefab;

    // 銃口のオブジェクト。座標の取得に使用
    [SerializeField]
    GameObject muzzleObj;
    // 銃口の座標
    Vector3 muzzulePosition;
    // 銃口の向き
    Quaternion muzzuleRotation;

    // レート。何秒間隔で撃てるか
    [SerializeField]
    float FireLate;

    [SerializeField]
    magazine magazine;

    public AudioClip SE;
    AudioSource audioSource;

    // 経過時間を計測
    float currentTime;

    void Start()
    {
        // 最初なので経過は０
        currentTime = 0;

        // 座標
        muzzulePosition = muzzleObj.transform.position;
        // 向き
        muzzuleRotation = muzzleObj.transform.rotation;

        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // マズルも動くので情報を更新
    void UpdateMuzzuleTransdorm()
    {
        // 座標
        muzzulePosition = muzzleObj.transform.position;
        // 向き
        muzzuleRotation = muzzleObj.transform.rotation;
    }

    void StraightShot()
    {
        Instantiate(bulletPrefab, muzzulePosition, muzzuleRotation);
    }

    // 設定したレートの通りに動かすようにチェックする
    bool CheckFireLate()
    {
        if (currentTime > FireLate)
        {
            // 超えたのでタイマーリセット
            currentTime = 0;
            return true;
        }
        else return false;
    }

    void Update()
    {
        
        // マズルの情報は常に更新
        UpdateMuzzuleTransdorm();

        // 時間経過を加算
        currentTime += Time.deltaTime;

        // キー入力検知
        if (Input.GetKey(KeyCode.Mouse0) && (magazine.mag != 0))
        {
            // ファイアレートを超えないかチェック
            if (CheckFireLate())
            {
                // 弾を生成
                StraightShot();
            }
        }
    }
}
