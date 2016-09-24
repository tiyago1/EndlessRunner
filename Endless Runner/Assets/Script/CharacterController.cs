using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour 
{
	#region Fields

    private float mSpeed = 20.0f;

    private Vector3 direction;
    private Transform CharacterTransform;
    private Rigidbody CharacterRigid;


    private float xPosition;

	#endregion //Fields
	
	#region Unity Methods
	
	private void Start () 
	{
		Initalize();
	}
	
	private void FixedUpdate () 
	{
        //CharacterTransform.position += Vector3.forward * Time.deltaTime * mSpeed;  
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up; 
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector3.down; 
        }
       
        if (direction.x > 0)
        {
            xPosition += 3.0f; 
            CharacterTransform.position = new Vector3(Mathf.Clamp(xPosition,0.0f,3.0f),this.transform.position.y , this.transform.position.z);
        }
        else if (direction.x < 0)
        {
            xPosition -= 3.0f;
            CharacterTransform.position = new Vector3(Mathf.Clamp(xPosition,-3.0f,0.0f), this.transform.position.y, this.transform.position.z);
        }

        if (direction.y >= 1)
        {
            CharacterRigid.AddForce(Vector3.up * 500f,ForceMode.Impulse);
        }

        if (direction.y < 0)
        {
            
        }
   
	}
	
	#endregion //Unity Methods
	
	#region Public Methods
	
	public void Initalize()
	{
        CharacterTransform = this.transform;
        CharacterRigid = this.GetComponent<Rigidbody>();
	}
	
	#endregion // Public Methods
	
	#region Private Methods
	
	private void SamplePrivateMethods()
	{
	
	}	
	
	#endregion //Private Methods
}
