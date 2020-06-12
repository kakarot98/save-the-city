using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteor : MonoBehaviour
{
    //public GameObject meteor;
    //float border = 51f;
    
    private void OnMouseDown()
    {
        //Vector3 meteorPos = meteor.transform.position;
        //if (gameObject.transform.position.y < Screen.height - border)
            Destroy(gameObject);
        
    }
}
