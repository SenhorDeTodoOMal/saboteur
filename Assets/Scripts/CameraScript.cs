using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float panSpeed;
	
	public float zoomSpeed;
	
	public float minY;
	
	public float maxY;
	
	public float minX;
	
	public float maxX;
	
	public float minZ;
	
	public float maxZ;
	
	public float panThreshold;
	
	//Executed every frame
	void Update()
	{
		if(Input.mousePosition.x<panThreshold||Input.mousePosition.y<panThreshold||Input.mousePosition.x>Screen.width-panThreshold||Input.mousePosition.y>Screen.height-panThreshold)
		{
			
		}
	}
}
