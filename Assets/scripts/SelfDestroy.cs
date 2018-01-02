using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour
{
    public float t;

    void Start()
    {
        Destroy(gameObject, t);
    }
}