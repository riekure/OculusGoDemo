using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject cubeObject;
    public float shotSpeed;
    public float shotTorque;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shot();
        }
    }
    
    void Shot()
    {
        // プレファブからCubeオブジェクトを生成
        GameObject cube = (GameObject)Instantiate(cubeObject, transform.position, Quaternion.identity);

        // 速度を追加
        Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();
        cubeRigidbody.AddForce(transform.forward * shotSpeed);
        cubeRigidbody.AddTorque(new Vector3(0, shotTorque, 0));
    }
}
