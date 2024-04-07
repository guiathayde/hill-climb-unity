using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    public Image fuelBar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fuelBar.fillAmount -= Mathf.Abs(Input.GetAxis("Horizontal")) / 10.0f * Time.deltaTime;
    }

    public void AddFuel()
    {
        fuelBar.fillAmount += 0.5f;
    }
}
