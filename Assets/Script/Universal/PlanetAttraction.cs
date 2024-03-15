using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAttraction : MonoBehaviour
{

    public Rigidbody rb;

    private const float G = 6.67f;

    public static List<PlanetAttraction> pAttractions;
    

    void AttractorFoemular(PlanetAttraction other)
    {
        Rigidbody rbOther = other.rb;

        Vector3 direction = rb.position - rbOther.position;

        float distance = direction.magnitude;

        // F = G * (M1 * M2) / D^2
        float forceMegnitude = G * (rb.mass * rbOther.mass) / Mathf.Pow(distance , 2);

        Vector3 forceDir = direction.normalized * forceMegnitude;
        rbOther.AddForce(forceDir);
    }
    private void Start()
        {
            GetComponent<Rigidbody>().AddForce(0,0,0);
        }
    void FixedUpdate()
    {
        foreach (var attraction in pAttractions)
        {
            if (attraction != this)
            {
                AttractorFoemular(attraction);
            }
        }
    }

    private void OnEnable()
    {
        if (pAttractions == null)
        {
            pAttractions = new List<PlanetAttraction>();
        }
        pAttractions.Add(this);
    }

    
}
