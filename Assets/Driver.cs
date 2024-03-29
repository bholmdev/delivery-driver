using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float boostTurnSpeed = 150f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Booster")
        {
            moveSpeed = boostSpeed;
            steerSpeed = boostTurnSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
}
