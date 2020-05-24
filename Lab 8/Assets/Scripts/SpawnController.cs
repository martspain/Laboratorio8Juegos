using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject instructions;
    // Start is called before the first frame update
    void Start()
    {
        if (instructions)
            instructions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (instructions)
            instructions.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (instructions)
            instructions.SetActive(false);
    }
}
