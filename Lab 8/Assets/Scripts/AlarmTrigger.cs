using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{

    public GameObject alarm;

    // Start is called before the first frame update
    void Start()
    {
        if (alarm)
            alarm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        alarm.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        alarm.SetActive(false);
    }
}
