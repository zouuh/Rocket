using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probabilities : MonoBehaviour
{
    public float loiUniforme(float[] scales){
        int i;
        i = (int)Random.Range(0, scales.Length);
        return scales[i];
    }

    public float loiNormale(float mu, float sigma) {
        float x = 0;
        float y = 1;
        float var = 0;
        while(y>var) {
            x = (float)Random.Range(-4, 4f);
            y = (float)Random.Range(0, 0.8f / ( Mathf.Sqrt(2*Mathf.PI*sigma) ));
            var = ( 1 / ( Mathf.Sqrt(2*Mathf.PI*sigma) ) ) * ( Mathf.Exp( -1f/2f*Mathf.Pow( 2,(x-mu) )/sigma ) );
        }
        return x;
    }


}
