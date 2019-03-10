using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRigidBody : MonoBehaviour {

    public Camera camera;
    public bool dragX;
    public bool dragY;

    public float maxDragX = 10;
    public float maxDragY = 10;

    private bool isDragging;
    private float startPosX;
    private float startPosY;
    private float deltaX;
    private float deltaY;

    // Use this for initialization
    void Start () {
        startPosX = GetComponent<Rigidbody2D>().transform.position.x;
        startPosY = GetComponent<Rigidbody2D>().transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {

        if (isDragging) {
            Vector3 mousePos = Input.mousePosition; //mouse position
            Vector3 point = camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, camera.nearClipPlane)); //mouse to screen conversion

            deltaX = System.Math.Abs(point.x - GetComponent<Rigidbody2D>().transform.position.x);
            deltaY = System.Math.Abs(point.y - GetComponent<Rigidbody2D>().transform.position.y);

            

            if (dragY && deltaY <= maxDragY) {                
                GetComponent<Rigidbody2D>().transform.position =
                    new Vector3(
                        GetComponent<Rigidbody2D>().transform.position.x,
                        point.y,
                        GetComponent<Rigidbody2D>().transform.position.z
                    );
            }
            if (dragX && deltaX <= maxDragX) {
                GetComponent<Rigidbody2D>().transform.position =
                    new Vector3(
                        point.x,
                        GetComponent<Rigidbody2D>().transform.position.y,
                        GetComponent<Rigidbody2D>().transform.position.z
                    );
            }
        }
        Debug.Log(GetComponent<SpringJoint2D>().distance);
    }

    void OnMouseDown() {
        isDragging = true;
    }

    void OnMouseUp() {
        isDragging = false;
    }
}