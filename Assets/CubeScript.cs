using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private Rigidbody _rb;
    public KeyCode key1;
    public KeyCode key2;
    //public int hola;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("He corrido uwu");
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(key1))
        {
            //transform.
            _rb.AddTorque(Vector3.right * 1000f * Time.deltaTime);
        }
        if (Input.GetKey(key2))
        {
            //transform.
            _rb.AddTorque(-Vector3.right * 1000f * Time.deltaTime);
        }
    }
}
