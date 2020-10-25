using UnityEngine;
using System.Collections;

public class GyroCamera : MonoBehaviour
{
    private Quaternion Rotation_Origin;
    private Gyroscope Gyroscope_Reference;
    // STATE
    private float _initialYAngle = 0f;
    private float _appliedGyroYAngle = 0f;
    private float _calibrationYAngle = 0f;
    private Transform _rawGyroRotation;
    private float _tempSmoothing;

    // SETTINGS
    [SerializeField] private float _smoothing = 0.1f;
    public float touchRotAdjust = 1f;
    private IEnumerator Start()
    {
        Input.gyro.enabled = true;
        Application.targetFrameRate = 60;
        _initialYAngle = Input.compass.trueHeading;

        _rawGyroRotation = new GameObject("GyroRaw").transform;
        _rawGyroRotation.position = transform.position;
        _rawGyroRotation.rotation = transform.rotation;

        // Wait until gyro is active, then calibrate to reset starting rotation.
        yield return new WaitForSeconds(1);

        StartCoroutine(CalibrateYAngle());
    }

    private void Update()
    {

        ApplyGyroRotation();
        ApplyCalibration();

        transform.rotation = Quaternion.Slerp(transform.rotation, _rawGyroRotation.rotation, _smoothing);
    }

    private IEnumerator CalibrateYAngle()
    {
        _tempSmoothing = _smoothing;
        _smoothing = 1;
        _calibrationYAngle = _appliedGyroYAngle - _initialYAngle; // Offsets the y angle in case it wasn't 0 at edit time.
        yield return null;
        _smoothing = _tempSmoothing;
    }

    private void ApplyGyroRotation()
    {
        _rawGyroRotation.rotation = Input.gyro.attitude;
        _rawGyroRotation.Rotate(0f, 0f, 180f, Space.Self); // Swap "handedness" of quaternion from gyro.
        _rawGyroRotation.Rotate(90f, 180f, 0f, Space.World); // Rotate to make sense as a camera pointing out the back of your device.
        _appliedGyroYAngle = _rawGyroRotation.eulerAngles.y; // Save the angle around y axis for use in calibration.
    }

    private void ApplyCalibration()
    {
        _rawGyroRotation.Rotate(0f, -_calibrationYAngle, 0f, Space.World); // Rotates y angle back however much it deviated when calibrationYAngle was saved.
    }

    public void SetEnabled(bool value)
    {
        enabled = true;
        StartCoroutine(CalibrateYAngle());
    }
    private void Awake()
    {
        Gyroscope_Reference = Input.gyro;
        Gyroscope_Reference.enabled = true;
        StartCoroutine(Coroutine_Method());
    }

    private IEnumerator Coroutine_Method()
    {
        yield return null;
        Quaternion Rotation_Origin_Addend = Quaternion.Euler(0, 0, 180);
        Rotation_Origin = Gyroscope_Reference.attitude * Rotation_Origin_Addend;

        Quaternion Gyroscope_Attitude_Difference_Addend = Quaternion.Euler(180, 180, 0);

        while (true)
        {
            Quaternion Gyroscope_Attitude_Difference = Quaternion.Inverse(Rotation_Origin) * Gyroscope_Reference.attitude;
            Gyroscope_Attitude_Difference *= Gyroscope_Attitude_Difference_Addend;

            Quaternion Lerped_Quaternion = Quaternion.Lerp(transform.rotation, Gyroscope_Attitude_Difference, 8 * Time.deltaTime);
            transform.rotation = Lerped_Quaternion;

            //transform.Rotate(0f, 0f, 180f, Space.Self);
            //transform.Rotate(-180f, 180f, 0, Space.World);
            yield return null;
        }
    }
}