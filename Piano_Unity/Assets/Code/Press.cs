using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{
   
    bool isDown = false;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var newPos = transform.position;
            newPos.y -= 0.2f;
            transform.position = newPos;


            isDown = true;

        }

        if (Input.GetMouseButtonUp(0) && isDown)
        {
            var newPos = transform.position;
            newPos.y += 0.2f;
            transform.position = newPos;
            isDown = false;
        }
    }

    void OnMouseExit()
    {
        if (isDown)
        {
            var newPos = transform.position;
            newPos.y += 0.2f;
            transform.position = newPos;
            isDown = false;
        }
    }

}

