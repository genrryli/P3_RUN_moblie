using UnityEngine;
using System.Collections;

public class i_col : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.GetComponent<player_health>().hurt();
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 1000);           
        }
    }
}
