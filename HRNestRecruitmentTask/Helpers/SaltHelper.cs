using System;
using System.Security.Cryptography;

namespace HRNestRecruitmentTask.Helpers
{
    public static class SaltHelper
    {
        public static string GenerateSalt()
        {
            byte[] bytes = new byte[128 / 8];
            using (var keyGenerator = RandomNumberGenerator.Create())
            {
                keyGenerator.GetBytes(bytes);
                return BitConverter.ToString(bytes);
            }
        }
    }
}