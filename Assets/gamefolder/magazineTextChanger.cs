using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazineTextChanger : MonoBehaviour
{
    // 変更をかけるテキスト
    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    [SerializeField]
    magazine magazine;

    private void Update()
    {
        // 残りのアイテム数を変更する
        scoreText.SetText("mag:{0}/30", magazine.mag );
    }
}
