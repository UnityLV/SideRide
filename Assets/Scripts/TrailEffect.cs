using UnityEngine;

public class TrailEffect : MonoBehaviour {
    public TrailRenderer trailRenderer;

    void Start() {
        trailRenderer = GetComponent<TrailRenderer>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            trailRenderer.emitting = true;
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            trailRenderer.emitting = false;
        }
    }
}