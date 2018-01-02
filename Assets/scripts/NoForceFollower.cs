using UnityEngine;
using System.Collections;

public class NoForceFollower : MonoBehaviour
{
    public bool x;
    public bool y;
    public bool z;

    public GameObject player;
    private float _x;
    private float _y;
    private float _z;

    void Start()
    {
        _x = transform.position.x - player.transform.position.x;
        _y = transform.position.y - player.transform.position.y;
        _z = transform.position.z - player.transform.position.z;
    }

    void LateUpdate()
    {
        float __x = transform.position.x; float __y = transform.position.y; float __z = transform.position.z;
        if (x) {__x = _x+player.transform.position.x;}
        if (y) { __y = _y + player.transform.position.y; }
        if (z) {__z = _z + player.transform.position.z; }

        transform.position = new Vector3(__x, __y, __z);
    }
        
}