using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {
    private GameObject UnityChan;
    private float difference;
	// Use this for initialization
	void Start () {
        this.UnityChan = GameObject.Find("unitychan");
        this.difference = UnityChan.transform.position.z - this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(0, this.transform.position.y, this.UnityChan.transform.position.z - difference);
	}
}
