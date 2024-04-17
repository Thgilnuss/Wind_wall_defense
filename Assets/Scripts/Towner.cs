using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towner : MonoBehaviour
{
    Rigidbody2D rigid;

	void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
	}
}
