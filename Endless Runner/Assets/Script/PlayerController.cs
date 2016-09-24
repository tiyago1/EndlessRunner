using UnityEngine;
using System.Collections;

public enum DirectionType
{
    Left,
    Right,
    Jump,
    Crounch
}

public enum ColumType
{
    MinColumn = 0,

    Left = 1,
    Middle = 2,
    Right = 3,

    MaxColumn = 4
}

public class PlayerController : MonoBehaviour
{
    #region Fields

    private float mSpeed = 20.0f;
    private Transform mPlayerTransform;
    public int CurrentColum;

	#endregion //Fields
	
	#region Unity Methods
	
	private void Start () 
	{
		Initalize();
	}
	
	private void FixedUpdate () 
	{
        mPlayerTransform.position += Vector3.forward * Time.deltaTime * mSpeed;

        if (Input.GetKeyDown(KeyCode.A))
        {
            Move(DirectionType.Left);    
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Move(DirectionType.Right);
        }
	}
	
	#endregion //Unity Methods
	
	#region Public Methods
	
	public void Initalize()
	{
        mPlayerTransform = this.transform;
        CurrentColum = (int)ColumType.Middle;
    }
	
	#endregion // Public Methods
	
	#region Private Methods
	
	private void Move(DirectionType direction)
	{
        if (direction == DirectionType.Left)
        {
            if ((CurrentColum - 1) < (int)ColumType.MaxColumn && (CurrentColum -1) > (int)ColumType.MinColumn)
            {
                CurrentColum--;
                float xPosition = mPlayerTransform.position.x - 3.0f;
                mPlayerTransform.position = new Vector3(xPosition,mPlayerTransform.position.y,mPlayerTransform.position.z);
            }
        }

        if (direction == DirectionType.Right)
        {
            if ((CurrentColum + 1) < (int)ColumType.MaxColumn && (CurrentColum + 1) > (int)ColumType.MinColumn)
            {
                CurrentColum++;
                float xPosition = mPlayerTransform.position.x + 3.0f;
                mPlayerTransform.position = new Vector3(xPosition, mPlayerTransform.position.y, mPlayerTransform.position.z);
            }
        }
	}	
	
	#endregion //Private Methods
}
