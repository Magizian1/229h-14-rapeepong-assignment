using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalEnemyActive : MonoBehaviour
{
    public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    void OnDestroy()
    {
        // เล่น Particle System เมื่อ GameObject ถูกทำลาย
        Instantiate(particleSystem, transform.position, Quaternion.identity);
    }

}
