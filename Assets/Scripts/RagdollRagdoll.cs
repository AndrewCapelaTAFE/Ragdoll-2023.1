using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollRagdoll : MonoBehaviour
{
	
	//Joint[] joints;
	Rigidbody[] rbs;

	public Transform trackerPosition;
	
    // Start is called before the first frame update
    void Start()
    {
        //joints = GetComponentsInChildren<HingeJoint>();
		rbs = GetComponentsInChildren<Rigidbody>();
		
		foreach(Rigidbody rb in rbs)
		{
			rb.isKinematic = true;
			CollisionDetect collisionDetect = rb.gameObject.AddComponent<CollisionDetect>();
			collisionDetect.parentRagdoll = this;
		}
    }
	
	public void Update()
	{
		if(Input.GetKeyDown(KeyCode.R))
		{
			RagdollTheRagdoll();
		}
		
		if(Input.GetKeyDown(KeyCode.E))
		{
			UnRagdollTheRagdoll();
		}
	}

    public void RagdollTheRagdoll()
	{
		foreach(Rigidbody rb in rbs)
		{
			rb.isKinematic = false;
		}
		anim.enabled  = false;
	}
	
	public void UnRagdollTheRagdoll()
	{
		foreach(Rigidbody rb in rbs)
		{
			rb.isKinematic = true;
		}
		transform.position = trackerPosition.position;
		anim.enabled = true;
	}
}
