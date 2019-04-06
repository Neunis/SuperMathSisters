using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip select;
    public GameObject instructionPopUp;
    public GameObject creditsPopUp;
    public GameObject menuOptions;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = select;
        instructionPopUp.SetActive(false);
        creditsPopUp.SetActive(false);
        menuOptions.SetActive(true);

    }
    public void  PlayGame()
    {
     
        StartCoroutine(playGameSound());
    }

    IEnumerator playGameSound()
    {
        audioSource.Play();
        //audioSource.PlayOneShot(select, 0.7F);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        audioSource.PlayOneShot(select, 0.7F);

        //tester to see if game quits since application.quit only fxns once built
        //for unity editor testing purposes
        //TODO:DELETE ONCE COMPLETED
        //Debug.Log("Game Quitting"); 
        Application.Quit();
    }

    public void Insturctions()
    {
        audioSource.PlayOneShot(select, 0.7F);
        instructionPopUp.SetActive(true);
        menuOptions.SetActive(false);

    }

    public void Credits()
    {
        audioSource.PlayOneShot(select, 0.7F);
        creditsPopUp.SetActive(true);
        menuOptions.SetActive(false);

    }

    public void PlaySelectSound()
    {
        audioSource.PlayOneShot(select, 0.7F);
    }


}
