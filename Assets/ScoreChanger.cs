using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI textMeshPro;

    // �A�C�e���̎c����𐔂���
    [System.NonSerialized]
    public int numberOfItem;

    // �A�C�e�����j��(�擾)���ꂽ�Ƃ��ɌĂ΂��
    public void RemoveScore()
    {
        // �c��̌������炷
        --numberOfItem;

        // �c��̌��Ńe�L�X�g��\��
        textMeshPro.SetText("Item count:{0}", numberOfItem);
    }
    // Start is called before the first frame update
    void Start()
    {
        // �ŏ��Ȃ̂ŃA�C�e���̍ő吔�ŏ���������
        numberOfItem = 5;
        // ����ݒ肵���̂Ŕ��f
        textMeshPro.SetText("Item count:{0}", numberOfItem);
    }
}
