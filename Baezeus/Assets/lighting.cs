using UnityEngine;
using System.Collections;

public class lighting : MonoBehaviour {

	myLine = new VectorLine ("Spline", linePoints, roadLineMaterial, 4.0f, LineType.Continuous, Joins.Fill);

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}

	//This is where the line between two vector3 points is drawn

	void DrawLine(Vector3 intersection){
		linePoints[++lineIndex] = intersection;
		myLine.MakeSpline (linePoints);myLine.Draw3D ();
	}
}
