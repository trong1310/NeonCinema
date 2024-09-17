//using Bogus.DataSets;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Twilio;
//using Twilio.Types;
//using Twilio.Rest.Api.V2010.Account;

//namespace NeonCinema_Infrastructure.Authenticationmanagement
//{
//    public class VerificationService
//    {
//        private readonly string _twilioAccountSid = "YOUR_TWILIO_ACCOUNT_SID";
//        private readonly string _twilioAuthToken = "YOUR_TWILIO_AUTH_TOKEN";
//        private readonly string _twilioPhoneNumber = "YOUR_TWILIO_PHONE_NUMBER";

//        public VerificationService()
//        {
//            TwilioClient.Init(_twilioAccountSid, _twilioAuthToken);
//        }


//        public string GenerateVerificationCode()
//        {
//            Random random = new Random();
//            var digits = new HashSet<int>();
//            while (digits.Count < 5)
//            {
//                digits.Add(random.Next(0, 10));
//            }
//            return string.Join("", digits);
//        }

//        public async Task<bool> SendVerificationCodeAsync(string phoneNumber, string code)
//        {
//            try
//            {
//                var message = await MessageResource.CreateAsync(
//                    body: $"Your verification code is {code}",
//                    from: new PhoneNumber(_twilioPhoneNumber),
//                    to: new PhoneNumber(phoneNumber)
//                );
//                return message.Status == MessageResource.StatusEnum.Queued ||
//                       message.Status == MessageResource.StatusEnum.Sent ||
//                       message.Status == MessageResource.StatusEnum.Delivered;
//            }
//            catch (Exception ex)
//            {
//                // Log exception
//                return false;
//            }
//        }
//    }
//}
