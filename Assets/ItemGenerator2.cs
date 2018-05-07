using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator2 : MonoBehaviour {
    public GameObject CarPrefab;
    public GameObject ConePrefab;
    public GameObject CoinPrefab;
    public GameObject Player;
    private int goalPos = 120;
    private int startPos = -160;
    private float posRange = 3.4f;
    private int genPos;
	// Use this for initialization
	void Start () {

        genPos = startPos;


    }
	
	// Update is called once per frame
	void Update () {

        if (genPos<= Player .transform.position.z + 50)
        {       
            int num = Random.Range(0, 10);
            if(num <= 1){
                for(float j = -1; j <= 1; j += 0.4f){
                    GameObject cone = Instantiate(ConePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, genPos );
                }
            }
            else
            {
                for(int j = -1; j < 2; j++){
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if(1<=item && item <= 6)
                    {
                        GameObject coin = Instantiate(CoinPrefab ) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, genPos  + offsetZ);
                    }else if(7<=item && item <= 9)
                    {
                        GameObject car = Instantiate(CarPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, genPos  + offsetZ);
                    }
                }
            }
            genPos += 15;
        }
	}
}
