using UnityEngine;

public class MooveTheBall : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {

        float moveHorizontal;
        float moveVertical;

        if (Application.platform == RuntimePlatform.Android)
        {

            moveHorizontal = Input.acceleration.x;
            moveVertical = Input.acceleration.y;

        }
        else
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
    //изначальный код
    //float speed = 4.0f;

    //void Update()
    //{
    //    Vector3 dir = Vector3.zero;
    //    //dir.x = Input.acceleration.y;
    //    //dir.z = Input.acceleration.x;

    //    dir.x = Input.acceleration.x;
    //    dir.z = Input.acceleration.y;

    //    if (dir.sqrMagnitude > 1)
    //        dir.Normalize();


    //    dir *= Time.deltaTime;

    //    transform.Translate(dir * speed);
    //}
}
