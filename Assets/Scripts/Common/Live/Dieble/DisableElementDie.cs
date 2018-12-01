using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableElementDie : Dieble {

	public override void Die()
	{
		gameObject.SetActive(false);
	}
}
