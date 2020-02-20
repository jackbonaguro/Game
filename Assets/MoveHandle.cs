using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHandle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal2");
        float y = Input.GetAxis("Vertical2");

        transform.Translate(((Vector3.forward * y) + (Vector3.right * x)) * Time.deltaTime);
    }
}
