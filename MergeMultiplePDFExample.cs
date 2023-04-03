using org.pdfclown.files;
using System.Collections.Generic;
using System.Linq;

namespace TestingConsoleApp
{
	public class MergeMultiplePDFExample
	{
		//MargeMultiplePDF();
		public static void MargeMultiplePDF()
		{
			string pdf1 = "c:/files/second.pdf";
			string pdf2 = "c:/files/first.pdf";

			string pdf3 = "c:/files/third3.pdf";
			string pdf4 = "c:/files/third4.pdf";
			byte[] a = System.IO.File.ReadAllBytes(pdf1);
			byte[] b = System.IO.File.ReadAllBytes(pdf2);

			List<byte> list = new List<byte>();
			foreach (var i in a)
			{
				list.Add(i);

			}
			foreach (var j in b)
			{
				list.Add(j);

			}
			//	list.AddRange(b);

			byte[] c = list.ToArray();

			//byte[] bytesf3 = Concat(a, b);

			IEnumerable<byte> Con_A_and_B = a.Concat(b);

			var g = a.Clone();

			a.CopyTo(b, a.Length);

			System.IO.File.WriteAllBytes(pdf3, b);

			System.IO.File.WriteAllBytes(pdf4, c);
			//System.IO.File.WriteAllBytes(pdf4, Con_A_and_B.ToArray());

			MergePdf(c, pdf4);
		}
		static byte[] Concat(byte[] a, byte[] b)
		{
			byte[] output = new byte[a.Length + b.Length];
			for (int i = 0; i < a.Length; i++)
				output[i] = a[i];
			for (int j = 0; j < b.Length; j++)
				output[a.Length + j] = b[j];
			return output;
		}

		public static void MergePdf(byte[] d, string destFile)
		{


			using (var dest = new org.pdfclown.files.File(new org.pdfclown.bytes.Buffer(d)))
			{
				var document = dest.Document;
				var builder = new org.pdfclown.tools.PageManager(document);

				using (var src = new org.pdfclown.files.File(new org.pdfclown.bytes.Buffer(d)))
				{ builder.Add(src.Document); }

				dest.Save(destFile, SerializationModeEnum.Incremental);
			}
		}

	}
}
