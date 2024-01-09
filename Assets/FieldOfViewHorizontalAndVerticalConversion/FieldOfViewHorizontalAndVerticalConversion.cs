using UnityEngine;

public class FieldOfViewHorizontalAndVerticalConversion : MonoBehaviour
{
	void Update()
	{
		float aspect = (float)Screen.width / (float)Screen.height;
		float fovY = Camera.main.fieldOfView;
		float fovX;

		fovX = Camera.VerticalToHorizontalFieldOfView(fovY, aspect);
		fovY = Camera.HorizontalToVerticalFieldOfView(fovX, aspect);
		Debug.Log("Unity's:    " + fovY + "    " + fovX);

		fovX = MyVerticalToHorizontalFieldOfView(fovY, aspect);
		fovY = MyHorizontalToVerticalFieldOfView(fovX, aspect);
		Debug.Log("My:    " + fovY + "    " + fovX);
	}

	private float MyVerticalToHorizontalFieldOfView(float fovY, float aspect)
	{
		fovY *= Mathf.Deg2Rad;
		float fovX = 2.0f * Mathf.Atan(aspect * Mathf.Tan(fovY / 2.0f));
		return fovX * Mathf.Rad2Deg;
	}

	private float MyHorizontalToVerticalFieldOfView(float fovX, float aspect)
	{
		fovX *= Mathf.Deg2Rad;
		float fovY = 2.0f * Mathf.Atan(1.0f/aspect * Mathf.Tan(fovX / 2.0f));
		return fovY * Mathf.Rad2Deg;
	}
}
