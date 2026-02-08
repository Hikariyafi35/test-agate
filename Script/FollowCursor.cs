
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowCursor : MonoBehaviour
{
    public Vector2 offset = new Vector2(1f, 1f);
    public float smoothTime = 0.15f;

    Vector3 velocity = Vector3.zero;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        FollowMouse();
    }
    void FollowMouse()
    {
        Vector3 mouseScreenPos = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mouseScreenPos);
        mouseWorldPos.z = 0f;

        //Offset
        Vector3 targetPos = mouseWorldPos + (Vector3)offset;

        //delay
        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPos,
            ref velocity,
            smoothTime
        );
    }
}
