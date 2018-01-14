using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public GameObject bullet;
	public GameObject bulletPrefab;
	public GameObject tank;
	Vector3 shootDirection;

	void Update () {
		Vector3 pos = transform.position;

		if (Input.GetKey ("w")) {
			pos.y += speed * Time.deltaTime;
		}
		if (Input.GetKey ("s")) {
			pos.y -= speed * Time.deltaTime;
		}
		if (Input.GetKey ("d")) {
			pos.x += speed * Time.deltaTime;
		}
		if (Input.GetKey ("a")) {
			pos.x -= speed * Time.deltaTime;
		}


		transform.position = pos;

		if (Input.GetMouseButtonDown (0)) {
			shootDirection = Camera.main.ScreenToWorldPoint (Input.mousePosition)- transform.position;
			GameObject bullet = Instantiate (bulletPrefab,tank.transform.position,Quaternion.identity);
			bullet.GetComponent<Shooting>(). SetDirection (shootDirection);
		}
	}
}
