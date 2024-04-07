using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D carRig;
    public Rigidbody2D backWheelRig;
    public Rigidbody2D frontWheelRig;

    public float speed;
    public float torque;

    private float movement = 0f;

    public FuelBar fuelBar;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (fuelBar.fuelBar.fillAmount > 0)
        {
            if (movement == 0)
            {
                backWheelRig.angularVelocity = 0;
                frontWheelRig.angularVelocity = 0;
            }
            else
            {
                backWheelRig.AddTorque(-movement * speed * Time.fixedDeltaTime);
                frontWheelRig.AddTorque(-movement * speed * Time.fixedDeltaTime);
            }

            carRig.AddTorque(-movement * torque * Time.fixedDeltaTime);
        }
    }
}
