using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightScript : MonoBehaviour
{
    public float distancefromChainEnd = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // make sure pass parameter is must Rigidbody2D for joint (connectedBody);
    public void ConnectLastRope(Rigidbody2D jointRB)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        // make sure autoConfigureConnectedAnchor is false;
        joint.autoConfigureConnectedAnchor = false;
        // make sure connectBody is must Rigidbody2D;
        joint.connectedBody = jointRB;
        // make sure anchor is 0;
        joint.anchor = Vector2.zero;
        // make sure Connected anchor is x = 0f, y = assign variable;
        joint.connectedAnchor = new Vector2(0f, -distancefromChainEnd);
    }
}
