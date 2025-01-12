using UnityEngine;

public class paparazzi : MonoBehaviour
{

    public Transform Betiv;
    public float xViteza = .3f;

    private Vector3 Velocitate;

    void LateUpdate()
    {
        if (Betiv.position.y > transform.position.y)
        {
            Vector3 PozitieNoua = new Vector3(0f, Betiv.position.y, -10f);
            transform.position = Vector3.SmoothDamp(transform.position, PozitieNoua, ref Velocitate, xViteza * Time.deltaTime);   
        }
    }
}
