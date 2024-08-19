using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    private float rotationSpeed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //1. ȭ�� ������ ��� ��������?
        bool isLeftDown = Input.GetMouseButtonDown(0);
        bool isRightDown = Input.GetMouseButtonDown(1);

        if (isLeftDown)
        {
            Debug.Log("���� �������ϴ�!");
            rotationSpeed = 10;
        }
        else if (isRightDown) 
        {
            Debug.Log("������ �������ϴ�!");
            rotationSpeed = -10;
        }

        //2. ȸ�� ��� ��Ű��?
        this.transform.Rotate(0, 0, rotationSpeed);

        //�ӵ� ���̰� 
        //rotationSpeed *= 0.96f;

        rotationSpeed = rotationSpeed * 0.96f;

        //Debug.Log(rotationSpeed);
    }
}
