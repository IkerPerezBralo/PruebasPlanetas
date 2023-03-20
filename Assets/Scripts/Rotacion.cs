using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField]
    private int rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkRotation();
    }

    void checkRotation()
    {
        if(this.gameObject.CompareTag("Sun"))
        {
            this.gameObject.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
        }
        if (this.gameObject.CompareTag("RedPlanet"))
        {
            this.gameObject.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
       
        }
        if (this.gameObject.CompareTag("RingPlanet"))
        {
            this.gameObject.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        }
    }
}
