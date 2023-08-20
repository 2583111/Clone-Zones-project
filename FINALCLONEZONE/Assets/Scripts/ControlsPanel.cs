using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsPanel : MonoBehaviour
{
    public GameObject controls;

    // Start is called before the first frame update
    void Start()
    {
        controls.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PanelActive()
    {
        controls.SetActive(true);
    }

    public void PanelDeactive()
    {
        controls.SetActive(false);
    }
}
