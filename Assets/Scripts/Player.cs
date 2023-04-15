using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i<=5; i++)
        {
            for(int j =0; j<=5; j++)
            {
                Debug.Log("*");
            }
            Debug.Log(" ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
