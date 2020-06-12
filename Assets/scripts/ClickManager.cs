using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //To convert mouseposition to world space
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);  //to drop the z co-ordinate
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);

                hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }

        }
    }
}
