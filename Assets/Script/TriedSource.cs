using UnityEngine;
using System.Collections;

public class TriedSource : MonoBehaviour 
{

	private void Start () 
    {
        Initalize();
	}
	
	private void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
        }
	}

    public void Initalize()
    {
        Debug.Log("Hello Source Tree");
        Debug.Log("Hello GitHup");
        Debug.Log("Source tree first change");

    }

}
