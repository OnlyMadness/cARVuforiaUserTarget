
using UnityEngine;
using UnityEngine.UI;

public class QualityTarget : MonoBehaviour
{
    //public Image[] LowMedHigh;
    //public Renderer xer;
    void SetMeter(Color low)
    {
        
        GameObject circle = GameObject.Find("Circle") ;
        // QualityTarget colorCircle = circle.GetComponent<QualityTarget>();
        //xer = GetComponent<Renderer>("Circle");


        //GameObject MyObject = GameObject.(PrimitiveType.Cube);
        Renderer MyRender = circle.GetComponent<Renderer>();
        Color MyColor = low;
        MyRender.material.color = MyColor;
       
    }

    public void SetQuality(Vuforia.ImageTargetBuilder.FrameQuality quality)
    {
        switch (quality)
        {
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_NONE):
                SetMeter(Color.gray);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_LOW):
                SetMeter(Color.red);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_MEDIUM):
                SetMeter(Color.yellow);
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_HIGH):
                SetMeter(Color.green);
                break;
        }
    }
}
