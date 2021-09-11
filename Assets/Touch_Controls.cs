using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Controls : MonoBehaviour
{
    private PlayerMovement playerMovment;
    void Start()
    {
        playerMovment = GetComponent<PlayerMovement>();
        
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch_Pos.x > 0)
            {
                playerMovment.MoveLeft();
            }

            if (touch_Pos.x < 0)
            {
                playerMovment.MoveRight();
            }
        }
    }
}
