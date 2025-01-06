using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Note the added library!

public class WalkingAgentScript : MonoBehaviour
{
    //Create a reference to the objects or components you need to communicate with
    //Hint: the agent needs to walk towards a TARGET. It needs to use the NAVMESH to do so! https://docs.unity3d.com/6000.0/Documentation/ScriptReference/AI.NavMeshAgent.html



    // Start is called before the first frame update
    void Start()
    {
        //Store the necessary components into your references
        //Tip: if you get null reference errors then check that the object this script is attached to actually has the components you're trying to call on.

    }

    // Update is called once per frame
    void Update()
    {
        //Create movement towards the TARGET by using the NAVMESH. https://docs.unity3d.com/6000.0/Documentation/ScriptReference/AI.NavMeshAgent.SetDestination.html


    }
}
