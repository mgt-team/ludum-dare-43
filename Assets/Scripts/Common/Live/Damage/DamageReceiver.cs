using UnityEngine;

[RequireComponent(typeof(Liveble))]
public class DamageReceiver : MonoBehaviour
{

	private Liveble _liveble;
	private DamageEffect _damageEffect;
	
	// Use this for initialization
	private void Start ()
	{
		_liveble = GetComponent<Liveble>();
	}

	public void ReceiveDamage(DamageInfo damageInfo)
	{
		_liveble.DecreaseHp(damageInfo.DamageCount);
		_damageEffect.OnDamageReceived(damageInfo);
	}
	
}
