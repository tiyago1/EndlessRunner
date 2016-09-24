using UnityEngine;
using System.Collections;

public class PlatformDetected : MonoBehaviour 
{
	#region Fields

	#endregion //Fields
	
	#region Unity Methods
	
	private void Start () 
	{
		Initalize();
	}
	
	private void Update () 
	{
	
	}
	
	#endregion //Unity Methods
	
	#region Public Methods
	
	public void Initalize()
	{
	
	}

	#endregion // Public Methods
	
	#region Private Methods

    private void OnTriggerExit(Collider collider) 
    {
        if (collider.gameObject.tag == "Platform")
        {
            Destroy(collider.gameObject);
        }
    }

	#endregion //Private Methods
}
