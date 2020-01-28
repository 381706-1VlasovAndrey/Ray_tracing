using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
  public float speed = 30.0f;
    void Update()
    {
    if (Input.GetAxis("Horizontal") > 0) {
      transform.Translate(transform.right * speed);
    }
    else if (Input.GetAxis("Horizontal") < 0) {
      transform.Translate(-transform.right * speed);
    }
    if (Input.GetAxis("Vertical") > 0)
    {
      transform.Translate(transform.forward * speed);
    }
    else if (Input.GetAxis("Vertical") < 0)
    {
      transform.Translate(-transform.forward * speed);
    }
    if (Input.GetAxis("Jump") > 0)
    {
      transform.Translate(transform.up * speed);
    }
    if (Input.GetAxis("Jump") < 0)
    {
      transform.Translate(-transform.up * speed);
    }
  }
}
