using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazineTextChanger : MonoBehaviour
{
    // �ύX��������e�L�X�g
    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    [SerializeField]
    magazine magazine;

    private void Update()
    {
        // �c��̃A�C�e������ύX����
        scoreText.SetText("mag:{0}/30", magazine.mag );
    }
}
