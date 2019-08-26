using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private Rigidbody _rb;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
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
        if (Input.GetKey(up))
        {
            //transform.
            _rb.AddForce(Vector3.forward * 10000f * Time.deltaTime);
        }
        if (Input.GetKey(down))
        {
            //transform.
            _rb.AddForce(-Vector3.forward * 10000f * Time.deltaTime);
        }
        if (Input.GetKey(right))
        {
            //transform.
            _rb.AddForce(Vector3.right * 10000f * Time.deltaTime);
        }
        if (Input.GetKey(left))
        {
            //transform.
            _rb.AddForce(-Vector3.right * 10000f * Time.deltaTime);
        }
    }
}
