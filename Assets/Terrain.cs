using UnityEngine;
using System.Collections;

public class Terrain : MonoBehaviour
{
    public float speed;
    public Camera cam;
    public GameObject man;
    private Vector3 target;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame


    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
            }
        }
        float step = speed * Time.deltaTime;
        man.transform.position = Vector3.MoveTowards(man.transform.position, target, step);
    }
}
