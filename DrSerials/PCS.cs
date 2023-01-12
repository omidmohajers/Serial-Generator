using System;
using System.Management;

namespace PA.SystemValidation
{
    public class PCS
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public string pSerial { get; set; }
        public string sSerial { get; set; }



        public string GetSystemSerial()
        {
            string cpu = GetFirstCPUId();
            int len = cpu.Length / 3;

            int cpuHash = Math.Abs(cpu.GetHashCode());


            char[] cpuparts = new char[len];

            for (int i = 0; i < len; i++)
            {
                int x = Convert.ToInt32(cpu[i * 3]) & Convert.ToInt32(cpu[i * 3 + 1]);
                x = Convert.ToInt32(cpu[i * 2 + 2]) ^ x;

                cpuparts[i] = Convert.ToChar(x);
            }

            char[] code = { '6', '3', '1', '5', '9' };//, '6', '7', '9', '0', '1', '2', '6', '8', '4', '0' };

            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                int x = Convert.ToInt32(code[i]) ^ Convert.ToInt32(cpuparts[j]);
                j++;
                if (j >= len)
                    j = 0;

                code[i] = ((x ^ cpuHash) % 10).ToString()[0];
            }

            char[] code2 = (char[])code.Clone();

            int n = 0;
            for (int i = code.Length - 1; i >= 0; i--)
            {
                code2[n++] = code[i];
            }

            return new string(code2);
        }


        public void ParseSerial(string serial)
        {
            if (serial.Length != 15)
                throw new Exception("Invalid Serial");

            foreach (char ch in serial)
                if (ch < '0' || ch > '9')
                    throw new Exception("Invalid Serial");

            int A2, B1, B2, C1, C2;

            //XXAXXAXBXCXCXBX

            int A1 = int.Parse(serial[9].ToString());
            A2 = int.Parse(serial[6].ToString());
            B1 = int.Parse(serial[11].ToString());
            B2 = int.Parse(serial[7].ToString());
            C1 = int.Parse(serial[2].ToString());
            C2 = int.Parse(serial[14].ToString());

            A1 = A1 ^ 1;
            A2 = A2 ^ 1;
            B1 = B1 ^ 1;
            B2 = B2 ^ 1;
            C1 = C1 ^ 1;
            C2 = C2 ^ 1;

            int A = (A1 * 10 + A2) ^ 34;
            int B = (B1 * 10 + B2) ^ 29;
            int C = (C1 * 10 + C2) ^ 43;

            this.A = A;
            this.B = B;
            this.C = C;
        }

        public string GetPreActivationCode(string serial, string systemSerial)
        {
            if (serial.Length != 15)
                throw new Exception("Invalid Serial");

            foreach (char ch in serial)
                if (ch < '0' || ch > '9')
                    throw new Exception("Invalid Serial");

            if (systemSerial.Length != 5)
                throw new Exception("Invalid System Serial");

            foreach (char ch in systemSerial)
                if (ch < '0' || ch > '9')
                    throw new Exception("Invalid System Serial");


            string result = "";

            for (int i = 0; i < 15; i++)
            {
                int x = int.Parse(serial[i].ToString());
                x ^= 1;
                result += x.ToString();

                if ((i + 1) % 3 == 0)
                {
                    int y = int.Parse(systemSerial[((i + 1) / 3) - 1].ToString());
                    y ^= 1;
                    result += y.ToString();
                }
            }

            if (result.Length != 20)
                throw new Exception("Internal Error");

            return result;
        }


        public void ParsePreActivationCode(string preCode)
        {
            if (preCode.Length != 20)
                throw new Exception("Invalid Serial");

            foreach (char ch in preCode)
                if (ch < '0' || ch > '9')
                    throw new Exception("Invalid Serial");


            int a1 = int.Parse(preCode[0].ToString()) ^ 1;
            int a2 = int.Parse(preCode[1].ToString()) ^ 1;
            int a3 = int.Parse(preCode[2].ToString()) ^ 1;
            int b1 = int.Parse(preCode[3].ToString()) ^ 1;

            int a4 = int.Parse(preCode[4].ToString()) ^ 1;
            int a5 = int.Parse(preCode[5].ToString()) ^ 1;
            int a6 = int.Parse(preCode[6].ToString()) ^ 1;
            int b2 = int.Parse(preCode[7].ToString()) ^ 1;


            int a7 = int.Parse(preCode[8].ToString()) ^ 1;
            int a8 = int.Parse(preCode[9].ToString()) ^ 1;
            int a9 = int.Parse(preCode[10].ToString()) ^ 1;
            int b3 = int.Parse(preCode[11].ToString()) ^ 1;

            int a10 = int.Parse(preCode[12].ToString()) ^ 1;
            int a11 = int.Parse(preCode[13].ToString()) ^ 1;
            int a12 = int.Parse(preCode[14].ToString()) ^ 1;
            int b4 = int.Parse(preCode[15].ToString()) ^ 1;

            int a13 = int.Parse(preCode[16].ToString()) ^ 1;
            int a14 = int.Parse(preCode[17].ToString()) ^ 1;
            int a15 = int.Parse(preCode[18].ToString()) ^ 1;
            int b5 = int.Parse(preCode[19].ToString()) ^ 1;


            this.pSerial = a1 + a2.ToString() + a3.ToString() + a4.ToString() + a5.ToString() +
                a6.ToString() + a7.ToString() + a8.ToString() + a9.ToString() + a10.ToString() + a11.ToString() +
                a12.ToString() + a13 + a14.ToString() + a15.ToString();


            this.sSerial = b1.ToString() + b2.ToString() + b3 + b4.ToString() + b5.ToString();
        }


        public string GetActivationCode(string preCode)
        {
            if (preCode.Length != 20)
                throw new Exception("Invalid Serial");

            foreach (char ch in preCode)
                if (ch < '0' || ch > '9')
                    throw new Exception("Invalid Serial");


            char[] code = { '9', '3', '0', '2', '2', '4', '7', '8', '2', '3', '3', '9', '5', '4', '0', '8', '2', '1', '9', '6' };

            string result = "";
            for (int i = 0; i < 20; i++)
            {
                int x = Convert.ToInt32(code[i]) ^ Convert.ToInt32(preCode[i]);
                x *= 2;
                x += 1;
                result += x.ToString()[0].ToString();
            }


            if (result.Length != 20)
                throw new Exception("Internal Error");

            return result;
        }


        private string GetFirstCPUId()
        {
            string cpuInfo = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == String.Empty)
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
            }

            return cpuInfo;
        }

        public string GetFirstHardDiskID()
        {
            string diskInfo = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                // if (diskInfo == String.Empty)
                diskInfo = mo.Properties["Signature"].Value.ToString();
            }

            return diskInfo;
        }


    }

}
