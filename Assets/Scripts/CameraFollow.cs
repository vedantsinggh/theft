using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
    private Camera cam;
    public float yOffset;

    void Start()
    {
        cam = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update () 
	{
		if (target)
		{
			Vector3 point = cam.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            delta.y += yOffset;
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	
	}
}