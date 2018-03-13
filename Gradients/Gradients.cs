using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Gradients
{
    public class GradientsTerraria
    {
        //This code is pure, unoptimized garbage. Have fun. Obviously, if you find bugs, tell me.
        //Also, clearly represented by this snippet, i'm not the best coder.
        public static string Gradient(string message, Color startColor, Color endColor)
        {
            string gradmessage = String.Empty;
            bool rRise = false;
            bool gRise = false;
            bool bRise = false;
            int R = startColor.R;
            int G = startColor.G;
            int B = startColor.B;
            Color oldColor = new Color(R, G, B);
            int R1 = endColor.R;
            int G1 = endColor.G;
            int B1 = endColor.B;
            int R2 = -1;
            int G2 = -1;
            int B2 = -1;
            Color newColor = new Color(R1, G1, B1);
            if (R > R1)
            {
                rRise = false;
            }
            else if (R < R1)
            {
                rRise = true;
            }
            if (G > G1)
            {
                gRise = false;
            }
            else if (G < G1)
            {
                gRise = true;
            }
            if (B > B1)
            {
                bRise = false;
            }
            else if (B < B1)
            {
                bRise = true;
            }
            if (bRise)
            {
                B2 = B1 - B;
            }
            else
            {
                B2 = B - B1;
            }
            if (gRise)
            {
                G2 = G1 - G;
            }
            else
            {
                G2 = G - G1;
            }
            if (rRise)
            {
                R2 = R1 - R;
            }
            else
            {
                R2 = R - R1;
            }
            int riseRperchar = R2 / message.Length;
            int riseGperchar = G2 / message.Length;
            int riseBperchar = B2 / message.Length;

            foreach (char c in message)
            {
                string hex = oldColor.R.ToString("X2") + oldColor.G.ToString("X2") + oldColor.B.ToString("X2");
                gradmessage += "[c/" + hex + ":" + c + "]";
                if (rRise)
                {
                    R = R + riseRperchar;
                }
                else
                {
                    R = R - riseRperchar;
                }
                if (bRise)
                {
                    B = B + riseBperchar;
                }
                else
                {
                    B = B - riseBperchar;
                }

                if (gRise)
                {
                    G = G + riseGperchar;
                }
                else
                {
                    G = G - riseGperchar;
                }
                oldColor = new Color(R, G, B);
            }
            return gradmessage;
        }
    }
}
