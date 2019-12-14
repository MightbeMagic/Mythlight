using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
	public CameraControlState cameraState = CameraControlState.BUILD;
	protected Camera m_mainCamera = null;
	public float zoomSpeed = 1;
	public float zoom = 5;
	public int zoomMaximum = 10;
	public int zoomMinimum = 1;

	public float moveSpeed = 1;

	public Vector2 cameraDefaultPosition = Vector2.zero;

	private void Awake()
	{
		m_mainCamera = GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update()
    {
        switch(cameraState)
		{
			case CameraControlState.BUILD:
				DoPlayerControledCameraMovement();
				break;
			default:
				break;
		}
    }


	void DoPlayerControledCameraMovement()
	{
		#region Zoom
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if (zoom > zoomMinimum) zoom -= zoomSpeed;
		}
		else if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			if (zoom < zoomMaximum) zoom += zoomSpeed;
		}
		m_mainCamera.orthographicSize = zoom;
		#endregion

		#region Horizontal and Vertical Movement by Keys

		if(Input.GetAxis("Horizontal") > 0)
		{
			m_mainCamera.transform.position = m_mainCamera.transform.position + new Vector3(moveSpeed, 0);
		}
		else if (Input.GetAxis("Horizontal") < 0)
		{
			m_mainCamera.transform.position = m_mainCamera.transform.position + new Vector3(-moveSpeed, 0);
		}

		if (Input.GetAxis("Vertical") > 0)
		{
			m_mainCamera.transform.position = m_mainCamera.transform.position + new Vector3(0, moveSpeed);
		}
		else if (Input.GetAxis("Vertical") < 0)
		{
			m_mainCamera.transform.position = m_mainCamera.transform.position + new Vector3(0, -moveSpeed);
		}

		#endregion
	}
}

public enum CameraControlState
{
	GAME,
	BUILD,
	MENU
}