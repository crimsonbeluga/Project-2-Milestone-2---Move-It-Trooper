using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public KeyCode keypress;
    public KeyCode quitKey;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keypress))

        {
            // its going to change the position to some random x and y location
            Vector3 position = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
            transform.SetPositionAndRotation(position, Quaternion.identity);

        }
        if (Input.GetKeyDown(quitKey))
        {
            Application.Quit();
        }
    }
}