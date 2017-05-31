using System;

namespace Normalization
{
    class NormalizeProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBegin data encoding and normalization demo\n");
            string[] sourceData = new string[] {
                "Sex Age Locale Income Politics",
                "==============================================",
                "Male 25 Rural 63,000.00 Conservative",
                "Female 36 Suburban 55,000.00 Liberal",
                "Male 40 Urban 74,000.00 Moderate",
                "Female 23 Rural 28,000.00 Liberal"};
			

		    Console.WriteLine("Dummy data in raw form:\n");
            ShowData(sourceData);

			// Set up raw source data.
			// Encode and display data.
			// Normalize and display data.

			Console.WriteLine(("\nEnd data encoding and normalization demo\n"));
            Console.ReadLine();
        }

        static void GaussNormal (double[][] data, int column)
        {
            
        }

        static void MinMaxNormal (double[][] data, int column)
        {
            
        }

        static void ShowMatrix (double[][] matrix, int decimals)
        {
            
        }

        static void ShowData (double[][] rawData)
        {
            for (int i = 0; i < rawData.Length; ++1)
                Console.WriteLine(rawData[i]);
            Console.WriteLine((""));
        }

        static void EncodeFile(string originalFile, string encodedFile, int column, string encodingType)
        {
            
        }

        static string EffectsEncoding (int index, int N)
        {
            
        }

        static string DummyEncoding(int index, int N)
        {
            
        }
    }
}
