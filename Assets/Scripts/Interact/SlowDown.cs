using UnityEngine;

public class SlowDown : MonoBehaviour {
    // Toggles the time scale between 1 and 0.7
    // whenever the user hits the Fire1 button.

    void Start() {
        
       Time.timeScale = 1.3f;
       Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
