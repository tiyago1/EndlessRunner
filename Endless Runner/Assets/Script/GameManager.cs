using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameManager : MonoBehaviour
{
    #region Constants

    #endregion // Constants

    #region Fields

    public GameObject BlockPrefab;
    private Vector3 LastInstantiatedBlockPosition;

    public  List<Platform> Platforms;
    public List<float> PlatformsPositionZ;

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

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetLastPlatformsTransform();
        }
	}
	
	#endregion //Unity Methods
	
	#region Public Methods
	
	public void Initalize()
	{
        LastInstantiatedBlockPosition = new Vector3(0.0f,0.0f,-10.0f);
        //StartCoroutine(Spawner());
	}
	
	#endregion // Public Methods
	
	#region Private Methods
	
	private void InstantiateBlock()
	{
        Vector3 newBlockPosition = LastInstantiatedBlockPosition + new Vector3(0.0f, 0.0f, 10.0f);
        LastInstantiatedBlockPosition = newBlockPosition; 
        GameObject instantiatedBlock = (GameObject)Instantiate(BlockPrefab, newBlockPosition, Quaternion.identity);
	}

    private void EndlessBlock()
    {

    }

    public float GetLastPlatformsTransform()
    {
        PlatformsPositionZ.Clear();

        foreach (Platform item in Platforms)
        {
            PlatformsPositionZ.Add(item.transform.position.z);
        }

        float[] PlatformDescend;

        PlatformDescend = PlatformsPositionZ.OrderByDescending(it => it).ToArray();

        return PlatformDescend[0];
    }

    private IEnumerator Spawner()
    {
        while (true)
        {
            InstantiateBlock();
            yield return new WaitForSeconds(0.2f);
        }
    }

	#endregion //Private Methods
}
