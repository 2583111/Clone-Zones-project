using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject YouWinDisplay;
    public GameObject timer;
    public GameObject buttonPanel;
   

    // Start is called before the first frame update
    void Start()
    {
       
        YouWinDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            
            YouWinDisplay.SetActive(true);

            
            timer.SetActive(false);
            buttonPanel.SetActive(false);
          

            Debug.Log("YOU WIN");
        }
    }
}

