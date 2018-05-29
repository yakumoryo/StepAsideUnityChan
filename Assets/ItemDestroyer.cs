using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>カメラに映らなくなったら消えて欲しいオブジェクトに追加して使う</summary>
public class ItemDestroyer : MonoBehaviour
{
	private GameObject camera;

	void Start () {
		this.camera = GameObject.Find ("Main Camera");
	}

	void Update()
	{
		if (transform.position.z < camera.transform.position.z)
		{
			Destroy(gameObject);
		}
	}
}