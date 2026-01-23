// using UnityEngine;

// public class BASKET : MonoBehaviour
// {
//     public KeyCode left;
//     public KeyCode right;

//     public float BASKET_x;
//     public float speed = 5f;

//     void Start()
//     {
//         BASKET_x = transform.position.x;
//     }

//     void Update()
//     {
//         if (Input.GetKey(left))
//             BASKET_x -= speed * Time.deltaTime;

//         if (Input.GetKey(right))
//             BASKET_x += speed * Time.deltaTime;

//         transform.position = new Vector3(BASKET_x, -4.0f, 0f);
//     }
// }

using UnityEngine;
using UnityEngine.InputSystem;

public class BASKET : MonoBehaviour
{
    public float speed = 5f;

    public float minX = -8f;   
    public float maxX = 8f;    

    void Update()
    {
        float move = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
            move -= 1f;

        if (Keyboard.current.rightArrowKey.isPressed)
            move += 1f;

        Vector3 pos = transform.position;
        pos.x += move * speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        transform.position = pos;
    }
}

