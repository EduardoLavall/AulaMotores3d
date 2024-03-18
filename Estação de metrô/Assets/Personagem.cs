using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour


{
    public float frente = 20F;
    public float rot = 80F;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("dábliu");
            this.transform.Translate(new Vector3(1,0,0) * frente * Time.deltaTime );
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("Down");
            this.transform.Rotate(Vector3.up * rot * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            print("Up");
       
        }
       
    }
}
