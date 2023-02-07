using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
	public RagdollRagdoll parentRagdoll;
	
	public void OnCollisionEnter(Collision collision)
	{
		if(collision.relativeVelocity.magnitude > 0.1f)
		{
			if(parentRagdoll != null)
			{
				parentRagdoll.RagdollTheRagdoll();
			}
		}
	}
}
