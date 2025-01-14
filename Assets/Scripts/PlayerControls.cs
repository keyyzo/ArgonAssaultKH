using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [Header("Input Components")]
    [SerializeField] InputAction movement;

    [Space(20)]

    [Header("Movement Variables")]

    [SerializeField] private float baseMovementSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = movement.ReadValue<Vector2>().x;
        Debug.Log(xThrow);

        float yThrow = movement.ReadValue<Vector2>().y;
        Debug.Log(yThrow);

        float xOffset = xThrow * baseMovementSpeed * Time.deltaTime;
        float yOffset = yThrow * baseMovementSpeed * Time.deltaTime;
        float newXPos = transform.localPosition.x + xOffset;
        float newYPos = transform.localPosition.y + yOffset;

        transform.localPosition = new Vector3(
            newXPos,
            newYPos, 
            transform.localPosition.z);
        
    }

    
}
