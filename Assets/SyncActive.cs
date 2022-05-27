using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncActive : MonoBehaviour
{
	public GameObject Target;
	public bool SyncEnable;
	public bool SyncDisable;


	private void OnEnable()
	{
		if (SyncEnable)
		{
			Target.SetActive(true);
		}
	}

	private void OnDisable()
	{
		if (SyncDisable)
			Target.SetActive(false);
	}
}
