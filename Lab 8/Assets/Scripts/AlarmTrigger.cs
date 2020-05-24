using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{

    public GameObject alarm;
    public GameObject sound;

    // Start is called before the first frame update
    void Start()
    {
        if (alarm)
            alarm.SetActive(false);
        if (sound)
            sound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(alarm)
            alarm.SetActive(true);
        if (sound)
            sound.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if(alarm)
            alarm.SetActive(false);
        if (sound)
            sound.SetActive(false);
    }
}
