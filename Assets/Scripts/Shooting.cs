using UnityEngine;
using System.Collections;



public class Shooting : MonoBehaviour {

	public float thrust;
	public float bspeed;
	public Rigidbody2D rb;
	GameObject MManager;
	public int winner;

	void Start()
	{
		rb = GetComponent<Rigidbody2D> ();
		MManager = GameObject.Find ("MenuManager");
	}

	void Update()
	{
		//Vector3 shootDirection;

		//shootDirection.z = 0.0f;
		//shootDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//shootDirection = shootDirection - transform.position;

	
	}


	public void SetDirection(Vector3 shootDirection)
	{
		rb.velocity = new Vector2 (shootDirection.x * thrust, shootDirection.y * thrust);
	}

	public void BulletDirectionUP()
	{
		rb.AddRelativeForce(new Vector3 (0,bspeed));
	}

	public void BulletDirectionDW()
	{
		rb.AddRelativeForce(new Vector3 (0,-bspeed));
	}

	public void BulletDirectionLF()
	{
		rb.AddRelativeForce(new Vector3 (-bspeed,0));
	}

	public void BulletDirectionRH()
	{
		rb.AddRelativeForce(new Vector3 (bspeed,0));
	}




	void OnCollisionEnter2D (Collision2D other)
	{

		if (other.gameObject.tag == "wall") {
			//Debug.Log ("Hit!");
			Destroy (this.gameObject);

		}

		if (other.gameObject.tag == "player1") {


			Destroy (this.gameObject);
			Destroy (other.gameObject);
			MManager.GetComponent<MenuManager> ().Player2Won ();

		}

	
		if (other.gameObject.tag == "player2") {

			Destroy (this.gameObject);
			Destroy (other.gameObject);
			MManager.GetComponent<MenuManager> ().Player1Won ();
		}


	}

}
