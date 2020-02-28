using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsNCamera : MonoBehaviour
{
    public bool isUseKeyboard = true;
    public bool InvertX = false;
    public bool InvertY = false;
    public float speed = 1;
    public Vector2 sensitivity = Vector2.one;
    public Vector2 MouseV = Vector2.zero;
    Vector2 trueSense = Vector2.one;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        trueSense = sensitivity;
        MouseV = Vector2.zero;
        MouseV.x = Input.GetAxisRaw("Mouse X")*trueSense.x;
        MouseV.y = Input.GetAxisRaw("Mouse Y")*trueSense.y;
        transform.localEulerAngles += new Vector3(MouseV.y,MouseV.x,0);
        if (isUseKeyboard == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.rotation * Vector3.forward;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= transform.rotation * Vector3.right;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= transform.rotation * Vector3.forward;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += transform.rotation * Vector3.right;
            }
        }
    }
}
