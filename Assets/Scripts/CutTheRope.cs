using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTheRope : MonoBehaviour
{
    public Rigidbody2D hook;
    public int ropeCount;
    public GameObject linksPrefab;
    public WeightScript weight;
    // Start is called before the first frame update
    void Start()
    {
        hook = GetComponent<Rigidbody2D>();
        generateRope();
    }

    void generateRope()
    {
        Rigidbody2D previousRB = hook;
        for (int i = 0; i < ropeCount; i++)
        {
            // Instantiate gameobject like linkPrefab is its position;
            // then assign to link game object for assign HingeJoint2D;
            GameObject link = Instantiate(linksPrefab, transform);
            // Make HingeJoint2D variable like joint and assign HingeJoint2D component ;
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            // using joint variavle assign and connectbody as previousRB means hook to previousRB and joint to previousRB;
            joint.connectedBody = previousRB;

            // ropeCount means last node of array (7-1 = 6);
            if (i < ropeCount - 1 )
            {
                // connecte node till the last node of array (6);
                previousRB = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                // pass the value of last node to the WeightScript using weight variable and ConnectLastRope() method like last node is 7);
                weight.ConnectLastRope(link.GetComponent<Rigidbody2D>());
            }
           
        }
    }
}
