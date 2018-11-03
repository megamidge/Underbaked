using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 3.5f;
    public float rotSpeed = 5f;

    private Vector3 dir = Vector3.zero; //Direction of which we are travelling

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //var x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        //var z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        //transform.Translate(x, 0, z);

        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        //if (dir != Vector3.zero)
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotSpeed);
        //}

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotSpeed);
            //transform.rotation = Quaternion.LookRotation(dir);
            if (dir != Vector3.zero)
                transform.rotation = Quaternion.LookRotation(dir);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
