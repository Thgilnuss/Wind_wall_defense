using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	// Start is called before the first frame update
	public float damage;
	public int per;

	public void Init(float damage, int per)
	{
		this.damage = damage;
		this.per = per;
	}
}
