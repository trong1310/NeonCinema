using System;
using System.IO;
using SkiaSharp;
using ZXing.SkiaSharp;
using ZXing;
using System.DrawingCore;

namespace NeonCinema_Infrastructure.Services
{
	public class GennarateBarCode
	{
		public static string GenerateBarcode(long number)
		{
			// Nội dung mã vạch
			string barcodeContent = number.ToString();

			// Cấu hình BarcodeWriter
			var barcodeWriter = new ZXing.SkiaSharp.BarcodeWriter
			{
				Format = BarcodeFormat.CODE_128,
				Options = new ZXing.Common.EncodingOptions
				{
					Height = 200, // Chiều cao mã vạch
					Width = 400,  // Chiều rộng mã vạch
					Margin = 10   // Lề
				}
			};

			// Tạo mã vạch dưới dạng SKBitmap
			var barcodeBitmap = barcodeWriter.Write(barcodeContent);

			// Tạo canvas để vẽ mã vạch
			var info = new SKImageInfo(400, 200);
			using var surface = SKSurface.Create(info);
			var canvas = surface.Canvas;

			// Đặt nền trắng
			canvas.Clear(SKColors.White);
			canvas.DrawBitmap(barcodeBitmap, 50, 50);

			// Vẽ text dưới mã vạch
			using var paint = new SKPaint
			{
				Color = SKColors.Black,
				TextSize = 24,
				IsAntialias = true,
				Typeface = SKTypeface.FromFamilyName("Arial")
			};

			var textWidth = paint.MeasureText(barcodeContent);
			float xText = (info.Width - textWidth) / 2;
			float yText = 160; // Vị trí text bên dưới mã vạch
			canvas.DrawText(barcodeContent, xText, yText, paint);

			// Chuyển đổi canvas sang Base64
			using var image = surface.Snapshot();
			using var data = image.Encode(SKEncodedImageFormat.Png, 100);
			string base64String = Convert.ToBase64String(data.ToArray());
			return base64String;
		}
		//private GraphicsPath CreateRoundedRectanglePath(System.Drawing.Rectangle rect, int cornerRadius)
		//{
		//	GraphicsPath path = new GraphicsPath();
		//	int diameter = cornerRadius * 2;

		//	// Góc trên bên trái
		//	path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
		//	// Góc trên bên phải
		//	path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
		//	// Góc dưới bên phải
		//	path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
		//	// Góc dưới bên trái
		//	path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
		//	path.CloseFigure();

		//	return path;
		//}
	}

}
		


