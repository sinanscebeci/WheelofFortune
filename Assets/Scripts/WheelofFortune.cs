using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelofFortune : MonoBehaviour
{
    public float defaultRotateSpeed;
    private float rotateSpeed;
    private float decelerationSpeed;
    private bool turnWheel = false;
    void Start()
    {
        rotateSpeed = defaultRotateSpeed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !turnWheel)
        {
            turnWheel = true;
            rotateSpeed = defaultRotateSpeed;
            decelerationSpeed = Random.Range(80f, 120f);
            Debug.Log(decelerationSpeed);
        }
        
        if(turnWheel)
        {
            if (rotateSpeed > 0)
            {
                rotateSpeed -= decelerationSpeed * Time.deltaTime;
                GetComponent<RectTransform>().Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
                
                //transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
            }
            else
            {
                rotateSpeed = 0;
                turnWheel = false;
            }


        }

    }
}
