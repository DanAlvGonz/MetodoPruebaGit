using UnityEngine;
using UnityEngine.InputSystem; 

public class Paddle : MonoBehaviour
{
    public float speed = 10f;
    public Key upKey;
    public Key downKey;

    void Update()
    {
        float move = 0;

        if (Keyboard.current[upKey].isPressed) move = 1;
        if (Keyboard.current[downKey].isPressed) move = -1;

        transform.Translate(Vector2.up * move * speed * Time.deltaTime);
    }
}