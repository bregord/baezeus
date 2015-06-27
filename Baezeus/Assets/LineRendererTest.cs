using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRendererTest : MonoBehaviour
{
	List<Vector3> linePoints = new List<Vector3>();
	LineRenderer lineRenderer;
	public float startWidthInit = 1.0f;
	public float endWidthInit = 1.0f;
	private float startWidth;
	private float endWidth; 
	public float threshold = 0.001f;
	Camera thisCamera;
	int lineCount = 0;
	private bool touched = false;
	private bool drawn = false;
	public bool damaging = false;
	public float chargeInterval;
	private float currentTime;
	private float chargeTime;
	public float growthRate;

	public int maxLightningCharge = 50;


	Vector3 lastPos = Vector3.one * float.MaxValue;

	void Awake()
	{
		thisCamera = Camera.main;
		lineRenderer = GetComponent<LineRenderer>();
	}
	
	void FixedUpdate()
	{
		currentTime = Time.time;
		//drawing
		if (Input.GetButtonDown ("Fire1")) {
			touched = true;
		} if(Input.GetButtonUp ("Fire1")) {
			touched = false;
			drawn = true;
			UpdateLine ();
			chargeTime = Time.time;
		}

		if (drawn == true && Mathf.Abs (currentTime - chargeTime) < chargeInterval) {
			startWidth = startWidth + growthRate;
			endWidth = endWidth + growthRate;
			lineRenderer.SetWidth(startWidth, endWidth);

		} else if(drawn == true && Mathf.Abs (currentTime - chargeTime) > chargeInterval) {
			drawn = false;
			damaging = true;
			linePoints.Clear ();
			UpdateLine();
			startWidth = startWidthInit;
				endWidth = endWidthInit;
		}


		if (lineCount > maxLightningCharge) {
			lineCount = 0;
			touched= false;
			UpdateLine();
			FixedUpdate();
		}

		print (touched);

		if (touched == true){
			Vector3 mousePos = Input.mousePosition;
			//if (Input.GetButtonDown ("Fire1")) { //Need to change to touch.
			mousePos.z = thisCamera.nearClipPlane;
			Vector3 mouseWorld = thisCamera.ScreenToWorldPoint (mousePos);
			
			float dist = Vector3.Distance (lastPos, mouseWorld);
			
			if (dist <= threshold)
				return;
			
			lastPos = mouseWorld;
			if (linePoints == null)
				linePoints = new List<Vector3> ();
			linePoints.Add (mouseWorld);
			
			UpdateLine ();
		}

	}


	void UpdateLine()
	{
		lineRenderer.SetWidth(startWidth, endWidth);
		lineRenderer.SetVertexCount(linePoints.Count);
		
		for(int i = lineCount; i < linePoints.Count; i++)
		{
			lineRenderer.SetPosition(i, linePoints[i]);
		}
		lineCount = linePoints.Count;
	}

	void chargeLightning(){


	}
}