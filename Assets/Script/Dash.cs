using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public Transform character;
    public string goDash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (goDash.Equals("U"))
            character.position = new Vector3(-1.92f, 6.36f);
        if (goDash.Equals("D"))
            character.position = new Vector3(-0.82f, -0.92f);
        if (goDash.Equals("R"))
            character.position = new Vector3(3.77f, -3.64f);
        if (goDash.Equals("L"))
            character.position = new Vector3(8.4f, 6.29f);
    }


}
