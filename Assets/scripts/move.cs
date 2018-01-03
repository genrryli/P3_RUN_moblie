using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour {

    public float speed;
    public float t_speed;
    public float jump_f;

    private Rigidbody ri;
    private Animator am;
	// Use this for initialization
	void Start () {
        am = GetComponent<Animator>();
        ri = GetComponent<Rigidbody>();
        
	}

    // Update is called once per frame
    void Update()
    {
        float tx = Input.acceleration.x*0.5f;
        transform.Translate(tx * t_speed * Time.deltaTime,0,0);
        float x= Mathf.Clamp(transform.position.x, -1.8f, 1.8f);
        transform.position=new Vector3(x,transform.position.y,transform.position.z);

        speed += Time.deltaTime;
        run();
	}

    void run()
    {
        transform.Translate(0,0,1*speed*Time.deltaTime);
        am.SetBool("run", true);
    }

    public void jump()
    {
        if (gameObject.transform.position.y > 2) { return; }
        ri.AddForce(Vector3.up *jump_f);
        am.SetTrigger("jump");
    }
}
