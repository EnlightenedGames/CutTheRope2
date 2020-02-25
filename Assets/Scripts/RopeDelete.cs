using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeDelete : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //Get Mouse position and left click using GetMouseButton(0) ;
        if (Input.GetMouseButton(0))
        {
            // Get Collider Info Hit using RaycastHit2D and Mouse position using physics2d.Raycat( camera.main.ScreeenToWorldPoint(Input.mousePoistion) ) function with zero direction;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            // if Mouse position hit somethings ;
            if (hit.collider != null)
            {
                // if Mouse position collider with tag name is rope then destroy collider object ;
                if (hit.collider.tag == "rope")
                {
                   // destroy collider object if rope tag ;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
