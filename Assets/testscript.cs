using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testscript : MonoBehaviour
{
    public GameObject scoreText;
    float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = ("Start Function");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreText.GetComponent<Text>().text = ("Spacebar:" + counter);
            print("Spacebar counter" + counter);
            counter++;
        }

      /*  if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Spacebar counter");
        }*/
    }
    
    
}
