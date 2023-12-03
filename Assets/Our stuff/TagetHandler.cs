using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagetHandler : MonoBehaviour
{
    public Renderer ren;
    // Start is called before the first frame update
    void Start()
    {
        ren = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change_Color()
    {
        ren.materials[0].color = Color.red;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            Change_Color();
        }
    }
}
