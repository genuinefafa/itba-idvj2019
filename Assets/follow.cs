using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject myobject;
    Vector3 _distance;

    // Start is called before the first frame update
    void Start()
    {
        _distance = myobject.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 distance = Vector3.left * 5f;
        Vector3 newPosition = myobject.transform.position - _distance;
        transform.position = newPosition;
    }
}
