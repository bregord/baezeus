using UnityEngine;
using System.Collections;

public class lighting : MonoBehaviour {

	Plane _groundPlane;
	//public Vector3 groundOrigin = Vector3.zero;
	//public Vector3 groundNormal = Vector3.up;

	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	private GameObject lineGO;
	private LineRenderer lineRenderer;
	private int i = 0;
	private Vector3 posPrev;
	private Vector3 posNow;
	private bool touched =false;
	
	// Use this for initialization
	void Start () {
		lineGO = new GameObject ("Line");
		lineGO.AddComponent<LineRenderer> ();
		lineRenderer = lineGO.GetComponent<LineRenderer> ();
		lineRenderer.material = new Material (Shader.Find ("Mobile/Particles/Additive"));
		lineRenderer.SetColors (c1, c2);
		lineRenderer.SetWidth (0.3F, 0);
		lineRenderer.SetVertexCount (0);
	}
			
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.touchCount > 0){ // TOUCH
		//if(Input.GetButtonDown("Fire1")){
			if(touched == false){
				touched = true;
				posPrev = Input.mousePosition;
			}

			posNow = Input.mousePosition;
			//Touch touch = Input.GetTouch(0); //TOUCH

			//if(touch.phase == TouchPhase.Moved) // TOUCH
			if(posPrev - posNow != Vector3.zero)
			{
				lineRenderer.SetVertexCount(i+1);
				Vector3 mPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);
				lineRenderer.SetPosition(i, mPosition);
				//lineRenderer.SetPosition(i, Camera.main.ScreenToWorldPoint(mPosition));
				i++;
			}
			//if(touch.phase == TouchPhase.Ended){ //// TOUCH
			if(!Input.GetButtonDown("Fire1")){
				touched = false;
				lineRenderer.SetVertexCount(0);
				i = 0;
			}

			posPrev = Input.mousePosition;
		}

}
}
