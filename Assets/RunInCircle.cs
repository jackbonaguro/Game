using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunInCircle : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    private GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        model = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.rotation * Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        model.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
    }
}
