using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    public float speed = 3f;

    private void Update() {
        transform.Translate(new Vector2(1,1) * speed * Time.deltaTime);
    }
}
