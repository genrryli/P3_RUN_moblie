using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player_health : MonoBehaviour {

    public GameObject[] health_ui;
    //public GameObject display_health_ui;
    public int health = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        display_health();
    }

    public void hurt()
    {
        health -= 1;
        GetComponent<Animator>().SetTrigger("hurt");
    }

   void display_health()
    {
        for (int i = 0; i < health_ui.Length; i++) { health_ui[i].SetActive(false); }       
        health_ui[health].SetActive(true);
    }
}
