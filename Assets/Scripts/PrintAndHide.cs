using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i;
    private int randomInt;
    // Start is called before the first frame update
    void Start()
    {
         i = 3;
        randomInt = Random.Range(150, 251);  
    }

    // Update is called once per frame
    void Update()
    {
          i++;
        Debug.Log(gameObject.name + ":" + i);
        
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);  // Deactivates the GameObject
        }

        if (gameObject.tag == "Blue" && i == randomInt)
        {
            rend.enabled = false;  // Disables the Renderer component
        }
        
    }
}
