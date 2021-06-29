using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrigger : MonoBehaviour
{
    public GameObject _Explosion;
    private Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Plane"))
        {
            StartCoroutine(ExplosionCoroutine());
        }
    }

    IEnumerator ExplosionCoroutine()
    {
        Instantiate(_Explosion, this.gameObject.transform.position, transform.rotation);
        rb.useGravity = false;
        yield return new WaitForSeconds(0.5f);

        Destroy(this.gameObject);
    }


}