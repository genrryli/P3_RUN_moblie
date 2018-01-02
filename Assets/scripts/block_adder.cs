using UnityEngine;
using System.Collections;

public class block_adder : MonoBehaviour {

    public GameObject[] block_item;

    private float timer;
    private int number;
    private float location_z;
    private float location_z_1;
    private float location_z_2;
    // Use this for initialization
    void Start () {
        location_z = gameObject.transform.position.z;
        location_z_1 = location_z;
        location_z_2 = location_z;
        number = block_item.Length;
    }
	
	// Update is called once per frame
	void Update () {
        add_block();       
	}

    void add_block()
    {
        if (location_z_1 >= gameObject.transform.position.z && location_z_1 < gameObject.transform.position.z+100)
        { 
        int n = Random.Range(0, number);
        float location_x = Random.Range(-2f, 2f);
        float location_y = 0.7f;
        Rigidbody new_block = Instantiate(block_item[n], new Vector3(location_x, location_y, location_z_1), block_item[n].transform.rotation) as Rigidbody;
        location_z_1 = location_z_1 + Random.Range(30, 70);
        }

        if (location_z_2 <= gameObject.transform.position.z && location_z_2 > gameObject.transform.position.z - 100)
        {
            location_z_2 = location_z_2 - Random.Range(30, 70);
            int n = Random.Range(0, number);
            float location_x = Random.Range(-2f, 2f);
            float location_y = 0.7f;
            Rigidbody new_block = Instantiate(block_item[n], new Vector3(location_x, location_y, location_z_2), block_item[n].transform.rotation) as Rigidbody;         
        }
    }
         
}
