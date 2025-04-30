using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject target; //target sprite
    [SerializeField] Rigidbody2D bulletPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //shoot raycast to detect mouse clicked position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 5f, Color.red, 5f);

            //get click point
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);


        }
    }
}
