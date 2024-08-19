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
        //1. 화면 누르면 어떻게 감지하지?
        bool isLeftDown = Input.GetMouseButtonDown(0);
        bool isRightDown = Input.GetMouseButtonDown(1);

        if (isLeftDown)
        {
            Debug.Log("왼쪽 눌렀습니다!");
            rotationSpeed = 10;
        }
        else if (isRightDown) 
        {
            Debug.Log("오른쪽 눌렀습니다!");
            rotationSpeed = -10;
        }

        //2. 회전 어떻게 시키지?
        this.transform.Rotate(0, 0, rotationSpeed);

        //속도 줄이고 
        //rotationSpeed *= 0.96f;

        rotationSpeed = rotationSpeed * 0.96f;

        //Debug.Log(rotationSpeed);
    }
}
