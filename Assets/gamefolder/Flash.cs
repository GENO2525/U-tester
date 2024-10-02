using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    // ����
    [SerializeField]
    float lifeSpan;

    [SerializeField]
    GameObject flash;

    // �o�ߎ��Ԃ��v��
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        // ��y�c�Ȃ̂Ōo�߂͂O
        currentTime = 0;
    }

    void Update()
    {

        // �o�ߎ��Ԃ����Z
        currentTime += Time.deltaTime;
        // �������Ԃ������𒴂�����
        if (currentTime > lifeSpan)
        {
            Destroy(flash);
        }
    }
}
