using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ball;
    private int number = 0;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        IEnumerator Start()
        {
            while (number < 100)
            {
                yield return new WaitForSeconds(0.5f);
                Instantiate(ball);
            }
        }
    }
}
