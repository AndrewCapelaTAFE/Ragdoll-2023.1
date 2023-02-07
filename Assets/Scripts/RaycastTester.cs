using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTester : MonoBehaviour
{
	
	public int x = 10;
	public int hitCount = 0;
	public string name = "";
	public Vector3 loc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.T))
		{
			for(int loop =0; loop < x ; loop++)
			{
				RaycastHit hit;
				Vector3 RandRotation =  new Vector3(Random.Range(0f,360f),
													Random.Range(0f,360f),
													Random.Range(0f,360f));
				if(Physics.Raycast(transform.position, RandRotation, out hit))
				{
					//Debug.DrawRay(transform.position,RandRotation * hit.distance, Color.yellow, 2f );
					
					//Debug.Log();
					name = hit.transform.gameObject.name;
					loc = hit.point;
					hitCount++;
				}
				else
				{
					//Debug.DrawRay(transform.position,RandRotation * 100f, Color.white, 2f );
				}
			}
		}
	}
}
