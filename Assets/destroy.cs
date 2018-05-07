using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    public GameObject player;
    private float difference;

	// Use this for initialization
	void Start () {
        this.difference = player.transform.position.z - this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(this.transform.position.x, 0, player.transform.position.z - difference);
		
	}
    private void OnTriggerEnter(Collider other)
        
    {
        if(other.gameObject .tag=="TrafficConeTag"||other.gameObject .tag=="CoinTag"||other .gameObject .tag== "CarTag")
        {
            Destroy(other.gameObject );
        }
        
       
    }
}
