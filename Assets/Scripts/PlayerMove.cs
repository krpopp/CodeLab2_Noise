using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    CharacterController controller;
    float speed = 2f;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(newPos * Time.deltaTime * speed);

        float rotationX = Camera.main.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * 15f;
			
		rotationY += Input.GetAxis("Mouse Y") * 15f;
		rotationY = Mathf.Clamp (rotationY, -60, 60);
			
		Camera.main.transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
