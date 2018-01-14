using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

	public float speed;
	public float bspeed;
	float currentAngle;
	bool left;
	bool right;
	bool up;
	bool down;

	public Rigidbody2D rb;
	public Rigidbody2D brb;
	public GameObject bullet;
	public GameObject bulletPrefab;
	public GameObject tank;
	Vector3 shootDirection;

	void Start () {
		up = false;
		right = true;
		left = true;
		down = true;

		rb = GetComponent<Rigidbody2D> ();
	}


	void Update () {

		Vector3 pos = transform.position;

		if (Input.GetKey ("[8]")) {
			if (up == true) {
				ChangeDirection (1);
				up = false;
				right = true;
				left = true;
				down = true;
			}

			pos.y += speed * Time.deltaTime;

		}
		if (Input.GetKey ("[5]")) {
			if (down == true) {
				ChangeDirection (4);

				up = true;
				right = true;
				left = true;
				down = false;
			}

			pos.y -= speed * Time.deltaTime;
		}
		if (Input.GetKey ("[6]")) {
			if (right == true) {
				ChangeDirection (3);

				up = true;
				right = false;
				left = true;
				down = true;

			}
			pos.x += speed * Time.deltaTime;

		}
		if (Input.GetKey ("[4]")) {
			if (left == true) {
				ChangeDirection (2);

				up = true;
				right = true;
				left = false;
				down = true;

			}

			pos.x -= speed * Time.deltaTime;
		}

		transform.position = pos;

		if (Input.GetKeyDown ("[0]")) {

			GameObject bullet = Instantiate (bulletPrefab, tank.transform.position, Quaternion.identity);
			//bullet.GetComponent<Shooting>(). BulletDirectionUP();
			if (!up) {
				bullet.GetComponent<Shooting>(). BulletDirectionUP();
			}

			if (!down) {
				bullet.GetComponent<Shooting>(). BulletDirectionDW();
			}

			if (!right) {
				bullet.GetComponent<Shooting>(). BulletDirectionRH();
			}

			if (!left) {
				bullet.GetComponent<Shooting>(). BulletDirectionLF();

			}
		}
	}

	void ChangeDirection(int sw)
	{

		switch (sw) {
		case 1:
			if(up == true)
				transform.Rotate(0,0,-currentAngle);
			transform.Rotate(0,0,0);
			currentAngle = 0;
			break;
		case 2:
			transform.Rotate(0,0,-currentAngle);
			transform.Rotate(0,0,90);
			currentAngle = 90;
			break;
		case 3:
			transform.Rotate(0,0,-currentAngle);
			transform.Rotate(0,0,270);
			currentAngle = 270;
			break;
		case 4:
			transform.Rotate(0,0,-currentAngle);
			transform.Rotate(0,0,180);
			currentAngle = 180;
			break;
		}
	}

	public void BulletDirectionUP1()
	{
		bullet.GetComponent<Shooting>(). BulletDirectionUP();
	}

	public void BulletDirectionDW1()
	{
		bullet.GetComponent<Shooting>(). BulletDirectionDW();
	}

	public void BulletDirectionLF1()
	{
		bullet.GetComponent<Shooting>(). BulletDirectionLF();
	}

	public void BulletDirectionRH1()
	{
		bullet.GetComponent<Shooting>(). BulletDirectionRH();
	}


}
