using UnityEngine;

public class RotationOverride : MonoBehaviour
{
	public Vector3 euler;

	void Update()
	{
		transform.rotation = Quaternion.Euler(0.0f, euler.y, 0.0f) * Quaternion.Euler(euler.x, 0.0f, 0.0f) * Quaternion.Euler(0.0f, 0.0f, euler.z);
	//	transform.rotation = Quaternion.Euler(euler);
	}
}
