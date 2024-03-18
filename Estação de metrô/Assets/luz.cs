using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour

{

    private Light l;
    private float countdown = 4F;

    // Start is called before the first frame update
    void Start()
    {
        l = this.GetComponent<Light>();
        l.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0)
        {
            l.enabled = !l.enabled;
            countdown = 4F; 
        }
    }
}
