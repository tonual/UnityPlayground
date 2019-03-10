using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("sdasD");
            anim.ResetTrigger("jump");
            anim.SetTrigger("run");

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("jump");
            anim.ResetTrigger("run");
            anim.SetTrigger("jump");

        }
    }
}
