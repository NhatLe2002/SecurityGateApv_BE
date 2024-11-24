using SecurityGateApv.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Models
{
    public class Camera
    {
        [Key]
        public int Id { get; set; }
        public string CaptureURL { get; private set; }
        public string StreamURL { get; private set; }
        public string Description { get; private set; }
        public bool Status { get; private set; }


        [ForeignKey("Gate")]
        public int GateId { get; private set; }
        public Gate Gate { get; private set; }


        [ForeignKey("CameraType")]
        public int CameraTypeId { get; private set; }
        public CameraType CameraType { get; private set; }

        private Camera(string captureURL, string streamURL, string description, bool status, int gateId, int cameraTypeId)
        {
            CaptureURL = captureURL;
            StreamURL = streamURL;
            Description = description;
            Status = status;
            GateId = gateId;
            CameraTypeId = cameraTypeId;
        }
        public Camera(string captureURL, string streamURL, string description, bool status, int cameraTypeId, Gate gate)
        {
            CaptureURL = captureURL;
            StreamURL = streamURL;
            Description = description;
            Status = status;
            Gate = gate;
            CameraTypeId = cameraTypeId;
        }
        private Camera(int cameraId, string captureURL, string streamURL, string description, bool status, int gateId, int cameraTypeId)
        {
            Id = cameraId;
            CaptureURL = captureURL;
            StreamURL = streamURL;
            Description = description;
            Status = status;
            GateId = gateId;
            CameraTypeId = cameraTypeId;
        }
        public static Result<Camera> Create(string captureURL, string streamURL, string description, bool status, int gateId, int cameraTypeId)
        {
            var camera = new Camera(captureURL, streamURL, description, status, gateId, cameraTypeId);
            return Result.Success(camera);

        } 
        public static Result<Camera> Create(int cameraId,string captureURL, string streamURL, string description, bool status, int gateId, int cameraTypeId)
        {
            var camera = new Camera(cameraId, captureURL, streamURL, description, status, gateId, cameraTypeId);
            return Result.Success(camera);

        }
    }
}
