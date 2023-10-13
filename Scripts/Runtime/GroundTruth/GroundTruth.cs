using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FRJ.Sensor
{
  public class GroundTruth : MonoBehaviour
  {

    private Transform _trans;

    private Vector3 _geometryEuclidean;
    private Quaternion _geometryQuaternion;

    [SerializeField] private float _updateRate = 100f;
    public float updateRate{ get => this._updateRate; }

    public Vector3 GeometryEuclidean { get => _geometryEuclidean; }
    public Quaternion GeometryQuaternion { get => _geometryQuaternion; }

    // Start is called before the first frame update
    private void Start()
    {
      this._trans = this.GetComponent<Transform>();
      this._geometryEuclidean = new Vector3();
      this._geometryQuaternion = new Quaternion();
    }

    // Update is called once per frame
    public void UpdateGroundTruth()
    {
      this._geometryEuclidean = new Vector3(this._trans.position.x, this._trans.position.y, this._trans.position.z);
      this._geometryQuaternion = new Quaternion(this._trans.rotation.x, this._trans.rotation.y, this._trans.rotation.z, this._trans.rotation.w);
    }
  }
}