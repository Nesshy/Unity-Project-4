using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEt : MonoBehaviour
{
    private RaycastHit hit; // RaycastHit'i bir önceki çerçeveden devralýnmýþ bir referans olarak tanýmlayýn

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward); // Örnek olarak, nesnenin pozisyonu ve bakýþ yönü kullanýldý.

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider != null && hit.collider.gameObject.tag == "Traa")
            {
                print(hit.collider.gameObject.name);
                Destroy(hit.collider.gameObject);
            }
        }
    }
    /*RaycastHit hit;

    if (Input.GetMouseButtonDown(0)) 
    {
        if (Physics.Raycast(Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.tag == "tree")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }*/
}

