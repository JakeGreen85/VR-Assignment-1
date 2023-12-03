using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargerManager : MonoBehaviour
{
    private GameObject[] targets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            targets = GameObject.FindGameObjectsWithTag("Target");
            foreach (GameObject target in targets)
            {
                Renderer renderer = target.GetComponent<Renderer>();
                renderer.material.color = Color.green;
            }
        }
    }


}
