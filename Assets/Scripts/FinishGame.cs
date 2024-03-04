using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        Canvas.SetActive(true);
        Time.timeScale = 0;
    }
}
