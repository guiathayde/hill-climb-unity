using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public FuelBar fuelBar;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            fuelBar.AddFuel();
            Destroy(gameObject);
        }
    }
}
