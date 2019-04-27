using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionaObjeto : MonoBehaviour
{
    public float velocidade = 50f;
    void Update()
    {
        transform.Rotate(Vector3.up * velocidade * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
