using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    #region Constants

    #endregion // Constants

    #region Fields

    public GameObject BlockPrefab;
    private Vector3 LastInstantiatedBlockPosition;

	#endregion //Fields
	
	#region Unity Methods
	
	private void Start () 
	{
		Initalize();
	}
	
	private void Update () 
	{
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstantiateBlock();
        }
	}
	
	#endregion //Unity Methods
	
	#region Public Methods
	
	public void Initalize()
	{
        LastInstantiatedBlockPosition = new Vector3(0.0f,0.0f,-10.0f);
	}
	
	#endregion // Public Methods
	
	#region Private Methods
	
	private void InstantiateBlock()
	{
        Vector3 newBlockPosition = LastInstantiatedBlockPosition + new Vector3(0.0f, 0.0f, 10.0f);
        LastInstantiatedBlockPosition = newBlockPosition; 
        GameObject instantiatedBlock = (GameObject)Instantiate(BlockPrefab, newBlockPosition, Quaternion.identity);
	}	
	
	#endregion //Private Methods
}
