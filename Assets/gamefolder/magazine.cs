using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazine : MonoBehaviour
{
    [SerializeField]
    float reload;

    // �o�ߎ��Ԃ��v��
    float currentTime;

    [SerializeField]
    public int mag;

    // Start is called before the first frame update
    void Start()
    {
        // �ŏ��Ȃ̂Ōo�߂͂O
        currentTime = 0;
    }

    // �ݒ肵�����[�g�̒ʂ�ɓ������悤�Ƀ`�F�b�N����
    bool CheckFireLate()
    {
        if (currentTime > reload)
        {
            // �������̂Ń^�C�}�[���Z�b�g
            currentTime = 0;
            return true;
        }
        else return false;
    }

    void Update()
    {
        // ���Ԍo�߂����Z
        currentTime += Time.deltaTime;

        // �L�[���͌��m
        if (Input.GetKey(KeyCode.R))
        {
            // �}�K�W���N�[���^�C���𒴂��Ȃ����`�F�b�N
            if (CheckFireLate())
            {
                mag = 30;
            }
        }
       
        //Debug.Log(currentTime);
    }
}
