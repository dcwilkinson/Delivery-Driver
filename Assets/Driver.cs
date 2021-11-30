using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f; // [SerializeField] allows variable to be editable in Unity inspector tab
    [SerializeField] float moveSpeed = 0.01f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Using Time.deltaTime Unity can tell us how long each frame took to execute.
        // When we multiple something by Time.deltaTime it makes our game "frame rate independent", meaning game behaves the same on fast and slow computers.

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; // variable is assigned in Update as needs to be re-calculated per frame
        float movementAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount); // steering
        transform.Translate(0, movementAmount, 0); // movement
    }
}
