using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// プレイヤー本体を管理
public class Player : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // 敵に当たったら終わり
        if (collision.gameObject.tag == "Enemy")
        {
            // シーンをロード
            SceneManager.LoadScene("GameOverScene");
        }
    }
}