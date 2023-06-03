/*using UnityEngine;

public class Blade : MonoBehaviour
{
    private Collider bladeCollider;
    private Touch touch;
    private float speed = 0.01f;
    private bool slicing;
    private TrailRenderer bladeTrail;

    public Vector3 direction { get; private set; }
    public float sliceForce = 10f;


    private void Awake()
    {
        bladeCollider = GetComponent<Collider>();
        bladeTrail = GetComponentInChildren<TrailRenderer>();
    }
    private void StartSlicing()
    {
        slicing = true;
        bladeCollider.enabled = true;
        bladeTrail.enabled = true;
        
    }

    private void StopSlicing()
    {
        bladeTrail.Clear();
        slicing = false;
        bladeCollider.enabled = false;
        bladeTrail.enabled = false;
    }
    private void Update () 
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y + touch.deltaPosition.y * speed, transform.position.z);
                StartSlicing();
            }

            else if (touch.phase != TouchPhase.Moved)
            {
                StopSlicing();
            }

          
        }
     

    }


}*/

using UnityEngine;

public class Blade : MonoBehaviour
{
    public Vector3 direction { get; private set; }

    private Camera mainCamera;
    private Touch touch;
    private Collider sliceCollider;
    //private TrailRenderer sliceTrail;
    private float speed = 0.01f;

    public float sliceForce = 5f;
    public float minSliceVelocity = 0.01f;

    private bool slicing;

    private void Awake()
    {
        //mainCamera = Camera.main;
        sliceCollider = GetComponent<Collider>();
        //sliceTrail = GetComponentInChildren<TrailRenderer>();
    }

    private void OnEnable()
    {
        StartSlice();
        slicing = true;
        //sliceTrail.enabled = true;
    }

    private void OnDisable()
    {
        StopSlice();
        //sliceTrail.Clear();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y + touch.deltaPosition.y * speed, transform.position.z);
                StartSlice();
            }

            else if (touch.phase != TouchPhase.Moved)
            {
                StopSlice();
            }


        }
    }

    private void StartSlice()
    {
        //Vector3 position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        //position.z = 0f;
        //transform.position = position;

        slicing = true;
        sliceCollider.enabled = true;
        //sliceTrail.enabled = true;
        //sliceTrail.Clear();
    }

    private void StopSlice()
    {
        slicing = false;
        sliceCollider.enabled = false;
        //sliceTrail.enabled = false;
    }

    //private void ContinueSlice()
    //{
        /*Vector3 newPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = 0f;

        direction = newPosition - transform.position;

        float velocity = direction.magnitude / Time.deltaTime;
        sliceCollider.enabled = velocity > minSliceVelocity;

        transform.position = newPosition;*/
    //}

}