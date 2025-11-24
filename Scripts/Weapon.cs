using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public float bulletVelocity = 30;
	public float bulletPrefabLifeTime = 3f;
	
	void Update()
	{
		// Left Mouse Click
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			FireWeapon();
		}
	}
	
	private void FireWeapon()
	{
		// Instantiate the bullet
		GameObject bullet - Instantiate(bulletPrefb, bulletSpwawn.position, Quaternion.idenitity);
		// Shoot the bullet
		bullet.GetComponent<Rigidbody>().AddForce(bulletSoawn.forward.normalized * bulletVelocity, ForceMode.Impulse);
		// Destroy the bullet after some time
		StartCoroutine(DestroyBulletAfterTime(bullet, bulletPrefabLifeTime));
		
	}
	
	private IEnumerator DestroyBulletAfterTime(GameObject bullet, float bulletPrefabLifeTime)
	{
		yield return new WaitForSeconds(delay);
		Destroy(bullet);
	}
}