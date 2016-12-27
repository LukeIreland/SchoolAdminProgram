using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Media;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class RemoteDesktopService : IRemoteDesktop
    {       
        private CaptureScreen capture = new CaptureScreen();
        public byte[] UpdateScreenImage()
        {
            // Capture minimally sized image that encompasses
            //    all the changed pixels.
            //
            Rectangle bounds = new Rectangle();
            Bitmap img = capture.Screen(ref bounds);
            if (img != null)
            {
                // Something changed.
                //
                byte[] result = Utils.PackScreenCaptureData(img, bounds);
 
                // Log to the console.
                //
                Console.WriteLine(DateTime.Now.ToString() + " Screen Capture - {0} bytes", result.Length);
                return result;
            }
            else
            {
                // Nothing changed.
                //
 
                // Log to the console.
                Console.WriteLine(DateTime.Now.ToString() + " Screen Capture - {0} bytes", 0);
                return null;
            }
        }

        public byte[] UpdateCursorImage()
        {
            // Get the cursor bitmap.
            //
            int cursorX = 0;
            int cursorY = 0;
            Bitmap img = capture.Cursor(ref cursorX, ref cursorY);
            if (img != null)
            {
                // Something changed.
                //
                byte[] result = Utils.PackCursorCaptureData(img, cursorX, cursorY);
 
                // Log to the console.
                //
                Console.WriteLine(DateTime.Now.ToString() + " Cursor Capture - {0} bytes", result.Length);
                return result;
            }
            else
            {
                // Nothing changed.
                //
 
                // Log to the console.
                //
                Console.WriteLine(DateTime.Now.ToString() + " Cursor Capture - {0} bytes", 0);
                return null;
            }
        }
    }

            public static byte[] PackScreenCaptureData(Image image, Rectangle bounds)
            {
                // Pack the image data into a byte stream to
                //    be transferred over the wire.
                //
 
                // Get the bytes of the image data.
                //    Note: We are using JPEG compression.
                //
                byte[] imgData;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgData = ms.ToArray();
                }
 
                // Get the bytes that describe the bounding
                //    rectangle.
                //
                byte[] topData = BitConverter.GetBytes(bounds.Top);
                byte[] botData = BitConverter.GetBytes(bounds.Bottom);
                byte[] leftData = BitConverter.GetBytes(bounds.Left);
                byte[] rightData = BitConverter.GetBytes(bounds.Right);
 
                // Create the final byte stream.
                // Note: We are streaming back both the bounding
                //    rectangle and the image data.
                //
                int sizeOfInt = topData.Length;
                byte[] result = new byte[imgData.Length + 4 * sizeOfInt];
                Array.Copy(topData, 0, result, 0, topData.Length);
                Array.Copy(botData, 0, result, sizeOfInt, botData.Length);
                Array.Copy(leftData, 0, result, 2 * sizeOfInt, leftData.Length);
                Array.Copy(rightData, 0, result, 3 * sizeOfInt, rightData.Length);
                Array.Copy(imgData, 0, result, 4 * sizeOfInt, imgData.Length);
 
                return result;
            }
        }
    }
}
