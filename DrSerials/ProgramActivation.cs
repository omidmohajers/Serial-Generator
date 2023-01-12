using System;

namespace PA.SystemValidation
{
    public class ProgramActivation
    {
        public string AnswerActivationCodeRequest(string preCode, string mobile)
        {
            string error = string.Empty;

            if (preCode.Length != 20)
                error = "Your code len Must 20 digits";

            foreach (char ch in preCode)
                if (ch < '0' || ch > '9')
                    error = "Your Code Must Be a digit";

            if (error != string.Empty)
                return error;

            PCS pcs = new PCS();

            try
            {
                pcs.ParsePreActivationCode(preCode);
                string sn = pcs.pSerial;
                string sysSn = pcs.sSerial;

                Serial serial = Serial.Get(sn);
                if (serial == null)
                {
                    error = "Invalid Serial";
                    return error;
                }

                if (serial.IsActivated && serial.SystemCode != sysSn)
                {
                    error = "Your Serial Used And Invalid";
                    return error;
                }


                serial.IsActivated = true;
                serial.ACVDateTime = DateTime.Now;
                serial.ACVMobile = String.Format("{0}{1} - ", serial.ACVMobile, mobile);
                serial.SystemCode = sysSn;


                Serial.Update(serial);

                string acCode = pcs.GetActivationCode(preCode);
                return acCode;
            }
            catch
            {
                return "Error : Contact Us";
            }
        }
    }
}
