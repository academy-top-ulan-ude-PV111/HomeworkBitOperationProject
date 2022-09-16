namespace HomeworkBitOperationProject
{
    internal class Program
    {
        static void BinPrint(int number)
        {
            if (number >= 2)
                BinPrint(number / 2);
            Console.Write(number % 2);
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("Input number: ");
            number = Convert.ToInt32(Console.ReadLine());

            int mask32 = 1 << 31;
            for(int i = 1; i < 32; i++)
            {
                if (((number << i) & mask32) != 0)
                    Console.Write(1);
                else
                    Console.Write(0);
                
            }

            Console.WriteLine();

            BinPrint(number);

            Console.WriteLine();

            char[] hexChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int mask8 = 255;
            int mask4 = 15;

            byte numByte;
            byte hexDigit;

            for(int i = 0; i < 4; i++)
            {
                int step = i * 8;
                numByte = (byte)((number & (mask8 << step)) >> step);

                //Console.WriteLine(numByte);

                hexDigit = (byte)(numByte >> 4);
                Console.Write(hexChars[hexDigit]);
                hexDigit = (byte)(numByte & mask4);
                Console.Write(hexChars[hexDigit]);
            }

            ////1
            //numByte = (byte)((number & (mask8 << 0)) >> 0);

            ////Console.WriteLine(numByte);

            //hexDigit = (byte)(numByte >> 4);
            //Console.Write(hexChars[hexDigit]);
            //hexDigit = (byte)(numByte & mask4);
            //Console.Write(hexChars[hexDigit]);

            ////2
            //numByte = (byte)((number & (mask8 << 8)) >> 8);

            ////Console.WriteLine(numByte);

            //hexDigit = (byte)(numByte >> 4);
            //Console.Write(hexChars[hexDigit]);
            //hexDigit = (byte)(numByte & mask4);
            //Console.Write(hexChars[hexDigit]);

            ////3
            //numByte = (byte)((number & (mask8 << 16)) >> 16);

            ////Console.WriteLine(numByte);

            //hexDigit = (byte)(numByte >> 4);
            //Console.Write(hexChars[hexDigit]);
            //hexDigit = (byte)(numByte & mask4);
            //Console.Write(hexChars[hexDigit]);

            ////3
            //numByte = (byte)((number & (mask8 << 24)) >> 24);

            ////Console.WriteLine(numByte);

            //hexDigit = (byte)(numByte >> 4);
            //Console.Write(hexChars[hexDigit]);
            //hexDigit = (byte)(numByte & mask4);
            //Console.Write(hexChars[hexDigit]);
        }
    }
}