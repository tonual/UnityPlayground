using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Actions/RemoveForce")]
public class RemoveForce : Action {
    

    public override bool ExecuteAction(GameObject dataObject) {
        ConstantForce2D c = GetComponent<ConstantForce2D>();
        GetComponent<Rigidbody2D>().gravityScale = 1;
        Destroy(c);
        return true;
    }
}

