using System;
using System.Collections;
using System.Collections.Generic;
/*using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Fruit : MonoBehaviour
{

    public GameObject Whole;
    public GameObject Slicedfruit;

    private Rigidbody fruitRigidbody;
    private Collider fruitCollider;

    private void Slice(Vector3 direction, Vector3 position, float force)
    {
       // Debug.Print("Slice called");
        
        Whole.SetActive(false);
        Slicedfruit.SetActive(true);

        fruitCollider.enabled = false;

        double dirY = Convert.ToDouble(direction.y);
        double dirX = Convert.ToDouble(direction.x);
        float angle = Convert.ToSingle(Math.Atan2(dirY, dirX) * Mathf.Rad2Deg);
        Slicedfruit.transform.rotation = Quaternion.Euler(0f, 0f, angle);

        Rigidbody[] slices = Slicedfruit.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody slice in slices)
        {
            slice.velocity = fruitRigidbody.velocity;
            slice.AddForceAtPosition(direction*force, position, ForceMode.Impulse);

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("points"))
        {
            Blade blade = other.GetComponent<Blade>();

            Slice(blade.direction, blade.transform.position, blade.sliceForce);

        }
    }
    
}
*/
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public bool wb;
    public bool sb;
    public GameObject whole;
    public GameObject sliced;

    private Rigidbody fruitRigidbody;
    private Collider fruitCollider;
    private ParticleSystem juiceEffect;

    public int points = 1;

    public void Awake()
    {
        fruitRigidbody = GetComponent<Rigidbody>();
        fruitCollider = GetComponent<Collider>();
        juiceEffect = GetComponentInChildren<ParticleSystem>();
    }

    public void Slice(Vector3 direction, Vector3 position, float force)
    {
        //FindObjectOfType<GameManager>().IncreaseScore(points);

        Console. Write("working whole");
        fruitCollider.enabled = false;
        whole.SetActive(false);

        Console. Write("working sliced");
        sliced.SetActive(true);
        //juiceEffect.Play();


        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        sliced.transform.rotation = Quaternion.Euler(0f, 0f, angle);

        Rigidbody[] slices = sliced.GetComponentsInChildren<Rigidbody>();


        foreach (Rigidbody slice in slices)
        {
            slice.velocity = fruitRigidbody.velocity;
            slice.AddForceAtPosition(direction * force, position, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Blade blade = other.GetComponent<Blade>();
            Slice(blade.direction, blade.transform.position, blade.sliceForce);
        }
    }

}