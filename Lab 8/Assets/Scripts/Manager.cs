using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Manager : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject FirstControl;
    public bool isPaused = false;
    public GameObject footstepReproducer;
    public GameObject flashLight;
    public GameObject flashLightReproducer;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        isPaused = false;

        if(pauseMenu)
            pauseMenu.SetActive(false);

        if (FirstControl)
            FirstControl.SetActive(true);

        if (footstepReproducer)
            footstepReproducer.SetActive(false);

        if (flashLight)
            flashLight.SetActive(false);

        if (flashLightReproducer)
            flashLightReproducer.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            TogglePause();

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            WalkSound();
        }
        else if (footstepReproducer && footstepReproducer.activeSelf) 
        {
            footstepReproducer.SetActive(false);
        }

        if (flashLight) 
        {
            if (Input.GetKeyDown(KeyCode.F))
                ToggleFlashlight();
        }

        if (flashLightReproducer) 
        {
            if (!flashLightReproducer.GetComponent<AudioSource>().isPlaying)
                flashLightReproducer.SetActive(false);
        }
        
    }

    public void TogglePause()
    {
        if (pauseMenu)
        {

            pauseMenu.SetActive(!pauseMenu.activeSelf);
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0.0f : 1.0f;

            if (isPaused)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

        }

    }

    public void ExitScene()
    {
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
        if (FirstControl)
            FirstControl.SetActive(false);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void WalkSound() 
    {
        if (footstepReproducer) 
        {
            footstepReproducer.SetActive(true);
        }
    }

    private void ToggleFlashlight() 
    {
        if (flashLight.activeSelf)
            flashLight.SetActive(false);
        else if (!flashLight.activeSelf)
            flashLight.SetActive(true);

        if (flashLightReproducer && !flashLightReproducer.GetComponent<AudioSource>().isPlaying)
            flashLightReproducer.SetActive(true);
    }

}
