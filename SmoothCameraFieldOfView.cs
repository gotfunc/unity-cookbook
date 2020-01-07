using UnityEngine;

public class SmoothCameraFov.cs : MonoBehaviour
{
    public float from = 30f;
    public float to = 80f;
    
    private Camera _camera;

    void Awake()
    {
        _camera = GetComponent<Camera>(); // Assign camera
        _camera.fieldOfView = from; // Reset to default
    }

    void Update()
    {
        _camera.fieldOfView = Mathf.Lerp(_camera.fieldOfView, to, 0.75f * Time.smoothDeltaTime);
    }
}
